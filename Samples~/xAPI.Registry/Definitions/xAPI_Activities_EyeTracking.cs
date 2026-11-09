using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 1 items of the xAPI_Activities of the context eyeTracking as public properties.
    /// </summary>
    public sealed class xAPI_Activities_EyeTracking : xAPI_Activities {
        /// <summary>
        /// Organ of the visual system. Actors physical (left or right) eye.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/activities/eye
        /// </summary>
        public readonly xAPI_Activity eye = new xAPI_Activity(
            context: "eyeTracking",
            key: "eye",
            names: new Dictionary<string, string> {
                ["en-US"] = "eye",
                ["de-DE"] = "Auge" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Organ of the visual system. Actors physical (left or right) eye.",
                ["de-DE"] = "Sinnesorgan zur Wahrnehmung von Lichtreizen, in diesem Kontext das physikalisches Auge des Agierenden (links oder rechts)." });

        public xAPI_Activities_EyeTracking() 
            : base("eyeTracking") {
        }
    }
}