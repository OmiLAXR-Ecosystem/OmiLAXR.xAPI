
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context eyeTracking as public properties.
    /// </summary>
    public class xAPI_Context_EyeTracking : xAPI_Context {
        /// <summary>
        /// 3 verbs of 'eyeTracking'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/verbs
        /// </summary>
        public readonly xAPI_Verbs_EyeTracking verbs = new xAPI_Verbs_EyeTracking();

        /// <summary>
        /// 1 activities of 'eyeTracking'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/activities
        /// </summary>
        public readonly xAPI_Activities_EyeTracking activities = new xAPI_Activities_EyeTracking();

        /// <summary>
        /// 3 extensions of 'eyeTracking': 1 in activity, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/extensions
        /// </summary>
        public readonly xAPI_Context_EyeTracking_Extensions extensions = new xAPI_Context_EyeTracking_Extensions();

        public xAPI_Context_EyeTracking() 
            : base("eyeTracking") {
        }
    }
}