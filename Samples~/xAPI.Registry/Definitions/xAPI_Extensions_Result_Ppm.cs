using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context ppm of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_Ppm : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_Ppm() 
            : base("ppm") {
        }

        /// <summary>
        /// Heart rate is the number of times the heart beats per minute, indicating the frequency of heart contractions. The value is an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/extensions/result/heartRate
        /// </summary>
        public xAPI_Extensions_Result_Ppm heartRate(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "heartRate",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "heart rate",
                        ["de-DE"] = "Herzfrequenz" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Heart rate is the number of times the heart beats per minute, indicating the frequency of heart contractions. The value is an integer.",
                        ["de-DE"] = "Die Herzfrequenz ist die Anzahl der Herzschläge pro Minute und gibt die Häufigkeit der Herzkontraktionen an. Der Wert ist eine Ganzzahl." }),
                 value);
            return this;
        }
    }
}