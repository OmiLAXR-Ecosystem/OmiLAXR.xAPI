using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context virtualReality of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_VirtualReality : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_VirtualReality() 
            : base("virtualReality") {
        }

        /// <summary>
        /// The vertical distance of the camera position relative to the floor. This value represents the camera's Y-axis position in the 3D space, such as the height at which the camera is positioned. The floor should be initalized to zero.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/result/cameraYOffset
        /// </summary>
        public xAPI_Extensions_Result_VirtualReality cameraYOffset(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "cameraYOffset",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "camera Y offset",
                        ["de-DE"] = "Kamera Y Versatz" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The vertical distance of the camera position relative to the floor. This value represents the camera's Y-axis position in the 3D space, such as the height at which the camera is positioned. The floor should be initalized to zero.",
                        ["de-DE"] = "Der vertikale Versatz der Kameraposition relativ zum Boden. Dieser Wert gibt die Y-Achsen-Position der Kamera im 3D-Raum, z. B. die Höhe, in der sich die Kamera befindet. Der Boden sollte auf Null initalisiert werden." }),
                 value);
            return this;
        }

        /// <summary>
        /// Position in scene.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/result/position
        /// </summary>
        public xAPI_Extensions_Result_VirtualReality position(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "position",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "position",
                        ["de-DE"] = "Position" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Position in scene.",
                        ["de-DE"] = "Position in der Szene." }),
                 value);
            return this;
        }

        /// <summary>
        /// Rotation in scene.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/result/rotation
        /// </summary>
        public xAPI_Extensions_Result_VirtualReality rotation(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "rotation",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "rotation",
                        ["de-DE"] = "Rotation" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Rotation in scene.",
                        ["de-DE"] = "Rotation in der Szene." }),
                 value);
            return this;
        }

        /// <summary>
        /// Scale in scene.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/result/scale
        /// </summary>
        public xAPI_Extensions_Result_VirtualReality scale(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "scale",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "scale",
                        ["de-DE"] = "Skalierung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Scale in scene.",
                        ["de-DE"] = "Skalierung in der Szene." }),
                 value);
            return this;
        }
    }
}