using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context generic of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_Generic : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_Generic() 
            : base("generic") {
        }

        /// <summary>
        /// A unique identifier for the device used, such as a serial number or MAC address.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/deviceId
        /// </summary>
        public xAPI_Extensions_Result_Generic deviceId(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "deviceId",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "device ID",
                        ["de-DE"] = "Geräte-ID" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A unique identifier for the device used, such as a serial number or MAC address.",
                        ["de-DE"] = "Eine eindeutige Kennung für das Gerät, das verwendet wurde, wie eine Seriennummer oder MAC-Adresse." }),
                 value);
            return this;
        }

        /// <summary>
        /// The name of the device that is used, such as 'Oculus Quest 2' or 'iPad Pro'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/deviceName
        /// </summary>
        public xAPI_Extensions_Result_Generic deviceName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "deviceName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "device name",
                        ["de-DE"] = "Gerätename" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The name of the device that is used, such as 'Oculus Quest 2' or 'iPad Pro'.",
                        ["de-DE"] = "Der Name des Geräts, das verwendet wurde, z. B. 'Oculus Quest 2' oder 'iPad Pro'." }),
                 value);
            return this;
        }

        /// <summary>
        /// Representation of a object directly after the statement occurred. 'End Value' should be used with the 'Start Value' extension to provide information about the actual change of the object. Can be used with 'edited' or 'changed' verbs.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/endValue
        /// </summary>
        public xAPI_Extensions_Result_Generic endValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "endValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "End Value",
                        ["de-DE"] = "Endwert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Representation of a object directly after the statement occurred. 'End Value' should be used with the 'Start Value' extension to provide information about the actual change of the object. Can be used with 'edited' or 'changed' verbs.",
                        ["de-DE"] = "Repräsentation von einem Objekt direkt nachdem das Statement auftrat. 'Endwert' sollte mit der Extension 'Startwert' benutzt werden um Information über die Änderung eines Objektes darzulegen. Kann zum Beispiel mit den Verben 'editierte' und 'veränderte' benutzt werden." }),
                 value);
            return this;
        }

        /// <summary>
        /// A number to index something. Can only be an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/index
        /// </summary>
        public xAPI_Extensions_Result_Generic index(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "index",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "index",
                        ["de-DE"] = "Index" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A number to index something. Can only be an integer.",
                        ["de-DE"] = "Eine Zahl zur Indexierung von etwas. Muss ganzzahlig sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Representation of a object directly before the statement occurred. 'Start Value' should be used with the 'End Value' extension to provide information about the actual change of the object. Can be used with 'edited' or 'changed' verbs.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/startValue
        /// </summary>
        public xAPI_Extensions_Result_Generic startValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "startValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Start Value",
                        ["de-DE"] = "Startwert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Representation of a object directly before the statement occurred. 'Start Value' should be used with the 'End Value' extension to provide information about the actual change of the object. Can be used with 'edited' or 'changed' verbs.",
                        ["de-DE"] = "Repräsentation von einem Objekt bevor das Statement auftrat. 'Startwert' sollte mit der Extension 'Endwert' benutzt werden um Information über die Änderung eines Objektes darzulegen. Kann zum Beispiel mit den Verben 'editierte' und 'veränderte' benutzt werden." }),
                 value);
            return this;
        }

        /// <summary>
        /// A time span depending on context.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/timeSpan
        /// </summary>
        public xAPI_Extensions_Result_Generic timeSpan(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "timeSpan",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Time Span",
                        ["de-DE"] = "Zeitspanne" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A time span depending on context.",
                        ["de-DE"] = "Eine bestimmte Zeitspanne abhängig vom Kontext." }),
                 value);
            return this;
        }

        /// <summary>
        /// The value of an element.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result/value
        /// </summary>
        public xAPI_Extensions_Result_Generic value(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "value",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "value",
                        ["de-DE"] = "Wert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The value of an element.",
                        ["de-DE"] = "Der Wert eines Elements." }),
                 value);
            return this;
        }
    }
}