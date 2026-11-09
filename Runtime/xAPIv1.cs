/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
#if XAPI_REGISTRY_EXISTS
using System;
using System.Collections.Generic;
using System.Linq;
using OmiLAXR.xAPI.Extensions;
using TinCan;
using xAPI.Registry;
using OmiLAXR.Utils;

namespace OmiLAXR.xAPI
{
    /// <summary>
    /// Legacy static utility class for creating xAPI statements and components using TinCan.NET library.
    /// Provides backward compatibility and direct TinCan object creation methods for scenarios requiring
    /// explicit control over xAPI statement construction. Marked as obsolete to encourage migration
    /// to the newer, more flexible composer-based approach for better maintainability and extensibility.
    /// </summary>
    [Obsolete("Try to use composer instead.")]
    public static class xAPIv1
    {
        /// <summary>
        /// Creates a TinCan Agent from an xAPI_Actor instance for legacy compatibility.
        /// Wrapper method that extracts name and email from xAPI_Actor and delegates
        /// to the string-based CreateAgent method for consistent agent creation.
        /// </summary>
        /// <param name="actor">xAPI_Actor instance containing name and email information</param>
        /// <returns>TinCan Agent object ready for use in xAPI statements</returns>
        public static Agent CreateAgent(xAPI_Actor actor) => CreateAgent(actor.Name, actor.Email);
        
        /// <summary>
        /// Creates a TinCan Agent identified by email address according to xAPI specifications.
        /// Implements the standard xAPI actor identification pattern using mailto: scheme
        /// for reliable actor identification across different Learning Record Store systems
        /// and ensuring compliance with xAPI specification requirements.
        /// </summary>
        /// <param name="name">Human-readable display name for the actor</param>
        /// <param name="mail">Email address serving as unique identifier for the actor</param>
        /// <returns>TinCan Agent object with proper xAPI-compliant identification</returns>
        public static Agent CreateAgent(string name, string mail)
        {
            return new Agent
            {
                // Alternative account-based identification (commented out)
                //account = new AgentAccount(new Uri("https://learninglocker.net"), name),
                name = name,
                mbox = "mailto:" + mail  // xAPI standard email identification format
            };
        }

        /// <summary>
        /// Creates a TinCan Verb from xAPI Registry verb definition with proper URI resolution.
        /// Converts xAPI Registry verb definitions into TinCan format with multilingual display
        /// names and properly resolved URIs for xAPI specification compliance and LRS compatibility.
        /// </summary>
        /// <param name="uri">Base URI for verb identifier resolution</param>
        /// <param name="verb">xAPI Registry verb definition to convert</param>
        /// <returns>TinCan Verb object with resolved identifier and multilingual display names</returns>
        private static Verb CreateVerb(string uri, xAPI_Verb verb)
        {
            var v = new Verb
            {
                id = new Uri(verb.CreateValidId(uri)),  // Resolve verb URI using registry
                display = new LanguageMap()             // Multilingual verb display names
            };

            // Map all available multilingual names from registry to TinCan format
            foreach (var name in verb.Names)
                v.display.Add(name.Key, name.Value);

            return v;
        }

        
        /// <summary>
        /// Creates a TinCan Activity from xAPI Registry activity definition with optional extensions.
        /// Converts xAPI Registry activity definitions into TinCan format including activity
        /// definitions, multilingual content, and custom extensions for comprehensive activity representation.
        /// </summary>
        /// <param name="uri">Base URI for activity identifier resolution</param>
        /// <param name="activity">xAPI Registry activity definition to convert</param>
        /// <param name="extensions">Optional activity-specific extensions to include</param>
        /// <returns>TinCan Activity object with resolved identifier and extensions</returns>
        private static Activity CreateActivity(string uri, xAPI_Activity activity, xAPI_Extensions extensions = null)
        {            
            var a = new Activity
            {
                id = activity.CreateValidUri(uri),                          // Resolve activity URI
                definition = activity.ToTinCanActivityDefinition()         // Convert definition with multilingual content
            };

            // Add optional extensions if provided
            a.definition.extensions = extensions?.ToTinCanExtensions(uri);

            return a;
        }
        
        /// <summary>
        /// Separates mixed xAPI extensions into category-specific extension collections.
        /// Analyzes extension types and distributes them into appropriate categories
        /// (activity, context, result) for proper placement within xAPI statement structure
        /// according to xAPI specification requirements and semantic meaning.
        /// </summary>
        /// <param name="extensions">Mixed collection of xAPI extensions to categorize</param>
        /// <returns>Tuple containing categorized extension collections for each statement component</returns>
        public static (xAPI_Extensions_Activity, xAPI_Extensions_Context, xAPI_Extensions_Result) SplitExtensions(
            xAPI_Extensions extensions)
        {
            if (extensions == null)
                return (null, null, null);

            // Create category-specific extension collections
            var activityExtensions = new xAPI_Extensions_Activity();
            var contextExtensions = new xAPI_Extensions_Context();
            var resultExtensions = new xAPI_Extensions_Result();

            // Distribute extensions based on their declared type
            foreach (var ext in extensions)
            {
                if (activityExtensions.ExtensionType == ext.Key.extensionType)
                    activityExtensions.Add(ext);
                else if (contextExtensions.ExtensionType == ext.Key.extensionType)
                    contextExtensions.Add(ext);
                else if (resultExtensions.ExtensionType == ext.Key.extensionType)
                    resultExtensions.Add(ext);
            }

            return (activityExtensions, contextExtensions, resultExtensions);
        }

        /// <summary>
        /// Creates a complete xAPI Statement for individual actors with comprehensive component mapping.
        /// Assembles all statement components including actor, verb, activity, context, result,
        /// and metadata into a properly formatted TinCan Statement ready for LRS transmission
        /// with full xAPI specification compliance and extensibility support.
        /// </summary>
        /// <param name="uri">Base URI for identifier resolution</param>
        /// <param name="actor">Actor performing the action</param>
        /// <param name="verb">Action being performed</param>
        /// <param name="activity">Target activity of the action</param>
        /// <param name="activityExtensions">Optional activity-specific extensions</param>
        /// <param name="contextExtensions">Optional contextual information extensions</param>
        /// <param name="resultExtensions">Optional result and outcome extensions</param>
        /// <param name="score">Optional scoring information</param>
        /// <param name="completion">Optional completion status</param>
        /// <param name="success">Success indicator for the activity</param>
        /// <param name="response">Optional learner response text</param>
        /// <param name="instructor">Optional instructor actor for educational context</param>
        /// <param name="team">Optional team actor for collaborative context</param>
        /// <returns>Complete TinCan Statement ready for LRS transmission</returns>
        public static Statement CreateStatement(
            string uri, 
            xAPI_Actor actor, 
            xAPI_Verb verb, 
            xAPI_Activity activity, 
            xAPI_Extensions_Activity activityExtensions = null,
            xAPI_Extensions_Context contextExtensions = null,
            xAPI_Extensions_Result resultExtensions = null,
            Score score = null,
            bool? completion = null,
            bool success = true,
            string response = null,
            xAPI_Actor? instructor = null,
            xAPI_Actor? team = null
        )
        {
            var s = new Statement
            {
                actor = CreateAgent(actor),                                                    // Individual actor
                verb = CreateVerb(uri, verb),                                                 // Action verb
                target = CreateActivity(uri, activity, activityExtensions),                  // Target activity
                context = CreateContext(uri, contextExtensions, instructor, team),           // Environmental context
                result = CreateResult(uri, score, completion, success, response, resultExtensions),
                //add timestamp to statement
                timestamp = Clock.Now,                                                   // Set current timestamp
                version = TCAPIVersion.latest()                                             // Use latest TinCan version
            };

            return s;
        }
        
        /// <summary>
        /// Creates a TinCan Group from an xAPI_Actor group with associated members for group-based statements.
        /// Assembles a TinCan Group object with group identification and a list of members
        /// extracted from xAPI_Actor array using CreateAgent conversion for consistent representation
        /// in xAPI statements involving group activities or contexts.
        /// </summary>
        /// <param name="group">xAPI_Actor representing the group's identity</param>
        /// <param name="members">Array of xAPI_Actors representing group members</param>
        /// <returns>TinCan Group object with resolved group members</returns>
        public static Group CreateGroup(xAPI_Actor group, IEnumerable<xAPI_Actor> members)
            => CreateGroup(group.Name, group.Email, members);
        
        /// <summary>
        /// Creates a TinCan Group with name, email, and associated member agents.
        /// Assembles a TinCan Group object with group identification based on name and email
        /// along with a list of member agents created from provided xAPI_Actor array for consistent
        /// and compliant representation in xAPI statements involving group activities.
        /// </summary>
        /// <param name="name">Name of the group</param>
        /// <param name="mail">Email address for the group</param>
        /// <param name="actors">Array of xAPI_Actors representing group members</param>
        /// <returns>TinCan Group object with resolved group members</returns>
        public static Group CreateGroup(string name, string mail, IEnumerable<xAPI_Actor> actors)
        {
            // Convert member actors to TinCan agents
            var members = actors.Select(a => CreateAgent(a.Name, a.Email));
            return new Group
            {
                name = name,
                mbox = "mailto:" + mail,
                member = members.ToList()
            };
        }
        
        /// <summary>
        /// Creates an xAPI Statement for group-based interactions by associating a group with an activity.
        /// Constructs a complete xAPI Statement with a TinCan Group as the actor, indicating
        /// that a group performed a certain action on a target activity, with context and result information.
        /// </summary>
        /// <param name="uri">Base URI for identifier resolution</param>
        /// <param name="group">xAPI_Actor representing the acting group</param>
        /// <param name="groupMembers">Array of xAPI_Actors representing group members</param>
        /// <param name="verb">Action verb performed by the group</param>
        /// <param name="activity">Target activity of the group's action</param>
        /// <param name="activityExtensions">Optional activity-specific extensions</param>
        /// <param name="contextExtensions">Optional contextual information extensions</param>
        /// <param name="resultExtensions">Optional result and outcome extensions</param>
        /// <param name="score">Optional scoring information</param>
        /// <param name="completion">Optional completion status</param>
        /// <param name="success">Success indicator for the activity</param>
        /// <param name="response">Optional learner response text</param>
        /// <param name="instructor">Optional instructor actor for educational context</param>
        /// <param name="team">Optional team actor for collaborative context</param>
        /// <returns>Complete xAPI Statement representing group-based action</returns>
        public static Statement CreateStatement(
            string uri, 
            xAPI_Actor group,
            xAPI_Actor[] groupMembers, 
            xAPI_Verb verb, 
            xAPI_Activity activity, 
            xAPI_Extensions_Activity activityExtensions = null,
            xAPI_Extensions_Context contextExtensions = null,
            xAPI_Extensions_Result resultExtensions = null,
            Score score = null,
            bool? completion = null,
            bool success = true,
            string response = null,
            xAPI_Actor? instructor = null,
            xAPI_Actor? team = null
        )
        {
            var s = new Statement
            {
                actor = CreateGroup(group, groupMembers),                                             // Group actor
                verb = CreateVerb(uri, verb),                                                         // Action verb
                target = CreateActivity(uri, activity, activityExtensions),                          // Target activity
                context = CreateContext(uri, contextExtensions, instructor, team),                   // Environmental context
                result = CreateResult(uri, score, completion, success, response, resultExtensions),   // Result information
                //add timestamp to statement
                timestamp = Clock.Now,                                                           // Set current timestamp
                version = TCAPIVersion.latest()                                                     // Use latest TinCan version
            };

            return s;
        }

        /// <summary>
        /// Creates a TinCan Context object with optional instructor, extensions, registration, and team information.
        /// Encapsulates contextual information related to an xAPI statement, including instructor,
        /// custom extensions, and team details to provide deeper understanding of the learning environment.
        /// </summary>
        /// <param name="uri">Base URI for identifier resolution</param>
        /// <param name="extensions">Optional context extensions for custom data</param>
        /// <param name="instructor">Optional instructor actor for educational context</param>
        /// <param name="team">Optional team actor for collaborative context</param>
        /// <returns>TinCan Context object with contextual information</returns>
        public static TinCan.Context CreateContext(string uri, xAPI_Extensions_Context extensions = null, xAPI_Actor? instructor = null, xAPI_Actor? team = null)
        {
            return new TinCan.Context()
            {
                instructor = instructor.HasValue ? CreateAgent(instructor.Value) : null,   // Instructor information
                extensions = extensions?.ToTinCanExtensions(uri),                         // Custom context extensions
                registration = null,                                                       // Learning activity registration
                team = team.HasValue ? CreateAgent(team.Value) : null,                     // Team information
            };
        }

        /// <summary>
        /// Creates a TinCan Result object with score, completion status, success status, extensions, and response.
        /// Encapsulates the outcome of an activity, including scoring details, completion state,
        /// success indication, custom extensions, and learner response data for thorough result representation.
        /// </summary>
        /// <param name="uri">Base URI for identifier resolution</param>
        /// <param name="score">Optional scoring information</param>
        /// <param name="completion">Optional completion status</param>
        /// <param name="success">Optional success status</param>
        /// <param name="response">Optional learner response text</param>
        /// <param name="extensions">Optional result extensions for custom data</param>
        /// <returns>TinCan Result object with activity outcome information</returns>
        public static Result CreateResult(string uri, Score score = null, bool? completion = null, bool? success = null, string response = null, xAPI_Extensions_Result extensions = null)
        {
            return new Result
            {
                score = score,                                      // Scoring details
                completion = completion,                             // Completion status
                success = success,                                    // Success status
                extensions = extensions?.ToTinCanExtensions(uri),   // Custom result extensions
                response = response                                   // Learner response text
            };
        }

        /// <summary>
        /// Creates an xAPI Statement with a simplified parameter set, separating extensions internally.
        /// Facilitates the creation of xAPI Statements by automatically categorizing extensions
        /// into activity, context, and result groups for organized statement assembly based on extension types.
        /// </summary>
        /// <param name="uri">Base URI for identifier resolution</param>
        /// <param name="actor">Actor performing the action</param>
        /// <param name="verb">Action being performed</param>
        /// <param name="activity">Target activity of the action</param>
        /// <param name="extensions">Mixed collection of xAPI extensions to categorize</param>
        /// <param name="score">Optional scoring information</param>
        /// <param name="completion">Completion status of the activity</param>
        /// <param name="success">Success indicator for the activity</param>
        /// <returns>Complete xAPI Statement with categorized extensions</returns>
        public static Statement CreateStatement(string uri, xAPI_Actor actor,
            xAPI_Verb verb, xAPI_Activity activity, xAPI_Extensions extensions = null,
            Score score = null, bool completion = true, bool success = true)
        {
            // Split mixed extensions into categorized collections
            var (activityExtensions, contextExtensions, resultExtensions) = SplitExtensions(extensions);
            return CreateStatement(uri, actor, verb, activity, activityExtensions, contextExtensions, resultExtensions,
                score, completion, success);
        }
    }
}
#endif