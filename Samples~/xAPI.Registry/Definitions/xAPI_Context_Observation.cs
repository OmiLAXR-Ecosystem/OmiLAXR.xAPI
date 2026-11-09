
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context observation as public properties.
    /// </summary>
    public class xAPI_Context_Observation : xAPI_Context {
        /// <summary>
        /// 9 verbs of 'observation'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs
        /// </summary>
        public readonly xAPI_Verbs_Observation verbs = new xAPI_Verbs_Observation();

        /// <summary>
        /// 13 activities of 'observation'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities
        /// </summary>
        public readonly xAPI_Activities_Observation activities = new xAPI_Activities_Observation();

        /// <summary>
        /// 0 extensions of 'observation': .
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/extensions
        /// </summary>
        public readonly xAPI_Context_Observation_Extensions extensions = new xAPI_Context_Observation_Extensions();

        public xAPI_Context_Observation() 
            : base("observation") {
        }
    }
}