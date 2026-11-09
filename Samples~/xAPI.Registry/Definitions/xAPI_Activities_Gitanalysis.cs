using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 6 items of the xAPI_Activities of the context gitanalysis as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Gitanalysis : xAPI_Activities {
        /// <summary>
        /// A collection of commits that are pushed to the repository.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities/changes
        /// </summary>
        public readonly xAPI_Activity changes = new xAPI_Activity(
            context: "gitanalysis",
            key: "changes",
            names: new Dictionary<string, string> {
                ["en-US"] = "changes",
                ["de-DE"] = "Änderungen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A collection of commits that are pushed to the repository.",
                ["de-DE"] = "Eine Sammlung von Änderungen am Repository." });

        /// <summary>
        /// A commit made by a user, which contains changes to the content of the repository.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities/commit
        /// </summary>
        public readonly xAPI_Activity commit = new xAPI_Activity(
            context: "gitanalysis",
            key: "commit",
            names: new Dictionary<string, string> {
                ["en-US"] = "commit",
                ["de-DE"] = "Commit" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A commit made by a user, which contains changes to the content of the repository.",
                ["de-DE"] = "Ein von einem User hinzugefügter Commit, der Änderungen am Inhalt des Repositories beinhaltet." });

        /// <summary>
        /// An issue used on GitLab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities/issue
        /// </summary>
        public readonly xAPI_Activity issue = new xAPI_Activity(
            context: "gitanalysis",
            key: "issue",
            names: new Dictionary<string, string> {
                ["en-US"] = "issue",
                ["de-DE"] = "Ticket" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An issue used on GitLab.",
                ["de-DE"] = "Ein Ticket auf GitLab." });

        /// <summary>
        /// A request made by an actor to merge content of one branch to another.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities/mergerequest
        /// </summary>
        public readonly xAPI_Activity mergerequest = new xAPI_Activity(
            context: "gitanalysis",
            key: "mergerequest",
            names: new Dictionary<string, string> {
                ["en-US"] = "Merge request",
                ["de-DE"] = "Merge-Anfrage" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A request made by an actor to merge content of one branch to another.",
                ["de-DE"] = "Eine Anfrage, den Inhalt eines Branches mit einem anderen zusammenzuführen." });

        /// <summary>
        /// A CI/CD pipeline, that was triggered in a GitLab repository.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities/pipeline
        /// </summary>
        public readonly xAPI_Activity pipeline = new xAPI_Activity(
            context: "gitanalysis",
            key: "pipeline",
            names: new Dictionary<string, string> {
                ["en-US"] = "Pipeline",
                ["de-DE"] = "Pipeline" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A CI/CD pipeline, that was triggered in a GitLab repository.",
                ["de-DE"] = "Eine CI/CD pipeline, die in einem GitLab repository ausgelöst wurde." });

        /// <summary>
        /// A wiki page in a repository.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/activities/wikipage
        /// </summary>
        public readonly xAPI_Activity wikipage = new xAPI_Activity(
            context: "gitanalysis",
            key: "wikipage",
            names: new Dictionary<string, string> {
                ["en-US"] = "wiki page",
                ["de-DE"] = "Wikiseite" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A wiki page in a repository.",
                ["de-DE"] = "Eine Wikiseite in einem Repository." });

        public xAPI_Activities_Gitanalysis() 
            : base("gitanalysis") {
        }
    }
}