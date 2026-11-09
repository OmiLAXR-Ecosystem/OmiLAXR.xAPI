
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context virtualReality as public properties.
    /// </summary>
    public class xAPI_Context_VirtualReality : xAPI_Context {
        /// <summary>
        /// 13 verbs of 'virtualReality'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs
        /// </summary>
        public readonly xAPI_Verbs_VirtualReality verbs = new xAPI_Verbs_VirtualReality();

        /// <summary>
        /// 8 activities of 'virtualReality'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities
        /// </summary>
        public readonly xAPI_Activities_VirtualReality activities = new xAPI_Activities_VirtualReality();

        /// <summary>
        /// 12 extensions of 'virtualReality': 8 in activity, 4 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions
        /// </summary>
        public readonly xAPI_Context_VirtualReality_Extensions extensions = new xAPI_Context_VirtualReality_Extensions();

        public xAPI_Context_VirtualReality() 
            : base("virtualReality") {
        }
    }
}