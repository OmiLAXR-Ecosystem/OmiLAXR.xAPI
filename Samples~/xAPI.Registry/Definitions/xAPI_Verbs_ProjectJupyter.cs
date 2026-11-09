using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 2 items of the xAPI_Verbs of the context projectJupyter as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_ProjectJupyter : xAPI_Verbs {
        /// <summary>
        /// Indicates, that an actor executed some programming context. Typically a Jupyter Notebook Code Cell.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/verbs/executed
        /// </summary>
        public readonly xAPI_Verb executed = new xAPI_Verb(
            context: "projectJupyter",
            key: "executed",
            names: new Dictionary<string, string> {
                ["en-US"] = "executed",
                ["de-DE"] = "führte aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Indicates, that an actor executed some programming context. Typically a Jupyter Notebook Code Cell.",
                ["de-DE"] = "Signalisiert, dass ein Akteur ein Programmierkonstrukt ausführte. Typischerweise eine Jupyter Notebook Codezelle." });

        /// <summary>
        /// Indicates, that an actor run some programming context. Typically a Jupyter Notebook Code Cell.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/verbs/run
        /// </summary>
        public readonly xAPI_Verb run = new xAPI_Verb(
            context: "projectJupyter",
            key: "run",
            names: new Dictionary<string, string> {
                ["en-US"] = "run",
                ["de-DE"] = "führte aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Indicates, that an actor run some programming context. Typically a Jupyter Notebook Code Cell.",
                ["de-DE"] = "Signalisiert, dass ein Akteur ein Programmierkonstrukt ausführte. Typischerweise eine Jupyter Notebook Codezelle." });

        public xAPI_Verbs_ProjectJupyter() 
            : base("projectJupyter") {
        }
    }
}