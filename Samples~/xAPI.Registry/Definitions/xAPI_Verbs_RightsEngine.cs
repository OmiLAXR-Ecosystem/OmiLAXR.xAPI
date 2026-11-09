using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 4 items of the xAPI_Verbs of the context rightsEngine as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_RightsEngine : xAPI_Verbs {
        /// <summary>
        /// Actor accessed/viewed a schema, his or her consent, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/verbs/accessed
        /// </summary>
        public readonly xAPI_Verb accessed = new xAPI_Verb(
            context: "rightsEngine",
            key: "accessed",
            names: new Dictionary<string, string> {
                ["en-US"] = "accessed",
                ["de-DE"] = "zugegriffen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor accessed/viewed a schema, his or her consent, ...",
                ["de-DE"] = "Akteur hat (auf) ein Schema, die eigenen Zustimmungen, ... zugegriffen/angesehen." });

        /// <summary>
        /// Actor paused the data collection for the related provider context, but the consent settings will be kept. Data collection can be resumed by resuming the the provider context.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/verbs/paused
        /// </summary>
        public readonly xAPI_Verb paused = new xAPI_Verb(
            context: "rightsEngine",
            key: "paused",
            names: new Dictionary<string, string> {
                ["en-US"] = "paused",
                ["de-DE"] = "pausierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor paused the data collection for the related provider context, but the consent settings will be kept. Data collection can be resumed by resuming the the provider context.",
                ["de-DE"] = "Akteur pausierte die Datensammlung für einen Provider-Kontext, die Zustimmungen bleiben aber erhalten. Die Datensammlung kann fortgesetzt werden, wenn der der Provider-Kontext wieder fortgesetzt wird." });

        /// <summary>
        /// Actor resumed a previously paused provider context. Consequently, the data collection is resumed with the preserved consent settings.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/verbs/resumed
        /// </summary>
        public readonly xAPI_Verb resumed = new xAPI_Verb(
            context: "rightsEngine",
            key: "resumed",
            names: new Dictionary<string, string> {
                ["en-US"] = "resumed",
                ["de-DE"] = "setzte fort" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor resumed a previously paused provider context. Consequently, the data collection is resumed with the preserved consent settings.",
                ["de-DE"] = "Akteur setzte einen zuvor pausierten Provider-Kontext fort. In Folge ist die Datensammlung für das Schema mit den beibehaltenen Zustimmungseinstellungen wiederaufgenommen." });

        /// <summary>
        /// Actor updated his or her consent for a schema or a schema itself.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/verbs/updated
        /// </summary>
        public readonly xAPI_Verb updated = new xAPI_Verb(
            context: "rightsEngine",
            key: "updated",
            names: new Dictionary<string, string> {
                ["en-US"] = "updated",
                ["de-DE"] = "aktualisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor updated his or her consent for a schema or a schema itself.",
                ["de-DE"] = "Akteur aktualisierte die eigenen Zustimmungen für ein Schema oder ein Schema selbst." });

        public xAPI_Verbs_RightsEngine() 
            : base("rightsEngine") {
        }
    }
}