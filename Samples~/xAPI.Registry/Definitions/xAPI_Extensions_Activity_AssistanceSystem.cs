using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context assistanceSystem of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_AssistanceSystem : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_AssistanceSystem() 
            : base("assistanceSystem") {
        }

        /// <summary>
        /// A condition, which, for example, checks if something was interacted with.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/activity/condition
        /// </summary>
        public xAPI_Extensions_Activity_AssistanceSystem condition(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "condition",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "condition",
                        ["de-DE"] = "Bedingung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A condition, which, for example, checks if something was interacted with.",
                        ["de-DE"] = "Eine Bedingung, die zum Beispiel überprüft ob mit etwas interagiert wurde." }),
                 value);
            return this;
        }

        /// <summary>
        /// A reaction, for example a sound notifying an person.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/activity/reaction
        /// </summary>
        public xAPI_Extensions_Activity_AssistanceSystem reaction(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "reaction",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "reaction",
                        ["de-DE"] = "Reaktion" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A reaction, for example a sound notifying an person.",
                        ["de-DE"] = "Eine Reaktion, die zum Beispiel eine Person benachrichtig." }),
                 value);
            return this;
        }
    }
}