
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context systemControl as public properties.
    /// </summary>
    public sealed class xAPI_Context_SystemControl_Extensions {

        public xAPI_Context_SystemControl_Extensions() {
        }

        /// <summary>
        /// 5 extensions of 'systemControl': 3 in activity, 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_SystemControl activity {
            get {
                return new xAPI_Extensions_Activity_SystemControl();
            }
        }

        /// <summary>
        /// 5 extensions of 'systemControl': 3 in activity, 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_SystemControl context {
            get {
                return new xAPI_Extensions_Context_SystemControl();
            }
        }

        /// <summary>
        /// 5 extensions of 'systemControl': 3 in activity, 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_SystemControl result {
            get {
                return new xAPI_Extensions_Result_SystemControl();
            }
        }
    }
}