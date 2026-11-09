
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context rightsEngine as public properties.
    /// </summary>
    public class xAPI_Context_RightsEngine : xAPI_Context {
        /// <summary>
        /// 4 verbs of 'rightsEngine'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/verbs
        /// </summary>
        public readonly xAPI_Verbs_RightsEngine verbs = new xAPI_Verbs_RightsEngine();

        /// <summary>
        /// 7 activities of 'rightsEngine'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities
        /// </summary>
        public readonly xAPI_Activities_RightsEngine activities = new xAPI_Activities_RightsEngine();

        /// <summary>
        /// 0 extensions of 'rightsEngine': .
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/extensions
        /// </summary>
        public readonly xAPI_Context_RightsEngine_Extensions extensions = new xAPI_Context_RightsEngine_Extensions();

        public xAPI_Context_RightsEngine() 
            : base("rightsEngine") {
        }
    }
}