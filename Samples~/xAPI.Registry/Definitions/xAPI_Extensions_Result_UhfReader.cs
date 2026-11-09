using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context uhfReader of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_UhfReader : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_UhfReader() 
            : base("uhfReader") {
        }

        /// <summary>
        /// State of the transpnder to the physical reader.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/result/transponderState
        /// </summary>
        public xAPI_Extensions_Result_UhfReader transponderState(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "transponderState",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "transponderState" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "State of the transpnder to the physical reader." }),
                 value);
            return this;
        }
    }
}