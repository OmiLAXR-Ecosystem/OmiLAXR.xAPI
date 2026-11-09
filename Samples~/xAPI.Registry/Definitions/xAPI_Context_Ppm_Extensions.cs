
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context ppm as public properties.
    /// </summary>
    public sealed class xAPI_Context_Ppm_Extensions {

        public xAPI_Context_Ppm_Extensions() {
        }

        /// <summary>
        /// 2 extensions of 'ppm': 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_Ppm context {
            get {
                return new xAPI_Extensions_Context_Ppm();
            }
        }

        /// <summary>
        /// 2 extensions of 'ppm': 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_Ppm result {
            get {
                return new xAPI_Extensions_Result_Ppm();
            }
        }
    }
}