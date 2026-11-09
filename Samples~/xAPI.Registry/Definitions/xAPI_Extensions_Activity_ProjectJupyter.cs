using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context projectJupyter of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_ProjectJupyter : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_ProjectJupyter() 
            : base("projectJupyter") {
        }

        /// <summary>
        /// The content of an Activity. In case of a file, it is the file content, in case of a Notebook cell the content is the code/text inside a notebook cell.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/activity/content
        /// </summary>
        public xAPI_Extensions_Activity_ProjectJupyter content(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "content",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "content",
                        ["de-DE"] = "Inhalt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The content of an Activity. In case of a file, it is the file content, in case of a Notebook cell the content is the code/text inside a notebook cell.",
                        ["de-DE"] = "Der Inhalt einer Aktivität. Im Falle einer Datei ist der Inhalt der Dateiinhalt, im Falle einer Notebookzelle ist der Inhalt der Programmcode oder Text innerhalb einer Zelle." }),
                 value);
            return this;
        }

        /// <summary>
        /// The name of a Jupyter Kernels. E.g. 'Python 3.7'. A list of kernels is available at https://github.com/jupyter/jupyter/wiki/Jupyter-kernels.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/activity/kernelName
        /// </summary>
        public xAPI_Extensions_Activity_ProjectJupyter kernelName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "kernelName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "kernel name",
                        ["de-DE"] = "Kernelname" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The name of a Jupyter Kernels. E.g. 'Python 3.7'. A list of kernels is available at https://github.com/jupyter/jupyter/wiki/Jupyter-kernels.",
                        ["de-DE"] = "Der Name eines Jupyter Kernels. Z.b. 'Python 3.7. Eine Liste mit Kerneln ist unter https://github.com/jupyter/jupyter/wiki/Jupyter-kernels einsehbar." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of words used to describe or groupe activities.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/projectJupyter/extensions/activity/tags
        /// </summary>
        public xAPI_Extensions_Activity_ProjectJupyter tags(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "tags",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "tags",
                        ["de-DE"] = "Etikett" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of words used to describe or groupe activities.",
                        ["de-DE"] = "Eine Liste mit von Wörtern mit denen eine Aktivität beschrieben wird oder mit denen mehrere Aktivitäten gruppiert werden können." }),
                 value);
            return this;
        }
    }
}