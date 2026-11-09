
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context media as public properties.
    /// </summary>
    public class xAPI_Context_Media : xAPI_Context {
        /// <summary>
        /// 8 verbs of 'media'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs
        /// </summary>
        public readonly xAPI_Verbs_Media verbs = new xAPI_Verbs_Media();

        /// <summary>
        /// 2 activities of 'media'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/activities
        /// </summary>
        public readonly xAPI_Activities_Media activities = new xAPI_Activities_Media();

        /// <summary>
        /// 0 extensions of 'media': .
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/extensions
        /// </summary>
        public readonly xAPI_Context_Media_Extensions extensions = new xAPI_Context_Media_Extensions();

        public xAPI_Context_Media() 
            : base("media") {
        }
    }
}