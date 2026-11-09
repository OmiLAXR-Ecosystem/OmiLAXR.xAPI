using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context gitanalysis of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_Gitanalysis : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_Gitanalysis() 
            : base("gitanalysis") {
        }

        /// <summary>
        /// The content of a comment (text, link, picture, etc.).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/commentContent
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis commentContent(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commentContent",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "comment content",
                        ["de-DE"] = "Kommentarinhalt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The content of a comment (text, link, picture, etc.).",
                        ["de-DE"] = "Der Inhalt eines Kommentares." }),
                 value);
            return this;
        }

        /// <summary>
        /// The link to the comment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/commentUrl
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis commentUrl(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commentUrl",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "comment url",
                        ["de-DE"] = "Kommentaradresse" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The link to the comment.",
                        ["de-DE"] = "Der Link zum Kommentar." }),
                 value);
            return this;
        }

        /// <summary>
        /// The names of the files, which were added in a commit.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/commitAddedFiles
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis commitAddedFiles(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commitAddedFiles",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "added files",
                        ["de-DE"] = "Hinzugefügte Dateien" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The names of the files, which were added in a commit.",
                        ["de-DE"] = "Die Namen der Dateien, die im Commit hinzugefügt wurden." }),
                 value);
            return this;
        }

        /// <summary>
        /// The names of the files, which were modified in a commit.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/commitModifiedFiles
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis commitModifiedFiles(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commitModifiedFiles",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "modified files",
                        ["de-DE"] = "Geänderte Dateien" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The names of the files, which were modified in a commit.",
                        ["de-DE"] = "Die Namen der Dateien, die im Commit verändert wurden." }),
                 value);
            return this;
        }

        /// <summary>
        /// The names of the files, which were removed in a commit.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/commitRemovedFiles
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis commitRemovedFiles(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commitRemovedFiles",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "removed files",
                        ["de-DE"] = "Gelöschte Dateien" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The names of the files, which were removed in a commit.",
                        ["de-DE"] = "Die Namen der Dateien, die im Commit gelöscht wurden." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of changes made when an issue was updated. Contains old and new value for each change.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/issueChanges
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis issueChanges(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "issueChanges",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "issue changes",
                        ["de-DE"] = "Ticket-Änderungen" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of changes made when an issue was updated. Contains old and new value for each change.",
                        ["de-DE"] = "Eine Liste der Änderungen, wenn ein Ticket verändert wurde. Beinhaltet die alten und neuen Werte." }),
                 value);
            return this;
        }

        /// <summary>
        /// A label that can be given to issues and merge requests.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/label
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis label(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "label",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "label",
                        ["de-DE"] = "Label" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A label that can be given to issues and merge requests.",
                        ["de-DE"] = "Ein Label, das Issues und Merge-Anfragen zugewiesen werden kann." }),
                 value);
            return this;
        }

        /// <summary>
        /// The status of a merge (unapproved/approved/ready to merge).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/mergeStatus
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis mergeStatus(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mergeStatus",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "merge status",
                        ["de-DE"] = "Merge-Status" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The status of a merge (unapproved/approved/ready to merge).",
                        ["de-DE"] = "Der Status einer Merge-Anfrage (abgelehnt, zugestimmt, bereit zum Zusammenführen)." }),
                 value);
            return this;
        }

        /// <summary>
        /// A description of the tag.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/tagDescription
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis tagDescription(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "tagDescription",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "tag description",
                        ["de-DE"] = "Tag-Beschreibung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A description of the tag.",
                        ["de-DE"] = "Eine Beschreibung des Tags." }),
                 value);
            return this;
        }

        /// <summary>
        /// The name of the tag.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/result/tagName
        /// </summary>
        public xAPI_Extensions_Result_Gitanalysis tagName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "tagName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "tag name",
                        ["de-DE"] = "Tag-Name" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The name of the tag.",
                        ["de-DE"] = "Der Name des Tags." }),
                 value);
            return this;
        }
    }
}