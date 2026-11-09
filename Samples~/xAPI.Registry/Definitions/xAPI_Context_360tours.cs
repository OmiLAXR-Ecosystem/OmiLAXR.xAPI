
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context 360tours as public properties.
    /// </summary>
    public class xAPI_Context_360tours : xAPI_Context {
        /// <summary>
        /// 4 verbs of '360tours'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/verbs
        /// </summary>
        public readonly xAPI_Verbs_360tours verbs = new xAPI_Verbs_360tours();

        /// <summary>
        /// 4 activities of '360tours'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/activities
        /// </summary>
        public readonly xAPI_Activities_360tours activities = new xAPI_Activities_360tours();

        /// <summary>
        /// 5 extensions of '360tours': 3 in activity, 2 in context.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions
        /// </summary>
        public readonly xAPI_Context_360tours_Extensions extensions = new xAPI_Context_360tours_Extensions();

        public xAPI_Context_360tours() 
            : base("360tours") {
        }
    }
}