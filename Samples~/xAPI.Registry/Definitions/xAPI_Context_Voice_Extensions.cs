
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context voice as public properties.
    /// </summary>
    public sealed class xAPI_Context_Voice_Extensions {

        public xAPI_Context_Voice_Extensions() {
        }

        /// <summary>
        /// 3 extensions of 'voice': 3 in activity.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_Voice activity {
            get {
                return new xAPI_Extensions_Activity_Voice();
            }
        }
    }
}