using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 1 items of the xAPI_Activities of the context assistanceSystem as public properties.
    /// </summary>
    public sealed class xAPI_Activities_AssistanceSystem : xAPI_Activities {
        /// <summary>
        /// A hint, for example, giving information about a forgotten functionality.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/activities/hint
        /// </summary>
        public readonly xAPI_Activity hint = new xAPI_Activity(
            context: "assistanceSystem",
            key: "hint",
            names: new Dictionary<string, string> {
                ["en-US"] = "hint",
                ["de-DE"] = "Hinweis" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A hint, for example, giving information about a forgotten functionality.",
                ["de-DE"] = "Ein Hinweis, der zum Beispiel Informationen zu einer vergessenen Fuktionalität liefert" });

        public xAPI_Activities_AssistanceSystem() 
            : base("assistanceSystem") {
        }
    }
}