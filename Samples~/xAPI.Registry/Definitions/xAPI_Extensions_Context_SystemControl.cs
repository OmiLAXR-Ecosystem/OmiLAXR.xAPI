using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context systemControl of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_SystemControl : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_SystemControl() 
            : base("systemControl") {
        }

        /// <summary>
        /// The framerate is the amount of frames (images) per seconds, which was generated at captured moment in the recorded period of time.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/extensions/context/fps
        /// </summary>
        public xAPI_Extensions_Context_SystemControl fps(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "fps",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Frames per Second",
                        ["de-DE"] = "Bilder pro Sekunde" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The framerate is the amount of frames (images) per seconds, which was generated at captured moment in the recorded period of time.",
                        ["de-DE"] = "Die Bildfrequenz ist die Anzahl an Einzelbildern pro Sekunde, die zum aufgenommenen Zeitpunkt bzw. während der aufgenommenen Zeitspanne vorgelegen hat." }),
                 value);
            return this;
        }
    }
}