
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context assistanceSystem as public properties.
    /// </summary>
    public class xAPI_Context_AssistanceSystem : xAPI_Context {
        /// <summary>
        /// 2 verbs of 'assistanceSystem'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/verbs
        /// </summary>
        public readonly xAPI_Verbs_AssistanceSystem verbs = new xAPI_Verbs_AssistanceSystem();

        /// <summary>
        /// 1 activities of 'assistanceSystem'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/activities
        /// </summary>
        public readonly xAPI_Activities_AssistanceSystem activities = new xAPI_Activities_AssistanceSystem();

        /// <summary>
        /// 8 extensions of 'assistanceSystem': 2 in activity, 2 in context, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions
        /// </summary>
        public readonly xAPI_Context_AssistanceSystem_Extensions extensions = new xAPI_Context_AssistanceSystem_Extensions();

        public xAPI_Context_AssistanceSystem() 
            : base("assistanceSystem") {
        }
    }
}