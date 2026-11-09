using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context tagformance of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_Tagformance : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_Tagformance() 
            : base("tagformance") {
        }

        /// <summary>
        /// An experiment mode can be for example 'Energy Measurement' or 'Orientation Measurement'
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/activity/experimentMode
        /// </summary>
        public xAPI_Extensions_Activity_Tagformance experimentMode(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "experimentMode",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "experiment mode" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An experiment mode can be for example 'Energy Measurement' or 'Orientation Measurement'" }),
                 value);
            return this;
        }

        /// <summary>
        /// An actor has authored the name of the graph or entered the username.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/activity/graphName
        /// </summary>
        public xAPI_Extensions_Activity_Tagformance graphName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "graphName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "graphName" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An actor has authored the name of the graph or entered the username." }),
                 value);
            return this;
        }

        /// <summary>
        /// Name of the mouse button the actor has used (e.g. 'right', 'left').
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/activity/mouseButton
        /// </summary>
        public xAPI_Extensions_Activity_Tagformance mouseButton(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mouseButton",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "mouse button" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of the mouse button the actor has used (e.g. 'right', 'left')." }),
                 value);
            return this;
        }

        /// <summary>
        /// A value of an ui element (checkbox, dropdown, etc.).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/extensions/activity/uiElementValue
        /// </summary>
        public xAPI_Extensions_Activity_Tagformance uiElementValue(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "uiElementValue",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "ui element value" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A value of an ui element (checkbox, dropdown, etc.)." }),
                 value);
            return this;
        }
    }
}