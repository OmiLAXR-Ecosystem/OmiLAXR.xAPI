
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context assistanceSystem as public properties.
    /// </summary>
    public sealed class xAPI_Context_AssistanceSystem_Extensions {

        public xAPI_Context_AssistanceSystem_Extensions() {
        }

        /// <summary>
        /// 8 extensions of 'assistanceSystem': 2 in activity, 2 in context, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_AssistanceSystem activity {
            get {
                return new xAPI_Extensions_Activity_AssistanceSystem();
            }
        }

        /// <summary>
        /// 8 extensions of 'assistanceSystem': 2 in activity, 2 in context, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_AssistanceSystem context {
            get {
                return new xAPI_Extensions_Context_AssistanceSystem();
            }
        }

        /// <summary>
        /// 8 extensions of 'assistanceSystem': 2 in activity, 2 in context, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_AssistanceSystem result {
            get {
                return new xAPI_Extensions_Result_AssistanceSystem();
            }
        }
    }
}