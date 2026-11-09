/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using OmiLAXR.Composers;
using OmiLAXR.Extensions;
using OmiLAXR.TrackingBehaviours;
using OmiLAXR.Types;
using OmiLAXR.Utils;
using OmiLAXR.xAPI.Extensions;
using TinCan;
using xAPI.Registry;

namespace OmiLAXR.xAPI.Composers
{
    /// <summary>
    /// Represents an xAPI statement for tracking learning experiences.
    /// Implements the Experience API (xAPI) specification.
    /// </summary>
    // ReSharper disable InconsistentNaming
    public sealed class xApiStatement : IStatement
    // ReSharper restore InconsistentNaming
    {
        /// <summary>
        /// Builder class for creating xAPI statements with fluent API pattern.
        /// </summary>
        public sealed class Builder
        {
            internal readonly Author Author; // The statement author/authority
            internal readonly string Uri; // Base URI for identifiers
            internal readonly IComposer Composer;

            /// <summary>
            /// Creates a new Builder with the specified URI and author.
            /// </summary>
            internal Builder(string uri, Author author, IComposer composer)
            {
                Uri = uri;
                Author = author;
                Composer = composer;
            }

            /// <summary>
            /// Alias for Verb() that provides a more natural language API.
            /// </summary>
            public PreStatement Does(xAPI_Verb verb)
                => new PreStatement(this, verb);
        }

        public readonly struct PreStatement
        {
            internal readonly Builder Builder;
            internal readonly xAPI_Verb Verb;
            internal PreStatement(Builder builder, xAPI_Verb verb)
            {
                Builder = builder;
                Verb = verb;
            }

            public xApiStatement Activity(xAPI_Activity activity)
                => new xApiStatement(this, activity);
        }

        // Core statement components
        private readonly Guid _id = Guid.NewGuid();
        private Guid? _refId = null;
        private xAPI_Verb _verb; // The action performed
        private xAPI_Activity _activity; // The object/activity acted upon
        private xAPI_Actor _actor; // The person/entity performing the action
        private List<xAPI_Actor> _groupMembers = new List<xAPI_Actor>(0); // For group actors
        private List<xAPI_Actor> _teamMembers = new List<xAPI_Actor>(0); // For team context
        private xAPI_Actor? _instructor; // Optional instructor
        private xAPI_Actor _authority; // Statement authority
        private xAPI_Actor? _team; // Optional team
        private string _language = "en"; // Default language code
        private string _platform = "OmiLAXRv2"; // Platform identifier
        private InteractionType _interactionType; // Interaction type
        private List<string> _correctResponses = new List<string>(0); // Correct responses
        private TimeSpan? _duration;

        // Extension collections for different parts of the statement
        private readonly xAPI_Extensions_Activity _activityExtensions;
        //private readonly xAPI_Extensions_Activity _activityGroup = new xAPI_Extensions_Activity();
        //private readonly xAPI_Extensions_Activity _activityParent = new xAPI_Extensions_Activity();
        //private readonly xAPI_Extensions_Activity _activityCategory = new xAPI_Extensions_Activity();
        private readonly xAPI_Extensions_Context _contextExtensions;
        private readonly xAPI_Extensions_Result _resultExtensions;

        // Accessor methods for extensions
        public xAPI_Extensions_Activity GetActivityExtensions() => _activityExtensions;
        public xAPI_Extensions_Context GetContextExtensions() => _contextExtensions;
        public xAPI_Extensions_Result GetResultExtensions() => _resultExtensions;
        public xAPI_Activity GetActivity() => _activity;

        // Cached arrays to avoid per-call allocations from ToArray()
        private xAPI_Actor[] _groupMembersCached = Array.Empty<xAPI_Actor>();
        private xAPI_Actor[] _teamMembersCached = Array.Empty<xAPI_Actor>();
        private bool _groupDirty = true;
        private bool _teamDirty = true;

        public delegate xAPI_Extensions ExtensionActionDelegate(object value);
        /// <summary>
        /// Deprecated method for accessing activity extension values.
        /// </summary>
        [Obsolete("Use 'GetExtensionValue<T>(string)' instead.")]
        public T? GetActivityExtensionValue<T>(string key, T? defaultValue = null) where T : struct
            => GetExtensionValue(key, defaultValue);

        /// <summary>
        /// Retrieves an activity extension value by key with type conversion.
        /// </summary>
        public T? GetExtensionValue<T>(string key, T? defaultValue = null) where T : struct
        {
            // LINQ-free to avoid GC allocations in hot paths
            foreach (var kvp in _activityExtensions)
            {
                if (kvp.Key.Key != key) continue;
                if (kvp.Value is T typedValue) return typedValue;
                break; // key found, but type mismatch
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves an extension value by extension object, selecting the appropriate
        /// extension collection based on the extension type.
        /// </summary>
        public T? GetValue<T>(xAPI_Extension ext, T? defaultValue = null) where T : struct
        {
#if XAPI_REGISTRY_EXISTS
            switch (ext.extensionType)
            {
                case "result":
                    return GetResultValue(ext, defaultValue);
                case "context":
                    return GetContextValue(ext, defaultValue);
                case "activity":
                    return GetExtensionValue(ext, defaultValue);
                default:
                    throw new ArgumentException($"Extension type '{ext.extensionType}' is not supported.");
            }
#else
            return null;
#endif
        }

#if XAPI_REGISTRY_EXISTS
        public T? GetValue<T>(ExtensionActionDelegate action, T? defaultValue = null) where T : struct
            => GetValue(action(null)[0].Key, defaultValue);
#else
        public T? GetValue<T>(ExtensionActionDelegate action, T? defaultValue = null) where T : struct => null;
#endif

        public Guid GetId() => _id;

        /// <summary>
        /// Retrieves an activity extension value by extension object.
        /// </summary>
        public T? GetExtensionValue<T>(xAPI_Extension extension, T? defaultValue = null) where T : struct
            => GetExtensionValue(extension.Key, defaultValue);

        /// <summary>
        /// Retrieves a context extension value by key with type conversion.
        /// </summary>
        public T? GetContextValue<T>(string key, T? defaultValue = null) where T : struct
        {
            // LINQ-free to avoid GC allocations in hot paths
            foreach (var kvp in _contextExtensions)
            {
                if (kvp.Key.Key != key) continue;
                if (kvp.Value is T typedValue) return typedValue;
                break; // key found, but type mismatch
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a context extension value by extension object.
        /// </summary>
        public T? GetContextValue<T>(xAPI_Extension extension, T? defaultValue = null) where T : struct
            => GetContextValue(extension.Key, defaultValue);

        /// <summary>
        /// Retrieves a result extension value by key with type conversion.
        /// </summary>
        public T? GetResultValue<T>(string key, T? defaultValue = null) where T : struct
        {
            // LINQ-free to avoid GC allocations in hot paths
            foreach (var kvp in _resultExtensions)
            {
                if (kvp.Key.Key != key) continue;
                if (kvp.Value is T typedValue) return typedValue;
                break; // key found, but type mismatch
            }

            return defaultValue;
        }

        /// <summary>
        /// Retrieves a result extension value by extension object.
        /// </summary>
        public T? GetResultValue<T>(xAPI_Extension extension, T? defaultValue = null) where T : struct
            => GetResultValue(extension.Key, defaultValue);

        public bool IsFromComposer<T>() where T : IComposer => GetComposer().GetType() == typeof(T);

        // Accessors for statement components
        public xAPI_Actor[] GetGroupMembers()
        {
            if (_groupDirty)
            {
                _groupMembersCached = _groupMembers.Count == 0 ? Array.Empty<xAPI_Actor>() : _groupMembers.ToArray();
                _groupDirty = false;
            }
            return _groupMembersCached;
        }

        public bool IsInGroup => _groupMembers.Count > 0;
        public xAPI_Verb GetVerb() => _verb;
        public xAPI_Actor GetActor() => _actor;
        public xAPI_Actor? GetTeam() => _team;

        public xAPI_Actor[] GetTeamMembers()
        {
            if (_teamDirty)
            {
                _teamMembersCached = _teamMembers.Count == 0 ? Array.Empty<xAPI_Actor>() : _teamMembers.ToArray();
                _teamDirty = false;
            }
            return _teamMembersCached;
        }

        public string GetLanguage() => _language;
        public Score GetScore() => _score;
        public bool? GetSuccess() => _success;
        public bool? GetCompletion() => _completion;
        public string GetResponse() => _response;
        public string GetPlatform() => _platform;
        public xAPI_Actor? GetInstructor() => _instructor;
        public xAPI_Actor GetAuthority() => _authority;
        public Guid? GetRegistration() => _registration;
        public DateTime? GetTimestamp() => _timestamp;
        public string GetTimestampString() => _timestamp.ToRfc3339();
        public InteractionType GetInteractionType() => _interactionType;
        public List<string> GetCorrectResponses() => _correctResponses;
        public TimeSpan? GetDuration() => _duration;
        public string GetDurationString() => _duration.HasValue ? _duration.Value.ToIso8601() : "";
        public Guid? GetRefId() => _refId;

        /// <summary>
        /// Creation timestamp of this statement object.
        /// </summary>
        public readonly DateTime CreatedAt = Clock.Now;

        // Pipeline tracking information
        private PipelineInfo _senderPipelineInfo;

        public IStatement Clone()
            => new xApiStatement()
                {
                    _isDiscarded = _isDiscarded,
                    _activity = _activity,
                    _verb = _verb,
                    _actor = _actor,
                    _groupMembers = new List<xAPI_Actor>(_groupMembers),
                    _teamMembers = new List<xAPI_Actor>(_teamMembers),
                    _instructor = _instructor,
                    _authority = _authority,
                    _team = _team,
                    _language = _language,
                    _platform = _platform,
                    _score = _score,
                    _success = _success,
                    _completion = _completion,
                    _response = _response,
                    _timestamp = _timestamp,
                    _registration = _registration,
                    _refId = _refId,
                    _interactionType = _interactionType,
                    _correctResponses = new List<string>(_correctResponses),
                    _duration = _duration,
                    _attachments = new List<Attachment>(_attachments),
                    _uri = _uri,
                    _composer = _composer,
                    _senderPipelineInfo = _senderPipelineInfo,
                    _groupDirty = true,
                    _teamDirty = true
                }
                .WithExtension(_activityExtensions)
                .WithResult(_resultExtensions)
                .WithContext(_contextExtensions);

        /// <summary>
        /// Converts the statement to a standardized xAPI JSON format.
        /// </summary>
        public string ToDataStandardString(string version = null) => ToJsonString(pretty: false, version: version);

        /// <summary>
        /// Converts the statement to a JSON string, optionally pretty-printed.
        /// </summary>
        public string ToJsonString(bool pretty = false, string version = null)
        {
            return this.ToTinCanStatement().ToJSON(version != null ? Versions[version] : TCAPIVersion.V103, pretty);
        }

        public string ToShortString()
        {
            return $"[xAPI {_actor.Name} {_verb.Key} {_activity.Key}]";
        }

        /// <summary>
        /// Converts the statement to CSV format.
        /// </summary>
        public CsvFormat ToCsvFormat(bool flatten = false, string version = null)
        {
            // This function could be made more simple by just transforming to JSON and parsing by CsvFormat.FromJson.
            // But as we need as much performance and control as possible, the transformation is done manually.
            var origin = flatten ? "/" : GetOrigin();

            var formatKey = new Func<string, string>(s =>
                string.IsNullOrEmpty(origin) || origin == "/"
                    ? s.Replace("file:///", "").Replace('/', '_')
                    : s);

            var authority = _authority.ToTinCanAgent();
            var actor = _actor.ToTinCanAgent();
            var verb = _verb.ToTinCanVerb(origin);
            var activity = _activity.ToTinCanActivity(origin, _activityExtensions, _interactionType, _correctResponses);
            var context = _contextExtensions.ToTinCanContext(version == null ? GetVersion() : Versions[version], origin, _language, _platform, _instructor, _team, GetTeamMembers(), _registration);
            var result = _resultExtensions.ToTinCanResult(origin, _score, _completion, _success, _response, _duration);

            if (flatten)
            {
                var flatCsv = new CsvFormat(rowsCapacity: 1);
                var rowValues = new Dictionary<string, object>()
                {
                    { "id", _id },
                    { "version", _composer.GetDataStandardVersion() },
                    { "timestamp", GetTimestampString() },
                    { "origin", GetOrigin() }
                };

                foreach (var kvp in authority.ToJObject().Flatten())
                {
                    rowValues["authority_" + formatKey(kvp.Key)] = kvp.Value;
                }

                foreach (var kvp in actor.ToJObject().Flatten())
                {
                    rowValues["actor_" + formatKey(kvp.Key)] = kvp.Value;
                }

                // append verb
                foreach (var kvp in verb.ToJObject().Flatten())
                {
                    rowValues["verb_" + formatKey(kvp.Key)] = kvp.Value;
                }

                // append activity
                foreach (var kvp in activity.ToJObject().Flatten())
                {
                    rowValues["object_" + formatKey(kvp.Key)] = kvp.Value;
                }
                // append context
                foreach (var kvp in context.ToJObject().Flatten())
                {
                    rowValues["context_" + formatKey(kvp.Key)] = kvp.Value;
                }
                // append result
                foreach (var kvp in result.ToJObject().Flatten())
                {
                    rowValues["result_" + formatKey(kvp.Key)] = kvp.Value;
                }

                flatCsv.AddRow(rowValues);
                return flatCsv;
            }

            var csv = new CsvFormat(rowsCapacity: 1);
            csv.AddRow(new Dictionary<string, object>()
            {
                { "id", _id },
                { "version", _composer.GetDataStandardVersion() },
                { "timestamp", GetTimestampString() },
                { "origin", GetOrigin() },
                { "authority", formatKey(authority.ToJSON()) },
                { "actor", formatKey(actor.ToJSON()) },
                { "verb", formatKey(verb.ToJSON()) },
                { "object", formatKey(activity.ToJSON()) },
                { "context", formatKey(context.ToJSON()) },
                { "result", formatKey(result.ToJSON()) },
            });

            return csv;
        }

        /// <summary>
        /// Gets information about the pipeline that sent this statement.
        /// </summary>
        public PipelineInfo GetSenderPipelineInfo() => _senderPipelineInfo;

        // Result-related properties
        private Score _score;
        private bool? _success;
        private bool? _completion;
        private string _response;
        private DateTime _timestamp;
        private Guid? _registration;
        private string _uri;

        private List<Attachment> _attachments = new List<Attachment>();
        // State tracking
        private bool _isDiscarded;
        private IComposer _composer;

        /// <summary>
        /// Gets the origin URI of the statement (alias for GetUri).
        /// </summary>
        public string GetOrigin() => GetUri();

        /// <summary>
        /// Sets the origin URI of the statement (alias for GetUri).
        /// </summary>
        public void SetOrigin(string origin)
            => _uri = origin;

        /// <summary>
        /// Gets the URI of the statement.
        /// </summary>
        public string GetUri() => _uri;

        /// <summary>
        /// Sets the composer that created this statement.
        /// </summary>
        public void SetComposer(IComposer sender)
            => _composer = sender;

        /// <summary>
        /// Sets the owner (tracking behavior) of this statement.
        /// This configures actor information and other actor-related properties.
        /// </summary>
        public void SetOwner(ITrackingBehaviour trackingBehaviour)
        {
            var actor = trackingBehaviour.GetActor();
            var instructor = trackingBehaviour.GetInstructor();

            _actor = actor.ToXAPIActor();

            // Handle group actors
            if (actor.IsGroupActor)
            {
                _groupMembers = ((ActorGroup)actor).GetMembers().ToXAPIActors().ToList();
                _groupDirty = true;
            }
            else
            {
                if (_groupMembers.Count != 0) _groupMembers.Clear();
                _groupDirty = true;
            }

            // Handle team information
            if (actor.HasTeam)
            {
                _team = actor.team.ToXAPIActor();
                _teamMembers = actor.team.GetMembers().ToXAPIActors().ToList();
                _teamDirty = true;
            }
            else
            {
                _team = null;
                if (_teamMembers.Count != 0) _teamMembers.Clear();
                _teamDirty = true;
            }

            // Handle instructor information
            if (instructor)
            {
                _instructor = instructor.ToXAPIActor();
            }

            _senderPipelineInfo = new PipelineInfo(actor.Pipeline);
        }

        /// <summary>
        /// Gets the composer that created this statement.
        /// </summary>
        public IComposer GetComposer() => _composer;

        /// <summary>
        /// Checks if the statement has been discarded.
        /// </summary>
        public bool IsDiscarded() => _isDiscarded;

        #region Matching Methods

        /// <summary>
        /// Checks if both verb and activity match the specified paths.
        /// </summary>
        public bool MatchPaths(string verbPath, string activityPath, char pathSeperator = '.')
            => _verb.MatchesPath(verbPath, pathSeperator) && _activity.MatchesPath(activityPath, pathSeperator);

        /// <summary>
        /// Checks if both verb and activity match the specified keys.
        /// </summary>
        public bool MatchKeys(string verbKey, string activityKey)
            => _verb.Key == verbKey && _activity.Key == activityKey;

        /// <summary>
        /// Checks if the verb matches the specified path.
        /// </summary>
        public bool HasVerb(string verbPath)
            => GetVerb().MatchesPath(verbPath);

        /// <summary>
        /// Checks if the verb matches the specified key.
        /// </summary>
        public bool HasVerbKey(string verbKey)
            => GetVerb().Key == verbKey;

        /// <summary>
        /// Checks if the activity matches the specified path.
        /// </summary>
        public bool HasActivity(string activityPath)
            => GetActivity().MatchesPath(activityPath);

        /// <summary>
        /// Checks if the activity matches the specified key.
        /// </summary>
        public bool HasActivityKey(string activityKey)
            => GetActivity().Key == activityKey;

        /// <summary>
        /// Checks if a context extension with the specified key exists.
        /// </summary>
        public bool HasContextKey(string contextKey)
            => _contextExtensions.ContainsKey(contextKey);

        /// <summary>
        /// Checks if a context extension matching the specified path exists.
        /// </summary>
        public bool HasContext(string contextPath)
            => _contextExtensions.ContainsPath(contextPath);

        /// <summary>
        /// Checks if an activity extension with the specified key exists.
        /// </summary>
        public bool HasExtensionKey(string extensionKey)
            => _activityExtensions.ContainsKey(extensionKey);

        /// <summary>
        /// Checks if an activity extension matching the specified path exists.
        /// </summary>
        public bool HasExtension(string extensionPath)
            => _activityExtensions.ContainsPath(extensionPath);

        /// <summary>
        /// Checks if a result extension with the specified key exists.
        /// </summary>
        public bool HasResultKey(string resultKey)
            => _resultExtensions.ContainsKey(resultKey);

        /// <summary>
        /// Checks if a result extension matching the specified path exists.
        /// </summary>
        public bool HasResult(string resultPath)
            => _resultExtensions.ContainsPath(resultPath);

        #endregion

        /// <summary>
        /// Sets the activity object and optional activity extensions.
        /// </summary>
        public xApiStatement ChangeActivity(xAPI_Activity activity,
            xAPI_Extensions_Activity activityExtensions = null)
        {
            _activity = activity;

            if (activityExtensions != null)
                _activityExtensions.AddRange(activityExtensions);

            return this;
        }

        public xApiStatement ChangeObject(xAPI_Activity activity,
            xAPI_Extensions_Activity activityExtensions = null)
        {
            _activity = activity;
            if (activityExtensions != null)
                _activityExtensions.AddRange(activityExtensions);
            return this;
        }

        /// <summary>
        /// Sets the verb of the statement.
        /// </summary>
        public xApiStatement ChangeVerb(xAPI_Verb verb)
        {
            _verb = verb;
            return this;
        }

        /// <summary>
        /// Sets the URI of the statement.
        /// </summary>
        public xApiStatement WithUri(string uri)
        {
            _uri = uri;
            return this;
        }

        public xApiStatement WithCorrectResponses(List<string> correctResponses)
        {
            _correctResponses = correctResponses ?? new List<string>(0);
            return this;
        }

        public xApiStatement WithCorrectResponses(params string[] correctResponses)
        {
            _correctResponses = correctResponses == null || correctResponses.Length == 0
                ? new List<string>(0)
                : new List<string>(correctResponses);
            return this;
        }

        /// <summary>
        /// Type of interaction (e.g., choice, fill-in, likert, etc.).
        /// </summary>
        /// <param name="interactionType">Type of interaction (e.g., choice, fill-in, likert, etc.).</param>
        /// <returns></returns>
        public xApiStatement WithInteractionType(InteractionType interactionType)
        {
            _interactionType = interactionType;
            return this;
        }

        /// <summary>
        /// Deprecated method. Use WithExtension instead.
        /// </summary>
        [Obsolete("Use WithExtension(xAPI_Extensions_Activity activityExtensions) instead.", true)]
        public xApiStatement WithActivityExtension(xAPI_Extensions_Activity activityExtensions)
            => WithExtension(activityExtensions);

        /// <summary>
        /// Adds activity extensions to the statement.
        /// </summary>
        public xApiStatement WithExtension(xAPI_Extensions_Activity activityExtensions)
        {
            _activityExtensions.AddRange(activityExtensions);
            return this;
        }

        /// <summary>
        /// Adds extensions to the appropriate collection based on extension type.
        /// </summary>
        public xApiStatement WithValue(xAPI_Extensions extensions)
        {
#if XAPI_REGISTRY_EXISTS
            switch (extensions.ExtensionType)
            {
                case "activity":
                    _activityExtensions.AddRange(extensions);
                    break;
                case "context":
                    _contextExtensions.AddRange(extensions);
                    break;
                case "result":
                    _resultExtensions.AddRange(extensions);
                    break;
            }
#endif

            return this;
        }

        /// <summary>
        /// Sets the timestamp of the statement.
        /// </summary>
        public xApiStatement WithTimestamp(DateTime timestamp)
        {
            _timestamp = timestamp;
            return this;
        }

        public xApiStatement WithRef(Guid refId)
        {
            _refId = refId;
            return this;
        }

        public xApiStatement WithRef(IStatement statement)
        {
            _refId = statement.GetId();
            return this;
        }

        private static readonly Dictionary<string, TCAPIVersion> Versions = TCAPIVersion.GetSupported();
        public TCAPIVersion GetVersion() => Versions[GetComposer().GetDataStandardVersion()];

        /// <summary>
        /// Marks the statement as discarded, preventing it from being processed.
        /// </summary>
        public void Discard()
        {
            _isDiscarded = true;
        }

        /// <summary>
        /// Sets the actor of the statement directly. Use with caution.
        /// This overrides actor information that would normally come from the tracking behavior.
        /// </summary>
        public xApiStatement ByActor(xAPI_Actor actor)
        {
            _actor = actor;
            return this;
        }

        /// <summary>
        /// Sets the actor of the statement from an Actor object. Use with caution.
        /// This overrides actor information that would normally come from the tracking behavior.
        /// </summary>
        public xApiStatement ByActor(Actor actor)
        {
            _actor = actor.ToXAPIActor();
            return this;
        }

        /// <summary>
        /// Sets the team associated with the statement.
        /// </summary>
        public xApiStatement WithTeam(xAPI_Actor team)
        {
            _team = team;
            return this;
        }

        /// <summary>
        /// Sets the instructor associated with the statement.
        /// </summary>
        public xApiStatement WithInstructor(xAPI_Actor instructor)
        {
            _instructor = instructor;
            return this;
        }

        /// <summary>
        /// Sets the language code for the statement.
        /// </summary>
        public xApiStatement WithLanguage(string langCode)
        {
            _language = langCode;
            return this;
        }

        /// <summary>
        /// Sets the platform identifier for the statement.
        /// </summary>
        public xApiStatement WithPlatform(string platform)
        {
            _platform = platform;
            return this;
        }

        /// <summary>
        /// Sets the registration UUID for the statement.
        /// </summary>
        public xApiStatement WithRegistration(Guid uuid)
        {
            _registration = uuid;
            return this;
        }

        /// <summary>
        /// Removes all group members from the statement.
        /// </summary>
        public xApiStatement DropGroup()
        {
            _groupMembers.Clear();
            _groupDirty = true;
            return this;
        }

        /// <summary>
        /// Adds actors to the group members collection.
        /// </summary>
        public xApiStatement AddToGroup(params xAPI_Actor[] actors)
        {
            _groupMembers.AddRange(actors);
            _groupDirty = true;
            return this;
        }

        /// <summary>
        /// Removes specific actors from the group members collection.
        /// </summary>
        public xApiStatement RemoveFromGroup(params xAPI_Actor[] actors)
        {
            foreach (var actor in actors)
            {
                var index = _groupMembers.FindIndex(o => o.Email == actor.Email && o.Name == actor.Name);
                if (index >= 0) _groupMembers.RemoveAt(index);
            }

            _groupDirty = true;
            return this;
        }

        /// <summary>
        /// Removes all team members from the statement.
        /// </summary>
        public xApiStatement DropTeam()
        {
            _teamMembers.Clear();
            _teamDirty = true;
            return this;
        }

        /// <summary>
        /// Adds actors to the team members collection.
        /// </summary>
        public xApiStatement AddToTeam(params xAPI_Actor[] actors)
        {
            _teamMembers.AddRange(actors);
            _teamDirty = true;
            return this;
        }

        /// <summary>
        /// Removes specific actors from the team members collection.
        /// </summary>
        public xApiStatement RemoveFromTeam(params xAPI_Actor[] actors)
        {
            foreach (var actor in actors)
            {
                var index = _teamMembers.FindIndex(o => o.Email == actor.Email && o.Name == actor.Name);
                if (index >= 0) _teamMembers.RemoveAt(index);
            }

            _teamDirty = true;
            return this;
        }

        /// <summary>
        /// Sets the authority of the statement to a new actor with the specified name and email.
        /// </summary>
        public xApiStatement ChangedBy(string name, string email)
        {
            _authority = new xAPI_Actor(name, email);
            return this;
        }

        /// <summary>
        /// Removes an activity extension by path.
        /// </summary>
        public xApiStatement DropExtension(string path, char pathSeparator = '.')
        {
            _activityExtensions.Remove(path, pathSeparator);
            return this;
        }

        /// <summary>
        /// Removes an activity extension by key.
        /// </summary>
        public xApiStatement DropExtensionByKey(string key)
        {
            _activityExtensions.RemoveByKey(key);
            return this;
        }

        /// <summary>
        /// Removes all activity extensions.
        /// </summary>
        public xApiStatement DropExtensions()
        {
            _activityExtensions.Clear();
            return this;
        }

        /// <summary>
        /// Sets the success status of the statement.
        /// </summary>
        public xApiStatement WithSuccess(bool success)
        {
            this._success = success;
            return this;
        }

        /// <summary>
        /// Removes the success status from the statement.
        /// </summary>
        public xApiStatement DropSuccess()
        {
            _success = null;
            return this;
        }

        /// <summary>
        /// Sets the completion status of the statement.
        /// </summary>
        public xApiStatement WithCompletion(bool completion)
        {
            _completion = completion;
            return this;
        }

        public xApiStatement WithDuration(TimeSpan duration)
        {
            _duration = duration;
            return this;
        }

        public xApiStatement WithDuration(float durationInSeconds)
        {
            _duration = TimeSpan.FromSeconds(durationInSeconds);
            return this;
        }

        public xApiStatement WithDuration(Duration duration)
        {
            _duration = duration.ToTimeSpan();
            return this;
        }

        public xApiStatement AddAttachment(Attachment attachment)
        {
            _attachments.Add(attachment);
            return this;
        }

        public xApiStatement ClearAttachments()
        {
            _attachments.Clear();
            return this;
        }

        public IEnumerable<Attachment> GetAttachments() => _attachments;

        /// <summary>
        /// Removes the completion status from the statement.
        /// </summary>
        public xApiStatement DropCompletion()
        {
            _completion = null;
            return this;
        }

        /// <summary>
        /// Sets the response text of the statement.
        /// </summary>
        public xApiStatement WithResponse(string response)
        {
            this._response = response;
            return this;
        }

        /// <summary>
        /// Removes the response text from the statement.
        /// </summary>
        public xApiStatement DropResponse()
        {
            _response = null;
            return this;
        }

        /// <summary>
        /// Adds context extensions to the statement.
        /// </summary>
        public xApiStatement WithContext(xAPI_Extensions_Context extensions)
        {
            _contextExtensions.AddRange(extensions);
            return this;
        }

        /// <summary>
        /// Removes a context extension by path.
        /// </summary>
        public xApiStatement DropContext(string path, char pathSeparator = '.')
        {
            _contextExtensions.Remove(path, pathSeparator);
            return this;
        }

        /// <summary>
        /// Removes a context extension by key.
        /// </summary>
        public xApiStatement DropContextKey(string key)
        {
            _contextExtensions.RemoveByKey(key);
            return this;
        }

        /// <summary>
        /// Removes all context extensions.
        /// </summary>
        public xApiStatement DropContexts()
        {
            _contextExtensions.Clear();
            return this;
        }

        /// <summary>
        /// Adds result extensions to the statement.
        /// </summary>
        public xApiStatement WithResult(xAPI_Extensions_Result extensions)
        {
            _resultExtensions.AddRange(extensions);
            return this;
        }

        /// <summary>
        /// Removes a result extension by key.
        /// </summary>
        public xApiStatement DropResultKey(string key)
        {
            _resultExtensions.RemoveByKey(key);
            return this;
        }

        /// <summary>
        /// Removes a result extension by path.
        /// </summary>
        public xApiStatement DropResult(string path, char pathSeparator = '.')
        {
            _resultExtensions.Remove(path, pathSeparator);
            return this;
        }

        /// <summary>
        /// Removes all result extensions.
        /// </summary>
        public xApiStatement DropResults()
        {
            _resultExtensions.Clear();
            return this;
        }

        /// <summary>
        /// Sets the score information for the statement.
        /// </summary>
        /// <param name="raw">Raw score value</param>
        /// <param name="min">Minimum possible score</param>
        /// <param name="max">Maximum possible score (must not be zero)</param>
        /// <exception cref="ArgumentException">Thrown when max is 0</exception>
        public xApiStatement WithScore(double raw, double? min, double? max)
        {
            if (max == 0)
                throw new ArgumentException("The parameter 'max' is not allowed to be 0.");

            _score = new Score()
            {
                raw = raw,
                min = min,
                max = max,
                // xAPI requires scaled to be within [-1, 1]
                scaled = max.HasValue ? Math.Max(-1.0, Math.Min(1.0, raw / max.Value)) : (double?)null
            };

            return this;
        }

        /// <summary>
        /// Removes the score information from the statement.
        /// </summary>
        public xApiStatement DropScore()
        {
            _score = null;
            return this;
        }

        /// <summary>
        /// Creates a new xApiStatement with the specified builder and verb.
        /// Initializes default values and extension collections.
        /// </summary>
        private xApiStatement(PreStatement p, xAPI_Activity activity)
        {
            _uri = p.Builder.Uri;
            _composer = p.Builder.Composer;
            _timestamp = Clock.Now;
            _authority = new xAPI_Actor(p.Builder.Author.Name, p.Builder.Author.Email);
            _verb = p.Verb;
            _activity = activity;
            _contextExtensions = new xAPI_Extensions_Context();
            _resultExtensions = new xAPI_Extensions_Result();
            _activityExtensions = new xAPI_Extensions_Activity();
        }

        private xApiStatement()
        {
            // Ensure readonly extension collections exist even for Clone() base instance usage
            _contextExtensions = new xAPI_Extensions_Context();
            _resultExtensions = new xAPI_Extensions_Result();
            _activityExtensions = new xAPI_Extensions_Activity();
        }

        /// <summary>
        /// Returns a string representation of the xApiStatement for debugging.
        /// </summary>
        public override string ToString()
            =>
                $"[xApiStatement at: {GetTimestampString()}, verb: {_verb}, activity: {_activity}, ext: {_activityExtensions}, ctx: {_contextExtensions}, result: {_resultExtensions}, score: {_score}, success: {_success}, completion: {_completion}]";
    }
}