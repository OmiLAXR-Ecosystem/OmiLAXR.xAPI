
namespace xAPI.Registry {
    /// <summary>
    /// Provides the definitions of the context vrRfidChamber as public properties.
    /// </summary>
    public class xAPI_Context_VrRfidChamber : xAPI_Context {
        /// <summary>
        /// 22 verbs of 'vrRfidChamber'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs
        /// </summary>
        public readonly xAPI_Verbs_VrRfidChamber verbs = new xAPI_Verbs_VrRfidChamber();

        /// <summary>
        /// 10 activities of 'vrRfidChamber'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities
        /// </summary>
        public readonly xAPI_Activities_VrRfidChamber activities = new xAPI_Activities_VrRfidChamber();

        /// <summary>
        /// 10 extensions of 'vrRfidChamber': 5 in context, 5 in result.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/extensions
        /// </summary>
        public readonly xAPI_Context_VrRfidChamber_Extensions extensions = new xAPI_Context_VrRfidChamber_Extensions();

        public xAPI_Context_VrRfidChamber() 
            : base("vrRfidChamber") {
        }
    }
}