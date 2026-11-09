using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context gitanalysis of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_Gitanalysis : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_Gitanalysis() 
            : base("gitanalysis") {
        }

        /// <summary>
        /// The identifier of a commit, given as a hash. Can be used to find a certain commit in the repository.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/commitId
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis commitId(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commitId",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "commit id",
                        ["de-DE"] = "Commit-ID" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The identifier of a commit, given as a hash. Can be used to find a certain commit in the repository.",
                        ["de-DE"] = "Ein Hash zur eindeutigen Identifikation eines Commits. Hilfreich zur Suche bestimmter Commits im Repo." }),
                 value);
            return this;
        }

        /// <summary>
        /// The message describing the commit.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/commitMessage
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis commitMessage(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "commitMessage",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "commit message",
                        ["de-DE"] = "Commitnachricht" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The message describing the commit.",
                        ["de-DE"] = "Eine Nachricht, die den Inhalt eines Commits beschreibt." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of people assigned to the issue.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/issueAssignees
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis issueAssignees(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "issueAssignees",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "issue assignees",
                        ["de-DE"] = "Ticketbearbeiter" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of people assigned to the issue.",
                        ["de-DE"] = "Eine Liste zuständiger Personen, denen ein Ticket zugewiesen wurde." }),
                 value);
            return this;
        }

        /// <summary>
        /// A description of the issue.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/issueDescription
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis issueDescription(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "issueDescription",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "issue description",
                        ["de-DE"] = "Ticketbeschreibung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A description of the issue.",
                        ["de-DE"] = "Eine Beschreibung des Tickets." }),
                 value);
            return this;
        }

        /// <summary>
        /// The date the issue is or was due.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/issueDueDate
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis issueDueDate(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "issueDueDate",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "issue due date",
                        ["de-DE"] = "Ticket-Fälligkeitsdatum" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The date the issue is or was due.",
                        ["de-DE"] = "Das Datum an dem ein Ticket fällig ist oder war." }),
                 value);
            return this;
        }

        /// <summary>
        /// The name of the issue.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/issueName
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis issueName(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "issueName",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "issue name",
                        ["de-DE"] = "Ticketname" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The name of the issue.",
                        ["de-DE"] = "Der Name des Tickets." }),
                 value);
            return this;
        }

        /// <summary>
        /// The weight of the issue.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/issueWeight
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis issueWeight(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "issueWeight",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "issue weight",
                        ["de-DE"] = "Ticket-Gewichtung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The weight of the issue.",
                        ["de-DE"] = "Die Gewichtung des Tickets." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of people assigned to a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/mergeAssignees
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis mergeAssignees(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mergeAssignees",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "merge assignees",
                        ["de-DE"] = "Merge-Zuständige" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of people assigned to a merge request.",
                        ["de-DE"] = "Eine Liste zuständiger Personen, denen eine Merge-Anfrage zugewiesen wurde." }),
                 value);
            return this;
        }

        /// <summary>
        /// A description of a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/mergeDescription
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis mergeDescription(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mergeDescription",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "merge description",
                        ["de-DE"] = "Merge-Beschreibung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A description of a merge request.",
                        ["de-DE"] = "Eine Beschreibung der Merge-Anfrage." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of people set to review a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/mergeReviewers
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis mergeReviewers(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mergeReviewers",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "merge reviewers",
                        ["de-DE"] = "Merge-Prüfer" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of people set to review a merge request.",
                        ["de-DE"] = "Eine Liste der Personen, denen die Prüfung einer Merge-Anfrage zugewiesen wurde." }),
                 value);
            return this;
        }

        /// <summary>
        /// The title of a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/mergeTitle
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis mergeTitle(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "mergeTitle",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "merge title",
                        ["de-DE"] = "Merge-Titel" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The title of a merge request.",
                        ["de-DE"] = "Der Titel der Merge-Anfrage" }),
                 value);
            return this;
        }

        /// <summary>
        /// The reason a CI/CD pipeline was triggered.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/pipelineTrigger
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis pipelineTrigger(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "pipelineTrigger",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "pipeline trigger",
                        ["de-DE"] = "Pipeline-Auslöser" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The reason a CI/CD pipeline was triggered.",
                        ["de-DE"] = "Der Grund, der die Ausführung der CI/CD-Pipeline ausgelöst hat." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of commits contained in a push.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/pushCommitCount
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis pushCommitCount(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "pushCommitCount",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "commits count of push",
                        ["de-DE"] = "Anzahl Commits im Push" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of commits contained in a push.",
                        ["de-DE"] = "Die Anzahl der Commits in einem Push." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of identifiers for the commits, which are part of the push. Each ID points to a different commit, which have their own statements.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/pushContainedCommits
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis pushContainedCommits(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "pushContainedCommits",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "commits contained in push",
                        ["de-DE"] = "Commits im Push" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of identifiers for the commits, which are part of the push. Each ID points to a different commit, which have their own statements.",
                        ["de-DE"] = "Eine Liste der Commit-IDs der Commits, die im Push enthalten sind. Jede ID verweist auf einen anderen Commit, die in eigenen Statements zu finden sind." }),
                 value);
            return this;
        }

        /// <summary>
        /// The commit message of the commit, which is responsible for changes on a wiki page (including creation and deletion).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/wikiCommitMessage
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis wikiCommitMessage(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "wikiCommitMessage",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "wiki page commit message",
                        ["de-DE"] = "Wikiseiten-Commit-Nachricht" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The commit message of the commit, which is responsible for changes on a wiki page (including creation and deletion).",
                        ["de-DE"] = "Die Beschreibung eines Commits, der Änderungen an der Wikiseite des Repositories beinhaltet (einschließlich Erzeugung und Löschung." }),
                 value);
            return this;
        }

        /// <summary>
        /// The content of a wiki page.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/wikiContent
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis wikiContent(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "wikiContent",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "wiki page content",
                        ["de-DE"] = "Wikiseiteninhalt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The content of a wiki page.",
                        ["de-DE"] = "Der Inhalt einer Wikiseite." }),
                 value);
            return this;
        }

        /// <summary>
        /// The title of a wiki page.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/extensions/activity/wikiTitle
        /// </summary>
        public xAPI_Extensions_Activity_Gitanalysis wikiTitle(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "wikiTitle",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "wiki page title",
                        ["de-DE"] = "Wikiseitentitel" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The title of a wiki page.",
                        ["de-DE"] = "Der Titel einer Wikiseite." }),
                 value);
            return this;
        }
    }
}