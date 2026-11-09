
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context multitouch as public properties.
    /// </summary>
    public class xAPI_Context_Multitouch : xAPI_Context {
        /// <summary>
        /// 12 verbs of 'multitouch'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs
        /// </summary>
        public readonly xAPI_Verbs_Multitouch verbs = new xAPI_Verbs_Multitouch();

        /// <summary>
        /// 5 activities of 'multitouch'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/activities
        /// </summary>
        public readonly xAPI_Activities_Multitouch activities = new xAPI_Activities_Multitouch();

        /// <summary>
        /// 0 extensions of 'multitouch': .
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/extensions
        /// </summary>
        public readonly xAPI_Context_Multitouch_Extensions extensions = new xAPI_Context_Multitouch_Extensions();

        public xAPI_Context_Multitouch() 
            : base("multitouch") {
        }
    }
}