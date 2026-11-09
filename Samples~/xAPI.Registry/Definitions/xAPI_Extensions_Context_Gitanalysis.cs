using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context gitanalysis of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_Gitanalysis : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_Gitanalysis() 
            : base("gitanalysis") {
        }

        /// <summary>
        /// The url of the project the activity was received from.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/context/projectUrl
        /// </summary>
        public xAPI_Extensions_Context_Gitanalysis projectUrl(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "projectUrl",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "project url",
                        ["de-DE"] = "Projektadresse" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The url of the project the activity was received from.",
                        ["de-DE"] = "Die URL des Projektes, von dem die Aktivität empfangen wurde." }),
                 value);
            return this;
        }
    }
}