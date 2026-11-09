using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context generic of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_Generic : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_Generic() 
            : base("generic") {
        }

        /// <summary>
        /// The color of an object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/color
        /// </summary>
        public xAPI_Extensions_Activity_Generic color(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "color",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "color",
                        ["de-DE"] = "Color" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The color of an object.",
                        ["de-DE"] = "Das Farbe eines Objekts." }),
                 value);
            return this;
        }

        /// <summary>
        /// A relative or absolute file path of a file. Can be used to provide the filepath for a file-activity.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/filepath
        /// </summary>
        public xAPI_Extensions_Activity_Generic filepath(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "filepath",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "file path",
                        ["de-DE"] = "Dateipfad" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A relative or absolute file path of a file. Can be used to provide the filepath for a file-activity.",
                        ["de-DE"] = "Ein relativer oder absoluter Dateipfad. Kann genutzt werden um den Dateipfad eine Dateiaktivität anzugeben." }),
                 value);
            return this;
        }

        /// <summary>
        /// The button of the keyboard.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/keyboardButton
        /// </summary>
        public xAPI_Extensions_Activity_Generic keyboardButton(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "keyboardButton",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "keyboard button",
                        ["de-DE"] = "Tastatur Taste" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The button of the keyboard.",
                        ["de-DE"] = "Eine Taste der Tastatur." }),
                 value);
            return this;
        }

        /// <summary>
        /// The button of a mouse.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/mouseButton
        /// </summary>
        public xAPI_Extensions_Activity_Generic mouseButton(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mouseButton",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "mouse button",
                        ["de-DE"] = "Maus Taste" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The button of a mouse.",
                        ["de-DE"] = "Die Taste einer Maus." }),
                 value);
            return this;
        }

        /// <summary>
        /// The position of the mouse.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/mousePosition
        /// </summary>
        public xAPI_Extensions_Activity_Generic mousePosition(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mousePosition",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "mouse position",
                        ["de-DE"] = "Maus Position" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The position of the mouse.",
                        ["de-DE"] = "Die Position der Maus." }),
                 value);
            return this;
        }

        /// <summary>
        /// Name of activity target. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/name
        /// </summary>
        public xAPI_Extensions_Activity_Generic name(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "name",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "name",
                        ["de-DE"] = "Name" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of activity target. Must be a string.",
                        ["de-DE"] = "Name der Zielaktivität. Muss ein String sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// An number or other identifier (e.g. 'top', 'bottom') to identify the position of an element inside a colletion such as an list of elements.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/position
        /// </summary>
        public xAPI_Extensions_Activity_Generic position(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "position",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "position",
                        ["de-DE"] = "Position" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An number or other identifier (e.g. 'top', 'bottom') to identify the position of an element inside a colletion such as an list of elements.",
                        ["de-DE"] = "Eine Nummer oder ein anderer Kennzeichnung einer Position eines Elementes einer Sammlung wie zum Beispliel einer Liste von Elementen." }),
                 value);
            return this;
        }

        /// <summary>
        /// The scroll value of a trackpad or mouse wheel.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/activity/scrollValue
        /// </summary>
        public xAPI_Extensions_Activity_Generic scrollValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "scrollValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "scroll value",
                        ["de-DE"] = "Skrollwert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The scroll value of a trackpad or mouse wheel.",
                        ["de-DE"] = "Die Skrollwert vom Trackpad oder Mausrad." }),
                 value);
            return this;
        }
    }
}