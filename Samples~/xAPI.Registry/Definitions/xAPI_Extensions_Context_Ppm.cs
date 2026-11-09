using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context ppm of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_Ppm : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_Ppm() 
            : base("ppm") {
        }

        /// <summary>
        /// Heart rate as conditional information of a context. The value is an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/extensions/context/heartRate
        /// </summary>
        public xAPI_Extensions_Context_Ppm heartRate(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "heartRate",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "heart rate",
                        ["de-DE"] = "Herzfrequenz" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Heart rate as conditional information of a context. The value is an integer.",
                        ["de-DE"] = "Die Herzfrequenz als bedingte Information in einem Kontext. Der Wert ist eine Ganzzahl." }),
                 value);
            return this;
        }
    }
}