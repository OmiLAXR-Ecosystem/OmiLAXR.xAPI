
namespace xAPI.Registry {
    /// <summary>
    /// Provides the extensions of the context ide as public properties.
    /// </summary>
    public sealed class xAPI_Context_Ide_Extensions {

        public xAPI_Context_Ide_Extensions() {
        }

        /// <summary>
        /// 23 extensions of 'ide': 12 in activity, 9 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity
        /// </summary>
        public xAPI_Extensions_Activity_Ide activity {
            get {
                return new xAPI_Extensions_Activity_Ide();
            }
        }

        /// <summary>
        /// 23 extensions of 'ide': 12 in activity, 9 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context
        /// </summary>
        public xAPI_Extensions_Context_Ide context {
            get {
                return new xAPI_Extensions_Context_Ide();
            }
        }

        /// <summary>
        /// 23 extensions of 'ide': 12 in activity, 9 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/result
        /// </summary>
        public xAPI_Extensions_Result_Ide result {
            get {
                return new xAPI_Extensions_Result_Ide();
            }
        }
    }
}