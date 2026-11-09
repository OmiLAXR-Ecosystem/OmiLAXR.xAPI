
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context systemControl as public properties.
    /// </summary>
    public class xAPI_Context_SystemControl : xAPI_Context {
        /// <summary>
        /// 12 verbs of 'systemControl'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs
        /// </summary>
        public readonly xAPI_Verbs_SystemControl verbs = new xAPI_Verbs_SystemControl();

        /// <summary>
        /// 5 activities of 'systemControl'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/activities
        /// </summary>
        public readonly xAPI_Activities_SystemControl activities = new xAPI_Activities_SystemControl();

        /// <summary>
        /// 5 extensions of 'systemControl': 3 in activity, 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions
        /// </summary>
        public readonly xAPI_Context_SystemControl_Extensions extensions = new xAPI_Context_SystemControl_Extensions();

        public xAPI_Context_SystemControl() 
            : base("systemControl") {
        }
    }
}