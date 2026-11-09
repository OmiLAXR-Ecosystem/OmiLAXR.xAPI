
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context generic as public properties.
    /// </summary>
    public sealed class xAPI_Context_Generic_Extensions {

        public xAPI_Context_Generic_Extensions() {
        }

        /// <summary>
        /// 20 extensions of 'generic': 8 in activity, 5 in context, 7 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_Generic activity {
            get {
                return new xAPI_Extensions_Activity_Generic();
            }
        }

        /// <summary>
        /// 20 extensions of 'generic': 8 in activity, 5 in context, 7 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_Generic context {
            get {
                return new xAPI_Extensions_Context_Generic();
            }
        }

        /// <summary>
        /// 20 extensions of 'generic': 8 in activity, 5 in context, 7 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_Generic result {
            get {
                return new xAPI_Extensions_Result_Generic();
            }
        }
    }
}