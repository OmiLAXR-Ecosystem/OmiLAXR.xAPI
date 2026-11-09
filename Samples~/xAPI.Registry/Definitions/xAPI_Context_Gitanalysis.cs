
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context gitanalysis as public properties.
    /// </summary>
    public class xAPI_Context_Gitanalysis : xAPI_Context {
        /// <summary>
        /// 14 verbs of 'gitanalysis'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs
        /// </summary>
        public readonly xAPI_Verbs_Gitanalysis verbs = new xAPI_Verbs_Gitanalysis();

        /// <summary>
        /// 6 activities of 'gitanalysis'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities
        /// </summary>
        public readonly xAPI_Activities_Gitanalysis activities = new xAPI_Activities_Gitanalysis();

        /// <summary>
        /// 28 extensions of 'gitanalysis': 17 in activity, 1 in context, 10 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions
        /// </summary>
        public readonly xAPI_Context_Gitanalysis_Extensions extensions = new xAPI_Context_Gitanalysis_Extensions();

        public xAPI_Context_Gitanalysis() 
            : base("gitanalysis") {
        }
    }
}