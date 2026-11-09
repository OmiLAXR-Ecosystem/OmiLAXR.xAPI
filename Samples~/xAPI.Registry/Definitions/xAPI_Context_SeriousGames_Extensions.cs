
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context seriousGames as public properties.
    /// </summary>
    public sealed class xAPI_Context_SeriousGames_Extensions {

        public xAPI_Context_SeriousGames_Extensions() {
        }

        /// <summary>
        /// 18 extensions of 'seriousGames': 1 in activity, 4 in context, 13 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_SeriousGames activity {
            get {
                return new xAPI_Extensions_Activity_SeriousGames();
            }
        }

        /// <summary>
        /// 18 extensions of 'seriousGames': 1 in activity, 4 in context, 13 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_SeriousGames context {
            get {
                return new xAPI_Extensions_Context_SeriousGames();
            }
        }

        /// <summary>
        /// 18 extensions of 'seriousGames': 1 in activity, 4 in context, 13 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames result {
            get {
                return new xAPI_Extensions_Result_SeriousGames();
            }
        }
    }
}