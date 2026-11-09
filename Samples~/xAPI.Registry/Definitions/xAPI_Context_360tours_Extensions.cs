
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context 360tours as public properties.
    /// </summary>
    public sealed class xAPI_Context_360tours_Extensions {

        public xAPI_Context_360tours_Extensions() {
        }

        /// <summary>
        /// 5 extensions of '360tours': 3 in activity, 2 in context.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_360tours activity {
            get {
                return new xAPI_Extensions_Activity_360tours();
            }
        }

        /// <summary>
        /// 5 extensions of '360tours': 3 in activity, 2 in context.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_360tours context {
            get {
                return new xAPI_Extensions_Context_360tours();
            }
        }
    }
}