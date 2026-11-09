
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context ide as public properties.
    /// </summary>
    public class xAPI_Context_Ide : xAPI_Context {
        /// <summary>
        /// 17 verbs of 'ide'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs
        /// </summary>
        public readonly xAPI_Verbs_Ide verbs = new xAPI_Verbs_Ide();

        /// <summary>
        /// 7 activities of 'ide'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities
        /// </summary>
        public readonly xAPI_Activities_Ide activities = new xAPI_Activities_Ide();

        /// <summary>
        /// 23 extensions of 'ide': 12 in activity, 9 in context, 2 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions
        /// </summary>
        public readonly xAPI_Context_Ide_Extensions extensions = new xAPI_Context_Ide_Extensions();

        public xAPI_Context_Ide() 
            : base("ide") {
        }
    }
}