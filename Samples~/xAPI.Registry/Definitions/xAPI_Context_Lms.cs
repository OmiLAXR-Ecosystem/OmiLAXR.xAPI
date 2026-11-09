
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context lms as public properties.
    /// </summary>
    public class xAPI_Context_Lms : xAPI_Context {
        /// <summary>
        /// 47 verbs of 'lms'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs
        /// </summary>
        public readonly xAPI_Verbs_Lms verbs = new xAPI_Verbs_Lms();

        /// <summary>
        /// 35 activities of 'lms'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities
        /// </summary>
        public readonly xAPI_Activities_Lms activities = new xAPI_Activities_Lms();

        /// <summary>
        /// 0 extensions of 'lms': .
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/extensions
        /// </summary>
        public readonly xAPI_Context_Lms_Extensions extensions = new xAPI_Context_Lms_Extensions();

        public xAPI_Context_Lms() 
            : base("lms") {
        }
    }
}