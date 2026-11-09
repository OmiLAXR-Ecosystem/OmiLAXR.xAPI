
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context gitanalysis as public properties.
    /// </summary>
    public sealed class xAPI_Context_Gitanalysis_Extensions {

        public xAPI_Context_Gitanalysis_Extensions() {
        }

        /// <summary>
        /// 28 extensions of 'gitanalysis': 17 in activity, 1 in context, 10 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis activity {
            get {
                return new xAPI_Extensions_Activity_Gitanalysis();
            }
        }

        /// <summary>
        /// 28 extensions of 'gitanalysis': 17 in activity, 1 in context, 10 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_Gitanalysis context {
            get {
                return new xAPI_Extensions_Context_Gitanalysis();
            }
        }

        /// <summary>
        /// 28 extensions of 'gitanalysis': 17 in activity, 1 in context, 10 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis result {
            get {
                return new xAPI_Extensions_Result_Gitanalysis();
            }
        }
    }
}