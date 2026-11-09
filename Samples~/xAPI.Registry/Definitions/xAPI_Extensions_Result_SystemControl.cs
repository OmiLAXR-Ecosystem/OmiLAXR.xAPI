using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context systemControl of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_SystemControl : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_SystemControl() 
            : base("systemControl") {
        }

        /// <summary>
        /// Language of the system.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/result/language
        /// </summary>
        public xAPI_Extensions_Result_SystemControl language(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "language",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "language",
                        ["de-DE"] = "Sprache" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Language of the system.",
                        ["de-DE"] = "Sprache des Systems." }),
                 value);
            return this;
        }
    }
}