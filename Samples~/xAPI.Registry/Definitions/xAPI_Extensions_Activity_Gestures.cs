using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context gestures of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_Gestures : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_Gestures() 
            : base("gestures") {
        }

        /// <summary>
        /// Hand which is currently active.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/extensions/activity/hand
        /// </summary>
        public xAPI_Extensions_Activity_Gestures hand(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "hand",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "hand",
                        ["de-DE"] = "Hand" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Hand which is currently active.",
                        ["de-DE"] = "Die Hand, die gerade verwendet wird." }),
                 value);
            return this;
        }
    }
}