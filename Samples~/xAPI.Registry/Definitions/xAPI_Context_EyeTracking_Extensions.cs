
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context eyeTracking as public properties.
    /// </summary>
    public sealed class xAPI_Context_EyeTracking_Extensions {

        public xAPI_Context_EyeTracking_Extensions() {
        }

        /// <summary>
        /// 3 extensions of 'eyeTracking': 1 in activity, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_EyeTracking activity {
            get {
                return new xAPI_Extensions_Activity_EyeTracking();
            }
        }

        /// <summary>
        /// 3 extensions of 'eyeTracking': 1 in activity, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_EyeTracking result {
            get {
                return new xAPI_Extensions_Result_EyeTracking();
            }
        }
    }
}