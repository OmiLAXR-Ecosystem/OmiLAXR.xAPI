using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context uhfReader of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_UhfReader : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_UhfReader() 
            : base("uhfReader") {
        }

        /// <summary>
        /// Name of an UI element action, which the user interacted with. For example the read value checkbox has the name 'readValue'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/context/actionName
        /// </summary>
        public xAPI_Extensions_Context_UhfReader actionName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "actionName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "action name" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of an UI element action, which the user interacted with. For example the read value checkbox has the name 'readValue'." }),
                 value);
            return this;
        }

        /// <summary>
        /// An evaluation can have a type. For example a transponder can be evaluated externally using google by copying the id and pasting it externally.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/context/evaluationType
        /// </summary>
        public xAPI_Extensions_Context_UhfReader evaluationType(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "evaluationType",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "evaluation type" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An evaluation can have a type. For example a transponder can be evaluated externally using google by copying the id and pasting it externally." }),
                 value);
            return this;
        }

        /// <summary>
        /// The selected element to read for the transponder.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/context/readTid
        /// </summary>
        public xAPI_Extensions_Context_UhfReader readTid(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "readTid",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "read Tid" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The selected element to read for the transponder." }),
                 value);
            return this;
        }

        /// <summary>
        /// The head that is selected to read the TID.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/context/readingHead
        /// </summary>
        public xAPI_Extensions_Context_UhfReader readingHead(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "readingHead",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "reading head" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The head that is selected to read the TID." }),
                 value);
            return this;
        }
    }
}