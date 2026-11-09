using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context assistanceSystem of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_AssistanceSystem : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_AssistanceSystem() 
            : base("assistanceSystem") {
        }

        /// <summary>
        /// The time where an event actually happened.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/result/actualTime
        /// </summary>
        public xAPI_Extensions_Result_AssistanceSystem actualTime(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "actualTime",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "actual time",
                        ["de-DE"] = "tatsächliche Zeit" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The time where an event actually happened.",
                        ["de-DE"] = "Die Zeit, zu der ein Ereignis tatsächlich stattfand." }),
                 value);
            return this;
        }

        /// <summary>
        /// The difference between two objects, behaviors or persons.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/result/difference
        /// </summary>
        public xAPI_Extensions_Result_AssistanceSystem difference(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "difference",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "difference",
                        ["de-DE"] = "Unterschied" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The difference between two objects, behaviors or persons.",
                        ["de-DE"] = "Der Unterschied zwischen Objekten, Verhaltensweisen oder Personen." }),
                 value);
            return this;
        }

        /// <summary>
        /// The planned time for an event to happen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/result/plannedTime
        /// </summary>
        public xAPI_Extensions_Result_AssistanceSystem plannedTime(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "plannedTime",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "planned time",
                        ["de-DE"] = "geplante Zeit" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The planned time for an event to happen.",
                        ["de-DE"] = "Die geplante Zeit, zu der ein Ereignis stattfinden soll." }),
                 value);
            return this;
        }

        /// <summary>
        /// A predetermined limit that triggers a specified action or event, when reached or exceeded.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/result/threshold
        /// </summary>
        public xAPI_Extensions_Result_AssistanceSystem threshold(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "threshold",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "threshold",
                        ["de-DE"] = "Schwelle" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A predetermined limit that triggers a specified action or event, when reached or exceeded.",
                        ["de-DE"] = "Eine vorbestimmte Schwelle, die bei Erreichen oder Überschreiten eine bestimmte Aktion oder ein bestimmtes Ereignis auslöst." }),
                 value);
            return this;
        }
    }
}