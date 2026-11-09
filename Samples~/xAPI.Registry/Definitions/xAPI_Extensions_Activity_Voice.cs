using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context voice of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_Voice : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_Voice() 
            : base("voice") {
        }

        /// <summary>
        /// It is the name of an action, which could be triggert, e.g. by using a verbal keyword.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/extensions/activity/actionName
        /// </summary>
        public xAPI_Extensions_Activity_Voice actionName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "actionName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "action name",
                        ["de-DE"] = "Aktionsname" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "It is the name of an action, which could be triggert, e.g. by using a verbal keyword.",
                        ["de-DE"] = "Es ist der Name einer Aktion, die zum Beispiel durch ein verbales Schlüsselwort ausgelöst werden kann." }),
                 value);
            return this;
        }

        /// <summary>
        /// Speaking time of a person. Time span in which the actor spoke (in seconds).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/extensions/activity/duration
        /// </summary>
        public xAPI_Extensions_Activity_Voice duration(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "duration",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "duration",
                        ["de-DE"] = "Sprechzeit" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Speaking time of a person. Time span in which the actor spoke (in seconds).",
                        ["de-DE"] = "Zeitspanne in der die Akteurin gesprochen hat (in Sekunden)." }),
                 value);
            return this;
        }

        /// <summary>
        /// Name of a VR object. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/extensions/activity/vrObjectName
        /// </summary>
        public xAPI_Extensions_Activity_Voice vrObjectName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "vrObjectName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR object name",
                        ["de-DE"] = "VR Objekt Name" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of a VR object. Must be a string.",
                        ["de-DE"] = "Namen vom VR Objekt. Muss ein String sein." }),
                 value);
            return this;
        }
    }
}