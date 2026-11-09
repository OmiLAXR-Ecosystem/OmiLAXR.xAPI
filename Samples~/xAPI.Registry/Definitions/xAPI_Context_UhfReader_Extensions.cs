
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context uhfReader as public properties.
    /// </summary>
    public sealed class xAPI_Context_UhfReader_Extensions {

        public xAPI_Context_UhfReader_Extensions() {
        }

        /// <summary>
        /// 5 extensions of 'uhfReader': 4 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_UhfReader context {
            get {
                return new xAPI_Extensions_Context_UhfReader();
            }
        }

        /// <summary>
        /// 5 extensions of 'uhfReader': 4 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_UhfReader result {
            get {
                return new xAPI_Extensions_Result_UhfReader();
            }
        }
    }
}