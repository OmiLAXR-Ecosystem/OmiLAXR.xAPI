using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context ide of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_Ide : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_Ide() 
            : base("ide") {
        }

        /// <summary>
        /// Mouse position of the screen. Must be a string with coordinates of '(x,y)'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/result/mousePosition
        /// </summary>
        public xAPI_Extensions_Result_Ide mousePosition(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mousePosition",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "mouse position",
                        ["de-DE"] = "Maus Position" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Mouse position of the screen. Must be a string with coordinates of '(x,y)'.",
                        ["de-DE"] = "Maus Position auf dem Bildschirm. Muss ein String mit Koordinaten sein '(x,y)'." }),
                 value);
            return this;
        }

        /// <summary>
        /// Seconds past after startup. Must be a float value, where 1.0 is one second.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/result/secondsSinceStartup
        /// </summary>
        public xAPI_Extensions_Result_Ide secondsSinceStartup(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "secondsSinceStartup",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "seconds since startup",
                        ["de-DE"] = "Sekunden seit Start" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Seconds past after startup. Must be a float value, where 1.0 is one second.",
                        ["de-DE"] = "Sekunden, die seit dem Start vergangen sind. Ist ein float, wobei 1.0 eine Sekunde ist." }),
                 value);
            return this;
        }
    }
}