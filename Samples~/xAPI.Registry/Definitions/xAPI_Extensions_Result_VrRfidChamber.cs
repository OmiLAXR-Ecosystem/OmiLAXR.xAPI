using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context vrRfidChamber of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_VrRfidChamber : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_VrRfidChamber() 
            : base("vrRfidChamber") {
        }

        /// <summary>
        /// Value representing a length of time required to complete the experiment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/result/duration
        /// </summary>
        public xAPI_Extensions_Result_VrRfidChamber duration(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "duration",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "duration" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Value representing a length of time required to complete the experiment." }),
                 value);
            return this;
        }

        /// <summary>
        /// The time when the experiment was completed that is when the software was closed. This is captured from the system time of the local machine.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/result/endTime
        /// </summary>
        public xAPI_Extensions_Result_VrRfidChamber endTime(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "endTime",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "end time" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The time when the experiment was completed that is when the software was closed. This is captured from the system time of the local machine." }),
                 value);
            return this;
        }

        /// <summary>
        /// The experiment is a failure.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/result/failure
        /// </summary>
        public xAPI_Extensions_Result_VrRfidChamber failure(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "failure",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "failure" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The experiment is a failure." }),
                 value);
            return this;
        }

        /// <summary>
        /// The time when the experiment began. This is captured from the system time of the local machine.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/result/startTime
        /// </summary>
        public xAPI_Extensions_Result_VrRfidChamber startTime(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "startTime",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "start time" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The time when the experiment began. This is captured from the system time of the local machine." }),
                 value);
            return this;
        }

        /// <summary>
        /// Experiment is successful.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/result/success
        /// </summary>
        public xAPI_Extensions_Result_VrRfidChamber success(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "success",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "success" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Experiment is successful." }),
                 value);
            return this;
        }
    }
}