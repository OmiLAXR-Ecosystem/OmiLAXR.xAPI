
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context tagformance as public properties.
    /// </summary>
    public sealed class xAPI_Context_Tagformance_Extensions {

        public xAPI_Context_Tagformance_Extensions() {
        }

        /// <summary>
        /// 17 extensions of 'tagformance': 4 in activity, 11 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_Tagformance activity {
            get {
                return new xAPI_Extensions_Activity_Tagformance();
            }
        }

        /// <summary>
        /// 17 extensions of 'tagformance': 4 in activity, 11 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_Tagformance context {
            get {
                return new xAPI_Extensions_Context_Tagformance();
            }
        }

        /// <summary>
        /// 17 extensions of 'tagformance': 4 in activity, 11 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_Tagformance result {
            get {
                return new xAPI_Extensions_Result_Tagformance();
            }
        }
    }
}