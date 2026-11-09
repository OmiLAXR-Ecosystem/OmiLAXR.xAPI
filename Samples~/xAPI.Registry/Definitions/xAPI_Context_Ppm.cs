
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context ppm as public properties.
    /// </summary>
    public class xAPI_Context_Ppm : xAPI_Context {
        /// <summary>
        /// 0 verbs of 'ppm'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/verbs
        /// </summary>
        public readonly xAPI_Verbs_Ppm verbs = new xAPI_Verbs_Ppm();

        /// <summary>
        /// 0 activities of 'ppm'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/activities
        /// </summary>
        public readonly xAPI_Activities_Ppm activities = new xAPI_Activities_Ppm();

        /// <summary>
        /// 2 extensions of 'ppm': 1 in context, 1 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ppm/extensions
        /// </summary>
        public readonly xAPI_Context_Ppm_Extensions extensions = new xAPI_Context_Ppm_Extensions();

        public xAPI_Context_Ppm() 
            : base("ppm") {
        }
    }
}