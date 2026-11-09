using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context gestures of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_Gestures : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_Gestures() 
            : base("gestures") {
        }

        /// <summary>
        /// The number of actors gestures. Has to be an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/extensions/result/numberOfGestures
        /// </summary>
        public xAPI_Extensions_Result_Gestures numberOfGestures(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberOfGestures",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number of gestures",
                        ["de-DE"] = "Gestenanzahl" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of actors gestures. Has to be an integer.",
                        ["de-DE"] = "Die Anzahl an Gesten, die die Akteurin tätigt. Muss ein Integer sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Setting, which hand is currently the primary hand.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/extensions/result/primaryHand
        /// </summary>
        public xAPI_Extensions_Result_Gestures primaryHand(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "primaryHand",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "primary hand",
                        ["de-DE"] = "Primärhand" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Setting, which hand is currently the primary hand.",
                        ["de-DE"] = "Einstellung, welche Hand die Primärhand ist." }),
                 value);
            return this;
        }
    }
}