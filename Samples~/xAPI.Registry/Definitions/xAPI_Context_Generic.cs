
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context generic as public properties.
    /// </summary>
    public class xAPI_Context_Generic : xAPI_Context {
        /// <summary>
        /// 61 verbs of 'generic'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs
        /// </summary>
        public readonly xAPI_Verbs_Generic verbs = new xAPI_Verbs_Generic();

        /// <summary>
        /// 34 activities of 'generic'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities
        /// </summary>
        public readonly xAPI_Activities_Generic activities = new xAPI_Activities_Generic();

        /// <summary>
        /// 20 extensions of 'generic': 8 in activity, 5 in context, 7 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions
        /// </summary>
        public readonly xAPI_Context_Generic_Extensions extensions = new xAPI_Context_Generic_Extensions();

        public xAPI_Context_Generic() 
            : base("generic") {
        }
    }
}