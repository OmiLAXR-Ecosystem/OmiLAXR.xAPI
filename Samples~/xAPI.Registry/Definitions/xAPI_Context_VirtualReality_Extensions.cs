
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context virtualReality as public properties.
    /// </summary>
    public sealed class xAPI_Context_VirtualReality_Extensions {

        public xAPI_Context_VirtualReality_Extensions() {
        }

        /// <summary>
        /// 12 extensions of 'virtualReality': 8 in activity, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality activity {
            get {
                return new xAPI_Extensions_Activity_VirtualReality();
            }
        }

        /// <summary>
        /// 12 extensions of 'virtualReality': 8 in activity, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_VirtualReality result {
            get {
                return new xAPI_Extensions_Result_VirtualReality();
            }
        }
    }
}