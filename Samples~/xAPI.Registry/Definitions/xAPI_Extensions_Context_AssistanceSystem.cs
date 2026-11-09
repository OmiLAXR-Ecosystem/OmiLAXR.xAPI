using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context assistanceSystem of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_AssistanceSystem : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_AssistanceSystem() 
            : base("assistanceSystem") {
        }

        /// <summary>
        /// The identifier of an object, behavior, or person.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/context/identifier
        /// </summary>
        public xAPI_Extensions_Context_AssistanceSystem identifier(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "identifier",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "identifier",
                        ["de-DE"] = "Identifikator" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The identifier of an object, behavior, or person.",
                        ["de-DE"] = "Der Identifikator eines Objekts, einer Verhaltensweise oder einer Person." }),
                 value);
            return this;
        }

        /// <summary>
        /// The type of an object, behavior, or person.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/assistanceSystem/extensions/context/type
        /// </summary>
        public xAPI_Extensions_Context_AssistanceSystem type(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "type",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "type",
                        ["de-DE"] = "Type" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The type of an object, behavior, or person.",
                        ["de-DE"] = "Der Typ eines Objekts, einer Verhaltensweise oder einer Person." }),
                 value);
            return this;
        }
    }
}