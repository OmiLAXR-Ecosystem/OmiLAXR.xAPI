using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context virtualReality of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_VirtualReality : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_VirtualReality() 
            : base("virtualReality") {
        }

        /// <summary>
        /// It is the name of an action.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/actionName
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality actionName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "actionName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "action name",
                        ["de-DE"] = "Aktionsname" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "It is the name of an action.",
                        ["de-DE"] = "Es ist der Name einer Aktion." }),
                 value);
            return this;
        }

        /// <summary>
        /// Sequence of vertices with it's index, color and position.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/triangle
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality triangle(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "triangle",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Triangle",
                        ["de-DE"] = "Dreieck" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Sequence of vertices with it's index, color and position.",
                        ["de-DE"] = "Sequenz von Knotenpunkten mit dessen Index, Farbe und Position." }),
                 value);
            return this;
        }

        /// <summary>
        /// The max. value of an ui element, could be input controls e.g. buttons, slider, navigational e.g. breadcrumbs or a navigation panel, or informational elements e.g. message panel. The Value could include the selected value, but could also contain information about the range. So that a phrase such as &gt;21 out of 42&lt; indicates that the slider, which ranges from 1 to 42 was changed to the value 21. {value; min; max}: {21, 1,42}.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/uiElementMaxValue
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality uiElementMaxValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "uiElementMaxValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR user interface element max value",
                        ["de-DE"] = "Max. Wert eines VR Benutzerflächenelements" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The max. value of an ui element, could be input controls e.g. buttons, slider, navigational e.g. breadcrumbs or a navigation panel, or informational elements e.g. message panel. The Value could include the selected value, but could also contain information about the range. So that a phrase such as >21 out of 42< indicates that the slider, which ranges from 1 to 42 was changed to the value 21. {value; min; max}: {21, 1,42}.",
                        ["de-DE"] = "Der max. Wert eines interaktiven Benutzerflächenelements mit dem der Benutzer interagieren kann, bei dem es sich zum Beispiel um eine Eingabesteuerung, wie Buttons oder Slider, eine Navigation, z.B. mit Brotkrumen-Elementen oder Navigationstafel, oder eine Informationsanzeige hadelt, z.B. eine Messagebox. Der Wert kann den ausgewählten Wert enthalten, aber auch Informationen über den Bereich. So bedeutet ein Satz wie >21 von 42<, dass der Schieberegler, der von 1 bis 42 reicht, auf den Wert 21 geändert wurde. {Wert; min; max}: {21, 1,42}." }),
                 value);
            return this;
        }

        /// <summary>
        /// The min. value of an ui element, could be input controls e.g. buttons, slider, navigational e.g. breadcrumbs or a navigation panel, or informational elements e.g. message panel. The Value could include the selected value, but could also contain information about the range. So that a phrase such as &gt;21 out of 42&lt; indicates that the slider, which ranges from 1 to 42 was changed to the value 21. {value; min; max}: {21, 1,42}.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/uiElementMinValue
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality uiElementMinValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "uiElementMinValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR user interface element min value",
                        ["de-DE"] = "Min. Wert eines VR Benutzerflächenelements" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The min. value of an ui element, could be input controls e.g. buttons, slider, navigational e.g. breadcrumbs or a navigation panel, or informational elements e.g. message panel. The Value could include the selected value, but could also contain information about the range. So that a phrase such as >21 out of 42< indicates that the slider, which ranges from 1 to 42 was changed to the value 21. {value; min; max}: {21, 1,42}.",
                        ["de-DE"] = "Der min. Wert eines interaktiven Benutzerflächenelements mit dem der Benutzer interagieren kann, bei dem es sich zum Beispiel um eine Eingabesteuerung, wie Buttons oder Slider, eine Navigation, z.B. mit Brotkrumen-Elementen oder Navigationstafel, oder eine Informationsanzeige hadelt, z.B. eine Messagebox. Der Wert kann den ausgewählten Wert enthalten, aber auch Informationen über den Bereich. So bedeutet ein Satz wie >21 von 42<, dass der Schieberegler, der von 1 bis 42 reicht, auf den Wert 21 geändert wurde. {Wert; min; max}: {21, 1,42}." }),
                 value);
            return this;
        }

        /// <summary>
        /// Describes the available list of options of the interactive interface element (e.g. Dropdown). Can be a string array.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/uiElementOptions
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality uiElementOptions(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "uiElementOptions",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR user interface element options",
                        ["de-DE"] = "VR Benutzeroberflächen Optionen" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Describes the available list of options of the interactive interface element (e.g. Dropdown). Can be a string array.",
                        ["de-DE"] = "Die Liste der verfügbaren Optionen des interaktiven Elements einer Benutzeroberfläche (z.B. Dropdown). Kann ein String Array sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Describes the type of the interactive interface element. Could specify the element or the category of the element depending on the needs, e.g. categories: input controls, navigation or informational components or containers vs direct element: button, checkbox, dropdown, breadcrumb, tooltip… and so on.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/uiElementType
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality uiElementType(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "uiElementType",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR user interface element type",
                        ["de-DE"] = "VR Benutzeroberflächenelementtyp" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Describes the type of the interactive interface element. Could specify the element or the category of the element depending on the needs, e.g. categories: input controls, navigation or informational components or containers vs direct element: button, checkbox, dropdown, breadcrumb, tooltip… and so on.",
                        ["de-DE"] = "Der Typ des interaktiven Elements einer Benutzeroberfläche. Kann zum Beispiel die Kategorie oder den Elementtyp enthalten. Kategorien sind zum Beispiel, ob es sich um eine Eingabesteuerung, ein Navigations- oder Informationselement oder um einen Container handelt. Während eine Elementbeschreibung auf der Ebene sein kann: Button, Checkbox, Dropdown Auswahl, Brotkrumennavigation, Tooltip… usw " }),
                 value);
            return this;
        }

        /// <summary>
        /// A value of an ui element, could be input controls e.g. buttons, slider, navigational e.g. breadcrumbs or a navigation panel, or informational elements e.g. message panel. The Value could include the selected value, but could also contain information about the range. So that a phrase such as &gt;21 out of 42&lt; indicates that the slider, which ranges from 1 to 42 was changed to the value 21. {value; min; max}: {21, 1,42}.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/uiElementValue
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality uiElementValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "uiElementValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR user interface element value",
                        ["de-DE"] = "Wert eines VR Benutzerflächenelements" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A value of an ui element, could be input controls e.g. buttons, slider, navigational e.g. breadcrumbs or a navigation panel, or informational elements e.g. message panel. The Value could include the selected value, but could also contain information about the range. So that a phrase such as >21 out of 42< indicates that the slider, which ranges from 1 to 42 was changed to the value 21. {value; min; max}: {21, 1,42}.",
                        ["de-DE"] = "Der Wert eines interaktiven Benutzerflächenelements mit dem der Benutzer interagieren kann, bei dem es sich zum Beispiel um eine Eingabesteuerung, wie Buttons oder Slider, eine Navigation, z.B. mit Brotkrumen-Elementen oder Navigationstafel, oder eine Informationsanzeige hadelt, z.B. eine Messagebox. Der Wert kann den ausgewählten Wert enthalten, aber auch Informationen über den Bereich. So bedeutet ein Satz wie >21 von 42<, dass der Schieberegler, der von 1 bis 42 reicht, auf den Wert 21 geändert wurde. {Wert; min; max}: {21, 1,42}." }),
                 value);
            return this;
        }

        /// <summary>
        /// Name of a VR object. Must be a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/extensions/activity/vrObjectName
        /// </summary>
        public xAPI_Extensions_Activity_VirtualReality vrObjectName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "vrObjectName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "VR object name",
                        ["de-DE"] = "VR Objekt Name" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of a VR object. Must be a string.",
                        ["de-DE"] = "Namen vom VR Objekt. Muss ein String sein." }),
                 value);
            return this;
        }
    }
}