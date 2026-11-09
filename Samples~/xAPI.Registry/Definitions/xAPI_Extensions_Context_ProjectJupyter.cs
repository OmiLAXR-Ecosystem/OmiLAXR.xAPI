using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context projectJupyter of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_ProjectJupyter : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_ProjectJupyter() 
            : base("projectJupyter") {
        }

        /// <summary>
        /// Name of the currently loaded JupyterLab profile (within a JupyterHub).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/context/profilename
        /// </summary>
        public xAPI_Extensions_Context_ProjectJupyter profilename(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "profilename",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "profilename",
                        ["de-DE"] = "Profilname" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Name of the currently loaded JupyterLab profile (within a JupyterHub).",
                        ["de-DE"] = "Name des aktuell geladenen JupyterLab-Profils (in einem JupyterHub)." }),
                 value);
            return this;
        }
    }
}