using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context eyeTracking of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_EyeTracking : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_EyeTracking() 
            : base("eyeTracking") {
        }

        /// <summary>
        /// The fixation duration is the measure how long the actor spend looking at a particular location.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/extensions/result/duration
        /// </summary>
        public xAPI_Extensions_Result_EyeTracking duration(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "duration",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "fixation duration",
                        ["de-DE"] = "Fixationsdauer" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The fixation duration is the measure how long the actor spend looking at a particular location.",
                        ["de-DE"] = "Die Fixationsdauer beschreibt die Zeit, die ein Akteur oder eine Akteurin den Blick auf einem bestimmten Ort hat verweilen lassen." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of actors eye blinking within a focus sequence. Has to be an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/extensions/result/numberOfBlinks
        /// </summary>
        public xAPI_Extensions_Result_EyeTracking numberOfBlinks(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberOfBlinks",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number of blinks",
                        ["de-DE"] = "Zwinker Anzahl" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of actors eye blinking within a focus sequence. Has to be an integer.",
                        ["de-DE"] = "Die Anzahl an Blinzler, die der Agierende während einer Fokus Sequenz getätigt hat. Muss ganzzahlig sein." }),
                 value);
            return this;
        }
    }
}