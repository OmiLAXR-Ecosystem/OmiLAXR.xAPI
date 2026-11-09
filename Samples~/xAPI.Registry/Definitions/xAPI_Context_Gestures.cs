
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context gestures as public properties.
    /// </summary>
    public class xAPI_Context_Gestures : xAPI_Context {
        /// <summary>
        /// 5 verbs of 'gestures'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/verbs
        /// </summary>
        public readonly xAPI_Verbs_Gestures verbs = new xAPI_Verbs_Gestures();

        /// <summary>
        /// 2 activities of 'gestures'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/activities
        /// </summary>
        public readonly xAPI_Activities_Gestures activities = new xAPI_Activities_Gestures();

        /// <summary>
        /// 3 extensions of 'gestures': 1 in activity, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/extensions
        /// </summary>
        public readonly xAPI_Context_Gestures_Extensions extensions = new xAPI_Context_Gestures_Extensions();

        public xAPI_Context_Gestures() 
            : base("gestures") {
        }
    }
}