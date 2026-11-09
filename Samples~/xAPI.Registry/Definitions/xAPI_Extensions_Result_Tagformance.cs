using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context tagformance of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_Tagformance : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_Tagformance() 
            : base("tagformance") {
        }

        /// <summary>
        /// The time taken to complete the experiment. This is captured from the system time of the local machine.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/result/duration
        /// </summary>
        public xAPI_Extensions_Result_Tagformance duration(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "duration",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "duration" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The time taken to complete the experiment. This is captured from the system time of the local machine." }),
                 value);
            return this;
        }

        /// <summary>
        /// Boolean value which is true when something is empty.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/result/empty
        /// </summary>
        public xAPI_Extensions_Result_Tagformance empty(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "empty",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "empty" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Boolean value which is true when something is empty." }),
                 value);
            return this;
        }
    }
}