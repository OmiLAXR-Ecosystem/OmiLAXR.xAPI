
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context projectJupyter as public properties.
    /// </summary>
    public class xAPI_Context_ProjectJupyter : xAPI_Context {
        /// <summary>
        /// 2 verbs of 'projectJupyter'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/verbs
        /// </summary>
        public readonly xAPI_Verbs_ProjectJupyter verbs = new xAPI_Verbs_ProjectJupyter();

        /// <summary>
        /// 5 activities of 'projectJupyter'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/activities
        /// </summary>
        public readonly xAPI_Activities_ProjectJupyter activities = new xAPI_Activities_ProjectJupyter();

        /// <summary>
        /// 6 extensions of 'projectJupyter': 3 in activity, 1 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions
        /// </summary>
        public readonly xAPI_Context_ProjectJupyter_Extensions extensions = new xAPI_Context_ProjectJupyter_Extensions();

        public xAPI_Context_ProjectJupyter() 
            : base("projectJupyter") {
        }
    }
}