using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 2 items of the xAPI_Verbs of the context assistanceSystem as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_AssistanceSystem : xAPI_Verbs {
        /// <summary>
        /// Indicates that the actor did not need something. For instance, a person did not need help.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/verbs/notNeeded
        /// </summary>
        public readonly xAPI_Verb notNeeded = new xAPI_Verb(
            context: "assistanceSystem",
            key: "notNeeded",
            names: new Dictionary<string, string> {
                ["en-US"] = "not needed",
                ["de-DE"] = "nicht benötigt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Indicates that the actor did not need something. For instance, a person did not need help.",
                ["de-DE"] = "Signalisiert, dass ein Agierendem etwas nicht benötigt hat. Zum Beispiel: Eine Person hat eine Hilfe nicht benötigt." });

        /// <summary>
        /// Indicates that the actor was given something. For instance, a person can be given a letter
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/verbs/wasGiven
        /// </summary>
        public readonly xAPI_Verb wasGiven = new xAPI_Verb(
            context: "assistanceSystem",
            key: "wasGiven",
            names: new Dictionary<string, string> {
                ["en-US"] = "was given",
                ["de-DE"] = "wurde gegeben" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Indicates that the actor was given something. For instance, a person can be given a letter",
                ["de-DE"] = "Signalisiert, dass einem Agierendem etwas gegeben wurde. Zum Beispiel: Einer Person wurde ein Brief gegeben." });

        public xAPI_Verbs_AssistanceSystem() 
            : base("assistanceSystem") {
        }
    }
}