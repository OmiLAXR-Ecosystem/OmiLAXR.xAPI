using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 8 items of the xAPI_Verbs of the context studybuddy as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Studybuddy : xAPI_Verbs {
        /// <summary>
        /// Actor clicked a link, button, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "studybuddy",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked",
                ["de-DE"] = "klickte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor clicked a link, button, ...",
                ["de-DE"] = "Akteur klickte auf/an einen Link, Button, ..." });

        /// <summary>
        /// Actor created an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/created
        /// </summary>
        public readonly xAPI_Verb created = new xAPI_Verb(
            context: "studybuddy",
            key: "created",
            names: new Dictionary<string, string> {
                ["en-US"] = "created",
                ["de-DE"] = "erstellte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor created an object",
                ["de-DE"] = "Akteur hat ein Objekt erstellt/angelegt" });

        /// <summary>
        /// Actor deleted an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/deleted
        /// </summary>
        public readonly xAPI_Verb deleted = new xAPI_Verb(
            context: "studybuddy",
            key: "deleted",
            names: new Dictionary<string, string> {
                ["en-US"] = "deleted",
                ["de-DE"] = "löschte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor deleted an object",
                ["de-DE"] = "Akteur hat ein Objekt gelöscht" });

        /// <summary>
        /// Actor logged in to a system
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/loggedInTo
        /// </summary>
        public readonly xAPI_Verb loggedInTo = new xAPI_Verb(
            context: "studybuddy",
            key: "loggedInTo",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged in to",
                ["de-DE"] = "meldete sich an in" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor logged in to a system",
                ["de-DE"] = "Akteur hat sich in einem System angemeldet" });

        /// <summary>
        /// Actor logged out from a system
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/loggedOutFrom
        /// </summary>
        public readonly xAPI_Verb loggedOutFrom = new xAPI_Verb(
            context: "studybuddy",
            key: "loggedOutFrom",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged out from",
                ["de-DE"] = "meldete sich ab von" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor logged out from a system",
                ["de-DE"] = "Akteur hat sich von einem System abgemeldet" });

        /// <summary>
        /// Actor paused an activity
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/paused
        /// </summary>
        public readonly xAPI_Verb paused = new xAPI_Verb(
            context: "studybuddy",
            key: "paused",
            names: new Dictionary<string, string> {
                ["en-US"] = "paused",
                ["de-DE"] = "pausierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor paused an activity",
                ["de-DE"] = "Akteur pausierte eine Aktivität" });

        /// <summary>
        /// Actor triggered a process
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/triggered
        /// </summary>
        public readonly xAPI_Verb triggered = new xAPI_Verb(
            context: "studybuddy",
            key: "triggered",
            names: new Dictionary<string, string> {
                ["en-US"] = "triggered",
                ["de-DE"] = "löste aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor triggered a process",
                ["de-DE"] = "Akteur hat einen Prozess ausgelöst" });

        /// <summary>
        /// Actor updated an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs/updated
        /// </summary>
        public readonly xAPI_Verb updated = new xAPI_Verb(
            context: "studybuddy",
            key: "updated",
            names: new Dictionary<string, string> {
                ["en-US"] = "updated",
                ["de-DE"] = "aktualisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor updated an object",
                ["de-DE"] = "Akteur hat ein Objekt aktualisiert" });

        public xAPI_Verbs_Studybuddy() 
            : base("studybuddy") {
        }
    }
}