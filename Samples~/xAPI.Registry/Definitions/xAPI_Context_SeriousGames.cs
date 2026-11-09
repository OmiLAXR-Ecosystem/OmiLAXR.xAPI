
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context seriousGames as public properties.
    /// </summary>
    public class xAPI_Context_SeriousGames : xAPI_Context {
        /// <summary>
        /// 11 verbs of 'seriousGames'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/verbs
        /// </summary>
        public readonly xAPI_Verbs_SeriousGames verbs = new xAPI_Verbs_SeriousGames();

        /// <summary>
        /// 8 activities of 'seriousGames'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities
        /// </summary>
        public readonly xAPI_Activities_SeriousGames activities = new xAPI_Activities_SeriousGames();

        /// <summary>
        /// 18 extensions of 'seriousGames': 1 in activity, 4 in context, 13 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions
        /// </summary>
        public readonly xAPI_Context_SeriousGames_Extensions extensions = new xAPI_Context_SeriousGames_Extensions();

        public xAPI_Context_SeriousGames() 
            : base("seriousGames") {
        }
    }
}