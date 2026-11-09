using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context eyeTracking of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_EyeTracking : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_EyeTracking() 
            : base("eyeTracking") {
        }

        /// <summary>
        /// Organ of the visual system. Actors physical (left or right) eye.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/extensions/activity/eye
        /// </summary>
        public xAPI_Extensions_Activity_EyeTracking eye(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "eye",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "eye",
                        ["de-DE"] = "Auge" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Organ of the visual system. Actors physical (left or right) eye.",
                        ["de-DE"] = "Sinnesorgan zur Wahrnehmung von Lichtreizen, in diesem Kontext das physikalisches Auge des Agierenden (links oder rechts)." }),
                 value);
            return this;
        }
    }
}