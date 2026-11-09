using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context projectJupyter of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_ProjectJupyter : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_ProjectJupyter() 
            : base("projectJupyter") {
        }

        /// <summary>
        /// A string representing the cell outputs of a JupyterLab cell. Outputs can contain a.o. execution results or display data.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/result/cellOutput
        /// </summary>
        public xAPI_Extensions_Result_ProjectJupyter cellOutput(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "cellOutput",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Cell Output",
                        ["de-DE"] = "Zellenausgabe" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A string representing the cell outputs of a JupyterLab cell. Outputs can contain a.o. execution results or display data.",
                        ["de-DE"] = "Ein String der die Ausgabe einer JupyterLab-Zelle beschreibt. Ausgaben können u.a. Ausführungsergebnisse oder Anzeigedaten enthalten." }),
                 value);
            return this;
        }

        /// <summary>
        /// A string describing an error. Used to provide the runtimeerror that might occur during the execution of ta JupyterLab notebook cell.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/result/errorMessage
        /// </summary>
        public xAPI_Extensions_Result_ProjectJupyter errorMessage(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "errorMessage",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Error message",
                        ["de-DE"] = "Fehlermeldung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A string describing an error. Used to provide the runtimeerror that might occur during the execution of ta JupyterLab notebook cell.",
                        ["de-DE"] = "Die beschreibung eines Fehlers. Wird verwended um z.b. Laufzeitfehler während des Ausführens einer JupyterLab Notebook Zelle anzugeben." }),
                 value);
            return this;
        }
    }
}