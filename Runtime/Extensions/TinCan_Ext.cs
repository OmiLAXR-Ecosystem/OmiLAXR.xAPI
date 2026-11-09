/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Newtonsoft.Json.Linq;
using OmiLAXR.xAPI.Composers;
using xAPI.Registry;
using tc = TinCan;

namespace OmiLAXR.xAPI.Extensions
{
    /// <summary>
    /// Extension methods for converting xAPI Registry objects to TinCan library format.
    /// Provides comprehensive transformation capabilities between the OmiLAXR/xAPI Registry
    /// data structures and the TinCan.NET library objects required for HTTP transmission
    /// to Learning Record Store endpoints, ensuring xAPI specification compliance.
    /// </summary>
    public static class TinCan_Ext
    {
        
        /// <summary>
        /// Assigns xAPI Registry extensions to a JSON object with properly formatted URIs.
        /// Handles the conversion of extension key-value pairs into xAPI-compliant JSON format,
        /// ensuring proper URI resolution and null value handling for robust data transmission.
        /// </summary>
        /// <param name="extensions">xAPI Registry extensions collection to convert</param>
        /// <param name="jObject">Target JSON object to populate with extension data</param>
        /// <param name="uri">Base URI for resolving relative extension identifiers</param>
        public static void AssignTo(this xAPI_Extensions extensions, string uri, JObject jObject)
        {
            // Skip processing if target object is null to prevent exceptions
            if (jObject == null)
                return;
                
        #if UNITY_2021_1_OR_NEWER 
            // Use modern C# deconstruction syntax for newer Unity versions
            foreach (var (extension, value) in extensions)
            {
                var id = extension.CreateId(uri);
                jObject.Add(id, ToJsonToken(value));
            }
        #else
            // Use traditional KeyValuePair iteration for older Unity versions
            foreach (var kvp in extensions)
            {
                var id = kvp.Key.CreateId(uri);
                jObject.Add(id, ToJsonToken(kvp.Value));
            }
        #endif
        }
        
        private static JToken ToJsonToken(object v)
        {
            if (v == null)
                return JValue.CreateNull();

            if (v is JToken token)
                return token.DeepClone();

            if (v is IDictionary dict)
                return ExpandDictionary(dict);

            if (v is IEnumerable e && !(v is string))
                return ExpandArray(e);

            try
            {
                return JToken.FromObject(v);
            }
            catch
            {
                return new JValue(v.ToString());
            }
        }
        
        private static JArray ExpandArray(IEnumerable array)
        {
            var items = new JArray();

            foreach (var item in array)
            {
                items.Add(ToJsonToken(item));
            }

            return items;
        }

        private static JObject ExpandDictionary(IDictionary dict)
        {
            var items = new JObject();

            foreach (DictionaryEntry entry in dict)
            {
                var key = Convert.ToString(entry.Key, CultureInfo.InvariantCulture) ?? "null";
                items[key] = ToJsonToken(entry.Value);
            }

            return items;
        }

        /// <summary>
        /// Converts an OmiLAXR xApiStatement to a TinCan Statement for HTTP transmission.
        /// Performs comprehensive mapping of all statement components including actor, verb,
        /// activity, context, result, and metadata while ensuring xAPI specification compliance
        /// and proper handling of optional components and extensions.
        /// </summary>
        /// <param name="s">The xApiStatement instance to convert</param>
        /// <returns>TinCan Statement ready for transmission to an LRS endpoint</returns>
        public static tc.Statement ToTinCanStatement(this xApiStatement s)
        {
            var customTimestamp = s.GetTimestamp();
            var actor = s.GetActor();
            var version = s.GetVersion();
            
            var stmt = new tc.Statement()
            {
                // Statement metadata and identification
                id = s.GetId(),
                timestamp = customTimestamp ?? s.CreatedAt, // Use custom timestamp or creation time
                version = version,          // Latest xAPI version
                authority = s.GetAuthority().ToTinCanAgent(),
                attachments = s.GetAttachments().ToList(),
                
                // Actor - handle both individual and group actors
                actor = s.IsInGroup ? 
                    actor.ToTinCanAgentGroup(s.GetGroupMembers()) : 
                    actor.ToTinCanAgent(),
                    
                // Verb with proper URI resolution
                verb = s.GetVerb().ToTinCanVerb(s.GetUri()),
                
                // Activity with extensions and interaction data
                target = s.GetActivity().ToTinCanActivity(
                    s.GetUri(), 
                    s.GetActivityExtensions(), 
                    s.GetInteractionType(), 
                    s.GetCorrectResponses()),
                    
                // Context with environmental and social information
                context = s.GetContextExtensions().ToTinCanContext(
                    version,
                    s.GetUri(), 
                    s.GetLanguage(), 
                    s.GetPlatform(), 
                    s.GetInstructor(), 
                    s.GetTeam(), 
                    s.GetTeamMembers(), 
                    s.GetRegistration(),
                    s.GetRefId()),
                    
                // Result with performance and outcome data
                result = s.GetResultExtensions().ToTinCanResult(
                    s.GetUri(), 
                    s.GetScore(), 
                    s.GetCompletion(), 
                    s.GetSuccess(), 
                    s.GetResponse(),
                    s.GetDuration()),
            };
            return stmt;
        }

        /// <summary>
        /// Converts xAPI Registry context extensions to a TinCan Context object.
        /// Handles the mapping of contextual information including instructor, team,
        /// registration, platform, and language data with proper extension formatting
        /// and optional statement reference handling for linked statements.
        /// </summary>
        /// <param name="extensions">Context extensions from xAPI Registry</param>
        /// <param name="version">xAPI Standard version</param>
        /// <param name="uri">Base URI for extension resolution</param>
        /// <param name="language">Language code for the statement</param>
        /// <param name="platform">Platform identifier</param>
        /// <param name="instructor">Optional instructor actor</param>
        /// <param name="team">Optional team actor</param>
        /// <param name="teamMembers">Optional team member actors</param>
        /// <param name="registration">Optional registration UUID</param>
        /// <param name="refId">Optional reference statement ID for linking</param>
        /// <returns>TinCan Context object with mapped contextual data</returns>
        public static tc.Context ToTinCanContext(this xAPI_Extensions_Context extensions, tc.TCAPIVersion version, string uri, string language, string platform, xAPI_Actor? instructor = null, xAPI_Actor? team = null, xAPI_Actor[] teamMembers = null, Guid? registration = null, Guid? refId = null)
        {
            // instructor and team are deprecated in xAPI 2.0 only; xAPI 1.0.x statements still need them
#pragma warning disable CS0618
            var ctx = new tc.Context()
            {
                instructor = instructor?.ToTinCanAgent(),
                extensions = extensions?.ToTinCanExtensions(uri),
                registration = registration,
                team = team?.ToTinCanAgentTeam(teamMembers),
                language = language,
                platform = platform,
            };
#pragma warning restore CS0618

            if (version.Equals(tc.TCAPIVersion.V200))
            {
                var iAgent = instructor?.ToTinCanAgent();
                if (iAgent != null)
                {
                    ctx.contextAgents = new List<tc.ContextAgent>(1)
                    {
                        new tc.ContextAgent()
                        {
                            agent = iAgent // todo: find more
                        }
                    };
                }

                // var iTeam = team?.ToTinCanAgentTeam(teamMembers);
                // if (iTeam != null)
                // {
                //     ctx.contextGroups = new List<tc.ContextGroup>(1);
                //     ctx.contextGroups.Add(new tc.ContextGroup() { group = new tc.Group()} ]});
                // }

            }
            
            // Add statement reference if provided for linked statements
            if (refId.HasValue)
                ctx.statement = new tc.StatementRef(refId.Value);

            return ctx;
        }

        /// <summary>
        /// Converts xAPI Registry result extensions to a TinCan Result object.
        /// Maps performance outcomes, scores, completion status, and custom extensions
        /// into the standardized TinCan format for learning outcome tracking and analysis.
        /// </summary>
        /// <param name="extensions">Result extensions from xAPI Registry</param>
        /// <param name="uri">Base URI for extension resolution</param>
        /// <param name="score">Optional score information</param>
        /// <param name="completion">Optional completion status</param>
        /// <param name="success">Optional success indicator</param>
        /// <param name="response">Optional learner response text</param>
        /// <param name="duration">Optional activity duration</param>
        /// <returns>TinCan Result object with mapped performance data</returns>
        public static tc.Result ToTinCanResult(this xAPI_Extensions_Result extensions, string uri, tc.Score score = null, bool? completion = null, bool? success = null, string response = null, TimeSpan? duration = null)
        {
            return new tc.Result
            {
                score = score,
                completion = completion,
                success = success,
                extensions = extensions?.ToTinCanExtensions(uri),
                response = response,
                duration = duration,
            };
        }

        /// <summary>
        /// Creates a valid URI from an xAPI Registry definition with proper relative/absolute handling.
        /// Ensures URI compliance for xAPI specifications while handling both relative and absolute
        /// URI formats depending on the provided base URI context.
        /// </summary>
        /// <param name="definition">xAPI Registry definition to create URI for</param>
        /// <param name="uri">Base URI for relative resolution</param>
        /// <returns>Properly formatted Uri instance for xAPI compliance</returns>
        public static Uri CreateValidUri(this xAPI_Definition definition, string uri)
        {
            var isRelative = string.IsNullOrEmpty(uri) || uri == "/";

            var id = definition.CreateValidId(uri);
            
            return new Uri(id, isRelative ? UriKind.Relative : UriKind.RelativeOrAbsolute);
        }


        /// <summary>
        /// Converts an xAPI Registry verb to a TinCan Verb with proper URI and display names.
        /// Maps verb identifiers and multilingual display names into the TinCan format
        /// required for xAPI statement transmission and LRS compatibility.
        /// </summary>
        /// <param name="verb">xAPI Registry verb to convert</param>
        /// <param name="uri">Base URI for verb identifier resolution</param>
        /// <returns>TinCan Verb object with mapped identifier and display names</returns>
        public static tc.Verb ToTinCanVerb(this xAPI_Verb verb, string uri)
        {
            var v = new tc.Verb
            {
                id = CreateValidUri(verb, uri),
                display = new tc.LanguageMap()
            };

            // Map all multilingual verb display names
            foreach (var name in verb.Names)
                v.display.Add(name.Key, name.Value);

            return v;
        }

        /// <summary>
        /// Creates an identifier string from an xAPI Registry definition.
        /// Conditional compilation ensures compatibility with or without the xAPI Registry,
        /// providing appropriate fallback behavior when the registry is not available.
        /// </summary>
        /// <param name="definition">xAPI Registry definition</param>
        /// <param name="uri">Base URI for identifier creation</param>
        /// <returns>Identifier string or empty string if registry unavailable</returns>
        #if XAPI_REGISTRY_EXISTS
        public static string CreateId(this xAPI_Definition definition, string uri)
            => string.IsNullOrEmpty(uri) ? definition.GetPath() : definition.CreateValidId(uri);
        #else
        public static string CreateId(this xAPI_Definition definition, string uri) => "";
        #endif
        
        /// <summary>
        /// Converts an xAPI Registry activity to a TinCan Activity with extensions and interactions.
        /// Maps activity definitions, custom extensions, and interaction data into the
        /// TinCan format for comprehensive learning activity representation.
        /// </summary>
        /// <param name="activity">xAPI Registry activity to convert</param>
        /// <param name="uri">Base URI for activity identifier resolution</param>
        /// <param name="extensions">Optional activity extensions</param>
        /// <param name="interactionType">Optional interaction type specification</param>
        /// <param name="correctResponsesPattern">Optional correct response patterns for assessments</param>
        /// <returns>TinCan Activity object with mapped activity data</returns>
        public static tc.Activity ToTinCanActivity(this xAPI_Activity activity, string uri, xAPI_Extensions extensions = null, tc.InteractionType interactionType = null, List<string> correctResponsesPattern = null)
        {            
            var a = new tc.Activity(activity.CreateValidUri(uri));
            a.definition = activity.ToTinCanActivityDefinition();
            
            // Add optional components if provided
            a.definition.extensions = extensions?.ToTinCanExtensions(uri);
            a.definition.interactionType = interactionType;
            a.definition.correctResponsesPattern = correctResponsesPattern;

            return a;
        }
        
        /// <summary>
        /// Converts an xAPI_Actor to a TinCan Group representing a team with members.
        /// Creates a group agent that includes both team identification and individual
        /// member actors for comprehensive team-based learning analytics.
        /// </summary>
        /// <param name="actor">Team actor to convert</param>
        /// <param name="members">Array of team member actors</param>
        /// <returns>TinCan Group representing the team and its members</returns>
        public static tc.Agent ToTinCanAgentTeam(this xAPI_Actor actor, xAPI_Actor[] members)
        {
            return new tc.Group()
            {
                name = actor.Name,
                mbox = "mailto:" + actor.Email,
                member = members.Select(m => m.ToTinCanAgent()).ToList()
            };
        }
        
        /// <summary>
        /// Converts an xAPI_Actor to a TinCan Agent for individual actor representation.
        /// Maps actor name and email into the standardized TinCan agent format
        /// required for xAPI statement actor identification.
        /// </summary>
        /// <param name="actor">xAPI actor to convert</param>
        /// <returns>TinCan Agent object with mapped actor data</returns>
        public static tc.Agent ToTinCanAgent(this xAPI_Actor actor)
        {
            return new tc.Agent
            {
                name = actor.Name,
                mbox = "mailto:" + actor.Email
            };
        }
        
        /// <summary>
        /// Converts an xAPI_Actor to a TinCan Group with named group and member list.
        /// Creates a group agent that includes both group identification and individual
        /// member actors for scenarios requiring explicit group membership tracking.
        /// </summary>
        /// <param name="actor">Group actor to convert</param>
        /// <param name="members">Array of group member actors</param>
        /// <returns>TinCan Group representing the named group and its members</returns>
        public static tc.Group ToTinCanAgentGroup(this xAPI_Actor actor, xAPI_Actor[] members)
        {
            return new tc.Group()
            {
                name = actor.Name,
                mbox = "mailto:" + actor.Email,
                member = members.Select(m => m.ToTinCanAgent()).ToList()
            };
        }
        
        /// <summary>
        /// Converts xAPI Registry extensions to TinCan Extensions format.
        /// Transforms extension key-value pairs into the JSON-based TinCan extensions
        /// format required for xAPI statement transmission and LRS storage.
        /// </summary>
        /// <param name="extensions">xAPI Registry extensions to convert</param>
        /// <param name="uri">Base URI for extension identifier resolution</param>
        /// <returns>TinCan Extensions object with mapped extension data</returns>
        public static tc.Extensions ToTinCanExtensions(this xAPI_Extensions extensions, string uri)
        {
            var jObject = new JObject();
            extensions.AssignTo(uri, jObject);
            
            var isRelative = string.IsNullOrEmpty(uri) || uri == "/";

            return new tc.Extensions(jObject, isRelative ? UriKind.Relative : UriKind.RelativeOrAbsolute);
        }
        
        /// <summary>
        /// Converts an xAPI Registry definition to a TinCan ActivityDefinition.
        /// Maps multilingual names and descriptions from the xAPI Registry format
        /// to the TinCan LanguageMap format for international compatibility.
        /// </summary>
        /// <param name="definition">xAPI Registry definition to convert</param>
        /// <returns>TinCan ActivityDefinition with mapped multilingual content</returns>
        public static tc.ActivityDefinition ToTinCanActivityDefinition(this xAPI_Definition definition)
        {
            return new tc.ActivityDefinition
            {
                // Map xAPI Registry name definitions to TinCan LanguageMap format
                name = new tc.LanguageMap(definition.Names),
                description = new tc.LanguageMap(definition.Descriptions)
            };
        }
    }
}
