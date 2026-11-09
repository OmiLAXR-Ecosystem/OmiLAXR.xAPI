using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context tagformance of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_Tagformance : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_Tagformance() 
            : base("tagformance") {
        }

        /// <summary>
        /// Energy Measure is an experiment mode as per the lab instruction.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/energyMeasure
        /// </summary>
        public xAPI_Extensions_Context_Tagformance energyMeasure(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "energyMeasure",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "energy measure" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Energy Measure is an experiment mode as per the lab instruction." }),
                 value);
            return this;
        }

        /// <summary>
        /// An actor selects a frequency step for the measurement of the graph.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/frequencyStep
        /// </summary>
        public xAPI_Extensions_Context_Tagformance frequencyStep(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "frequencyStep",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "frequency step" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An actor selects a frequency step for the measurement of the graph." }),
                 value);
            return this;
        }

        /// <summary>
        /// An actor selects a unit in the Y-axis of the graph that is measured.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/measurementUnit
        /// </summary>
        public xAPI_Extensions_Context_Tagformance measurementUnit(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "measurementUnit",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "measurement unit dropdown" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An actor selects a unit in the Y-axis of the graph that is measured." }),
                 value);
            return this;
        }

        /// <summary>
        /// This is an experiment mode as per lab instruction.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/orientationMeasure
        /// </summary>
        public xAPI_Extensions_Context_Tagformance orientationMeasure(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "orientationMeasure",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "orientation measure" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "This is an experiment mode as per lab instruction." }),
                 value);
            return this;
        }

        /// <summary>
        /// The power step selected for the measurement.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/powerStep
        /// </summary>
        public xAPI_Extensions_Context_Tagformance powerStep(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "powerStep",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "power step" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The power step selected for the measurement." }),
                 value);
            return this;
        }

        /// <summary>
        /// The protocol used is ISO 18000-6c Query.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/protocol
        /// </summary>
        public xAPI_Extensions_Context_Tagformance protocol(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "protocol",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "protocol" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The protocol used is ISO 18000-6c Query." }),
                 value);
            return this;
        }

        /// <summary>
        /// The RFID tag selected for measurement.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/selectTag
        /// </summary>
        public xAPI_Extensions_Context_Tagformance selectTag(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "selectTag",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "select tag dropdown" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The RFID tag selected for measurement." }),
                 value);
            return this;
        }

        /// <summary>
        /// The selected frequency to start the measurement.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/startFrequency
        /// </summary>
        public xAPI_Extensions_Context_Tagformance startFrequency(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "startFrequency",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "start frequency" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The selected frequency to start the measurement." }),
                 value);
            return this;
        }

        /// <summary>
        /// The selected frequency to stop the measurement.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/stopFrequency
        /// </summary>
        public xAPI_Extensions_Context_Tagformance stopFrequency(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "stopFrequency",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "stop frequency" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The selected frequency to stop the measurement." }),
                 value);
            return this;
        }

        /// <summary>
        /// The Y-axis unit in the graph for measuring the reading range of transponder.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/theoreticalReadingRange
        /// </summary>
        public xAPI_Extensions_Context_Tagformance theoreticalReadingRange(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "theoreticalReadingRange",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "theoretical reading range" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The Y-axis unit in the graph for measuring the reading range of transponder." }),
                 value);
            return this;
        }

        /// <summary>
        /// The Y-axis unit in dBm for measurement.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context/transmittedPower
        /// </summary>
        public xAPI_Extensions_Context_Tagformance transmittedPower(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "transmittedPower",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "transmitted power" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The Y-axis unit in dBm for measurement." }),
                 value);
            return this;
        }
    }
}