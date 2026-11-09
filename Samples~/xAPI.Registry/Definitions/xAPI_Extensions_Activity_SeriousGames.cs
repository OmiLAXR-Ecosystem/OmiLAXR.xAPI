using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context seriousGames of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_SeriousGames : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_SeriousGames() 
            : base("seriousGames") {
        }

        /// <summary>
        /// The type of button which was pressed. Has to be String.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/activity/buttontype
        /// </summary>
        public xAPI_Extensions_Activity_SeriousGames buttontype(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "buttontype",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "button type",
                        ["de-DE"] = "Knopf Typ" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The type of button which was pressed. Has to be String.",
                        ["de-DE"] = "Der Typ des Knopfes der gedrückt wurde. Muss ein String sein." }),
                 value);
            return this;
        }
    }
}