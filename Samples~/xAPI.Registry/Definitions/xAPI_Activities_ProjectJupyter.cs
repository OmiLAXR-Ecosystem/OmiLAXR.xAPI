using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 5 items of the xAPI_Activities of the context projectJupyter as public properties.
    /// </summary>
    public sealed class xAPI_Activities_ProjectJupyter : xAPI_Activities {
        /// <summary>
        /// A Jupyter Notebook Cell of type 'code cell'. Code Cells store programming code, that can be executed by a user. Code within a Code Cell is typically conceptually coherent.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/activities/codeCell
        /// </summary>
        public readonly xAPI_Activity codeCell = new xAPI_Activity(
            context: "projectJupyter",
            key: "codeCell",
            names: new Dictionary<string, string> {
                ["en-US"] = "Code Cell",
                ["de-DE"] = "Codezelle" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A Jupyter Notebook Cell of type 'code cell'. Code Cells store programming code, that can be executed by a user. Code within a Code Cell is typically conceptually coherent.",
                ["de-DE"] = "Eine Jupyter Notebook Zelle mit dem Typ 'code cell'. Codezellen enthalten programmier code, welcher von einem user ausgeführt werden kann. Der Code einer Zelle ist meist konzeptionell zusammenhängend." });

        /// <summary>
        /// A web-based user interface for Project Jupyter. See https://jupyterlab.readthedocs.io
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/activities/jupyterLab
        /// </summary>
        public readonly xAPI_Activity jupyterLab = new xAPI_Activity(
            context: "projectJupyter",
            key: "jupyterLab",
            names: new Dictionary<string, string> {
                ["en-US"] = "JupyterLab",
                ["de-DE"] = "JupyterLab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A web-based user interface for Project Jupyter. See https://jupyterlab.readthedocs.io",
                ["de-DE"] = "Ein webbasiertes Benutzerinterface für Project Jupyter. Mehr informationen hier: https://jupyterlab.readthedocs.io" });

        /// <summary>
        /// This activity refers to Jupyter Notebook Document (the document type), in contrast to the Jupyter Notebook (a document editor). Notebook documents are json-files ending in '.ipynb'. 
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/activities/jupyterNotebook
        /// </summary>
        public readonly xAPI_Activity jupyterNotebook = new xAPI_Activity(
            context: "projectJupyter",
            key: "jupyterNotebook",
            names: new Dictionary<string, string> {
                ["en-US"] = "Jupyter Notebook Document",
                ["de-DE"] = "Jupyter Notebook Dokument" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "This activity refers to Jupyter Notebook Document (the document type), in contrast to the Jupyter Notebook (a document editor). Notebook documents are json-files ending in '.ipynb'. ",
                ["de-DE"] = "Diese Aktivität bezieht sich auf das Jupyter Notebook Dokument (den Dateityp), im Gegensatz zu dem Jupyter Notebook (einem Dateieditor). Dokumente eines Notebooks sind json-files mit einer '.ipynb' endung." });

        /// <summary>
        /// A Jupyter Notebook Cell of type 'markdown cell'. Markdonw Cells store markdown formatted text. The text is meant to be read by a user.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/activities/markdownCell
        /// </summary>
        public readonly xAPI_Activity markdownCell = new xAPI_Activity(
            context: "projectJupyter",
            key: "markdownCell",
            names: new Dictionary<string, string> {
                ["en-US"] = "Markdown Cell",
                ["de-DE"] = "Markdownzelle" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A Jupyter Notebook Cell of type 'markdown cell'. Markdonw Cells store markdown formatted text. The text is meant to be read by a user.",
                ["de-DE"] = "Eine Jupyter Notebook Zelle mit dem Typ 'markdown cell'. Markdownzellen enthalten Markdown formatierten Text. Der Text einer Markdownzelle ist bestimmt um von einem Benutzer gelesen zu werden." });

        /// <summary>
        /// A Jupyter Notebook Cell of type 'raw cell'. Raw Cells provide storage options for data other than programming code and markdown text. They can contain any type of data.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/activities/rawCell
        /// </summary>
        public readonly xAPI_Activity rawCell = new xAPI_Activity(
            context: "projectJupyter",
            key: "rawCell",
            names: new Dictionary<string, string> {
                ["en-US"] = "Raw Cell",
                ["de-DE"] = "Raw Cell" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A Jupyter Notebook Cell of type 'raw cell'. Raw Cells provide storage options for data other than programming code and markdown text. They can contain any type of data.",
                ["de-DE"] = "Eine Jupyter Notebook Zelle mit dem Typ 'raw cell'. Raw Cells bieten die Möglichkeit daten zu speichern, welche weder programmier code noch markdown text sind. Sie können alle arten von daten enthalten" });

        public xAPI_Activities_ProjectJupyter() 
            : base("projectJupyter") {
        }
    }
}