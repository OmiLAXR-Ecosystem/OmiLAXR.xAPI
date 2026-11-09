using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context vrRfidChamber of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_VrRfidChamber : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_VrRfidChamber() 
            : base("vrRfidChamber") {
        }

        /// <summary>
        /// In this case the energy of RFID tag is measured.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/context/energymeasure
        /// </summary>
        public xAPI_Extensions_Context_VrRfidChamber energymeasure(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "energymeasure",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "energymeasure" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "In this case the energy of RFID tag is measured." }),
                 value);
            return this;
        }

        /// <summary>
        /// The experimentmode in which the experiment is carried. Can be energy measurement or reading range measurement
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/context/experimentmode
        /// </summary>
        public xAPI_Extensions_Context_VrRfidChamber experimentmode(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "experimentmode",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "experimentmode" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The experimentmode in which the experiment is carried. Can be energy measurement or reading range measurement" }),
                 value);
            return this;
        }

        /// <summary>
        /// In this case the best possible orientation of the RFID tag is measured.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/context/orientationmeasure
        /// </summary>
        public xAPI_Extensions_Context_VrRfidChamber orientationmeasure(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "orientationmeasure",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "orientationmeasure" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "In this case the best possible orientation of the RFID tag is measured." }),
                 value);
            return this;
        }

        /// <summary>
        /// In this case the reading range of transponder is measured.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/context/readingrangemeasure
        /// </summary>
        public xAPI_Extensions_Context_VrRfidChamber readingrangemeasure(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "readingrangemeasure",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "readingrangemeasure" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "In this case the reading range of transponder is measured." }),
                 value);
            return this;
        }

        /// <summary>
        /// A session is one execution of the lab from entering the lab to exiting it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions/context/session
        /// </summary>
        public xAPI_Extensions_Context_VrRfidChamber session(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "session",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "session" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A session is one execution of the lab from entering the lab to exiting it." }),
                 value);
            return this;
        }
    }
}