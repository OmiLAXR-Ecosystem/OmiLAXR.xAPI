using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context systemControl of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_SystemControl : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_SystemControl() 
            : base("systemControl") {
        }

        /// <summary>
        /// Represents the content of an instruction provided by the system.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/activity/instructionContent
        /// </summary>
        public xAPI_Extensions_Activity_SystemControl instructionContent(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "instructionContent",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "instruction content",
                        ["de-DE"] = "Inhalt der Anweisung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Represents the content of an instruction provided by the system.",
                        ["de-DE"] = "Repräsentiert den Inhalt einer Anweisung, die vom System erteilt wird." }),
                 value);
            return this;
        }

        /// <summary>
        /// Represents the type of an instruction provided by the system. It can be e.g. a text, or audio.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/activity/instructionType
        /// </summary>
        public xAPI_Extensions_Activity_SystemControl instructionType(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "instructionType",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "instruction type",
                        ["de-DE"] = "Typ der Anweisung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Represents the type of an instruction provided by the system. It can be e.g. a text, or audio.",
                        ["de-DE"] = "Repräsentiert den Inhalt einer Anweisung, die vom System erteilt wird. Es kann zum Beispiel Text oder Audio sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Name of a system control activity. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/activity/name
        /// </summary>
        public xAPI_Extensions_Activity_SystemControl name(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "name",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "System control activity name",
                        ["de-DE"] = "System Control Activity Name" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of a system control activity. Must be a string.",
                        ["de-DE"] = "Namen von einer Aktivität von des Systemkontrollers. Muss ein String sein." }),
                 value);
            return this;
        }
    }
}