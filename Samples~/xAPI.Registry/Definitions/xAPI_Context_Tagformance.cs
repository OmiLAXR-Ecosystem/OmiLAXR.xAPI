
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context tagformance as public properties.
    /// </summary>
    public class xAPI_Context_Tagformance : xAPI_Context {
        /// <summary>
        /// 12 verbs of 'tagformance'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs
        /// </summary>
        public readonly xAPI_Verbs_Tagformance verbs = new xAPI_Verbs_Tagformance();

        /// <summary>
        /// 8 activities of 'tagformance'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities
        /// </summary>
        public readonly xAPI_Activities_Tagformance activities = new xAPI_Activities_Tagformance();

        /// <summary>
        /// 17 extensions of 'tagformance': 4 in activity, 11 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions
        /// </summary>
        public readonly xAPI_Context_Tagformance_Extensions extensions = new xAPI_Context_Tagformance_Extensions();

        public xAPI_Context_Tagformance() 
            : base("tagformance") {
        }
    }
}