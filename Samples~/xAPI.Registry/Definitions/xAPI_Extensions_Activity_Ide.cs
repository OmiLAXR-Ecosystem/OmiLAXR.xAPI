using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context ide of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_Ide : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_Ide() 
            : base("ide") {
        }

        /// <summary>
        /// Content of a target activity. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/content
        /// </summary>
        public xAPI_Extensions_Activity_Ide content(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "content",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "content",
                        ["de-DE"] = "Inhalt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Content of a target activity. Must be a string.",
                        ["de-DE"] = "Inhalt der Zielaktivität. Muss ein String sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// True, if the target window is docked.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/docked
        /// </summary>
        public xAPI_Extensions_Activity_Ide docked(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "docked",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "docked",
                        ["de-DE"] = "angedockt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "True, if the target window is docked.",
                        ["de-DE"] = "Wahr, wenn das Fenster angedockt ist." }),
                 value);
            return this;
        }

        /// <summary>
        /// File size in bytes of a Library, template, configuration or multimedia file.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/fileBytes
        /// </summary>
        public xAPI_Extensions_Activity_Ide fileBytes(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "fileBytes",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "file bytes",
                        ["de-DE"] = "File Bytes" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "File size in bytes of a Library, template, configuration or multimedia file.",
                        ["de-DE"] = "Dateigröße in Bytes einer Bibliothek, Vorlage, Konfigurations- oder Multimediadatei." }),
                 value);
            return this;
        }

        /// <summary>
        /// ID of activity target. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/id
        /// </summary>
        public xAPI_Extensions_Activity_Ide id(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "id",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "id",
                        ["de-DE"] = "ID" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "ID of activity target. Must be a string.",
                        ["de-DE"] = "ID der Zielaktivität. Muss ein String sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// True, if the target window is maximized.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/maximized
        /// </summary>
        public xAPI_Extensions_Activity_Ide maximized(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "maximized",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "maximized",
                        ["de-DE"] = "maximiert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "True, if the target window is maximized.",
                        ["de-DE"] = "Wahr, wenn das Fenster maximiert ist." }),
                 value);
            return this;
        }

        /// <summary>
        /// Parent of activity target. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/parent
        /// </summary>
        public xAPI_Extensions_Activity_Ide parent(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "parent",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "parent",
                        ["de-DE"] = "Elternteil" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Parent of activity target. Must be a string.",
                        ["de-DE"] = "Elternteil der Zielaktivität. Muss ein String sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Path of activity target. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/path
        /// </summary>
        public xAPI_Extensions_Activity_Ide path(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "path",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "path",
                        ["de-DE"] = "Path" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Path of activity target. Must be a string.",
                        ["de-DE"] = "Path der Zielaktivität. Muss ein String sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Position of activity target. Must be a string with coordinates of '(x,y)'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/position
        /// </summary>
        public xAPI_Extensions_Activity_Ide position(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "position",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "position",
                        ["de-DE"] = "Position" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Position of activity target. Must be a string with coordinates of '(x,y)'.",
                        ["de-DE"] = "Position der Zielaktivität. Muss ein String mit Koordinaten sein '(x,y)'." }),
                 value);
            return this;
        }

        /// <summary>
        /// Rectangle of activity target. Must be a string with coordinates of '(x,y,width,height)'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/rect
        /// </summary>
        public xAPI_Extensions_Activity_Ide rect(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "rect",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "rect",
                        ["de-DE"] = "Rechteck" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Rectangle of activity target. Must be a string with coordinates of '(x,y,width,height)'.",
                        ["de-DE"] = "Rechteck der Zielaktivität. Muss ein String mit Koordinaten sein '(x,y,Breite,Höhe)'." }),
                 value);
            return this;
        }

        /// <summary>
        /// Size of activity target (e.g. window size). Must be a string with coordinates of '(width,height)'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/size
        /// </summary>
        public xAPI_Extensions_Activity_Ide size(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "size",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "size",
                        ["de-DE"] = "Größe" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Size of activity target (e.g. window size). Must be a string with coordinates of '(width,height)'.",
                        ["de-DE"] = "Größe der Zielaktivität (z.B. Fenstergröße). Muss ein String mit Koordinaten sein '(Breite,Höhe)'." }),
                 value);
            return this;
        }

        /// <summary>
        /// Representing the state of the target activity like 'loading', 'starting', ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/status
        /// </summary>
        public xAPI_Extensions_Activity_Ide status(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "status",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "state",
                        ["de-DE"] = "Status" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Representing the state of the target activity like 'loading', 'starting', ...",
                        ["de-DE"] = "Repräsentiert den Status der Zielaktivität, wie zum Beispiel 'laden', 'starten', ..." }),
                 value);
            return this;
        }

        /// <summary>
        /// Type of a target activity. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/activity/type
        /// </summary>
        public xAPI_Extensions_Activity_Ide type(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "type",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "type",
                        ["de-DE"] = "Type" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Type of a target activity. Must be a string.",
                        ["de-DE"] = "Typ der Zielaktivität. Muss ein String sein." }),
                 value);
            return this;
        }
    }
}