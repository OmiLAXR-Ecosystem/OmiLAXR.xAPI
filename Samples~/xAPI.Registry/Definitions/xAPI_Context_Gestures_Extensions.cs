
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context gestures as public properties.
    /// </summary>
    public sealed class xAPI_Context_Gestures_Extensions {

        public xAPI_Context_Gestures_Extensions() {
        }

        /// <summary>
        /// 3 extensions of 'gestures': 1 in activity, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_Gestures activity {
            get {
                return new xAPI_Extensions_Activity_Gestures();
            }
        }

        /// <summary>
        /// 3 extensions of 'gestures': 1 in activity, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_Gestures result {
            get {
                return new xAPI_Extensions_Result_Gestures();
            }
        }
    }
}