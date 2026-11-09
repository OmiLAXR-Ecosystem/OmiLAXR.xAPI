
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context studybuddy as public properties.
    /// </summary>
    public class xAPI_Context_Studybuddy : xAPI_Context {
        /// <summary>
        /// 8 verbs of 'studybuddy'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/verbs
        /// </summary>
        public readonly xAPI_Verbs_Studybuddy verbs = new xAPI_Verbs_Studybuddy();

        /// <summary>
        /// 7 activities of 'studybuddy'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities
        /// </summary>
        public readonly xAPI_Activities_Studybuddy activities = new xAPI_Activities_Studybuddy();

        /// <summary>
        /// 0 extensions of 'studybuddy': .
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/extensions
        /// </summary>
        public readonly xAPI_Context_Studybuddy_Extensions extensions = new xAPI_Context_Studybuddy_Extensions();

        public xAPI_Context_Studybuddy() 
            : base("studybuddy") {
        }
    }
}