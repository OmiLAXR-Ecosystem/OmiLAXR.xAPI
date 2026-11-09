
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context projectJupyter as public properties.
    /// </summary>
    public sealed class xAPI_Context_ProjectJupyter_Extensions {

        public xAPI_Context_ProjectJupyter_Extensions() {
        }

        /// <summary>
        /// 6 extensions of 'projectJupyter': 3 in activity, 1 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_ProjectJupyter activity {
            get {
                return new xAPI_Extensions_Activity_ProjectJupyter();
            }
        }

        /// <summary>
        /// 6 extensions of 'projectJupyter': 3 in activity, 1 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_ProjectJupyter context {
            get {
                return new xAPI_Extensions_Context_ProjectJupyter();
            }
        }

        /// <summary>
        /// 6 extensions of 'projectJupyter': 3 in activity, 1 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_ProjectJupyter result {
            get {
                return new xAPI_Extensions_Result_ProjectJupyter();
            }
        }
    }
}