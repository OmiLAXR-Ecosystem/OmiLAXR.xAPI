using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 14 items of the xAPI_Verbs of the context gitanalysis as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Gitanalysis : xAPI_Verbs {
        /// <summary>
        /// An actor added a tag.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/added
        /// </summary>
        public readonly xAPI_Verb added = new xAPI_Verb(
            context: "gitanalysis",
            key: "added",
            names: new Dictionary<string, string> {
                ["en-US"] = "added",
                ["de-DE"] = "fügte hinzu" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor added a tag.",
                ["de-DE"] = "Ein Akteur fügte ein Tag hinzu." });

        /// <summary>
        /// An actor approved a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/approved
        /// </summary>
        public readonly xAPI_Verb approved = new xAPI_Verb(
            context: "gitanalysis",
            key: "approved",
            names: new Dictionary<string, string> {
                ["en-US"] = "approved",
                ["de-DE"] = "genehmigte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor approved a merge request.",
                ["de-DE"] = "Ein Akteur genehmigte eine Merge-Anfrage." });

        /// <summary>
        /// An actor closed an issue or a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/closed
        /// </summary>
        public readonly xAPI_Verb closed = new xAPI_Verb(
            context: "gitanalysis",
            key: "closed",
            names: new Dictionary<string, string> {
                ["en-US"] = "closed",
                ["de-DE"] = "schloss" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor closed an issue or a merge request.",
                ["de-DE"] = "Ein Akteur schloss ein Ticket oder eine Merge-Anfrage." });

        /// <summary>
        /// An actor wrote a comment on a commit/issue/merge request
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/commentedOn
        /// </summary>
        public readonly xAPI_Verb commentedOn = new xAPI_Verb(
            context: "gitanalysis",
            key: "commentedOn",
            names: new Dictionary<string, string> {
                ["en-US"] = "commented on",
                ["de-DE"] = "kommentierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor wrote a comment on a commit/issue/merge request",
                ["de-DE"] = "Ein Akteur schrieb einen Kommentar zu einem Commit, Ticket oder einer Merge-Anfrage." });

        /// <summary>
        /// An actor created an object (e.g. commits or wiki pages).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/created
        /// </summary>
        public readonly xAPI_Verb created = new xAPI_Verb(
            context: "gitanalysis",
            key: "created",
            names: new Dictionary<string, string> {
                ["en-US"] = "created",
                ["de-DE"] = "erstellte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor created an object (e.g. commits or wiki pages).",
                ["de-DE"] = "Ein Akteur erstellte ein Objekt (z. B. Commit oder Wikiseite)." });

        /// <summary>
        /// An actor deleted an issue, a tag or a wiki page.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/deleted
        /// </summary>
        public readonly xAPI_Verb deleted = new xAPI_Verb(
            context: "gitanalysis",
            key: "deleted",
            names: new Dictionary<string, string> {
                ["en-US"] = "deleted",
                ["de-DE"] = "löschte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor deleted an issue, a tag or a wiki page.",
                ["de-DE"] = "Ein Akteur löschte ein Ticket, ein Tag oder eine Wikiseite." });

        /// <summary>
        /// An actor merged a branch to another branch during a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/merged
        /// </summary>
        public readonly xAPI_Verb merged = new xAPI_Verb(
            context: "gitanalysis",
            key: "merged",
            names: new Dictionary<string, string> {
                ["en-US"] = "merged",
                ["de-DE"] = "führte zusammen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor merged a branch to another branch during a merge request.",
                ["de-DE"] = "Ein Akteur führte in einer Merge-Anfrage einen Branch mit einem anderen zusammen." });

        /// <summary>
        /// An actor opened an issue or a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/opened
        /// </summary>
        public readonly xAPI_Verb opened = new xAPI_Verb(
            context: "gitanalysis",
            key: "opened",
            names: new Dictionary<string, string> {
                ["en-US"] = "opened",
                ["de-DE"] = "öffnete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor opened an issue or a merge request.",
                ["de-DE"] = "Ein Akteur öffnete ein Ticket oder eine Merge-Anfrage." });

        /// <summary>
        /// An actor pushed a number of changes to the repository.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/pushed
        /// </summary>
        public readonly xAPI_Verb pushed = new xAPI_Verb(
            context: "gitanalysis",
            key: "pushed",
            names: new Dictionary<string, string> {
                ["en-US"] = "pushed",
                ["de-DE"] = "pushte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor pushed a number of changes to the repository.",
                ["de-DE"] = "Ein Akteur pushte Veränderungen ins Repository." });

        /// <summary>
        /// An actor opened an issue or a merge request, which were previously closed.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/reopened
        /// </summary>
        public readonly xAPI_Verb reopened = new xAPI_Verb(
            context: "gitanalysis",
            key: "reopened",
            names: new Dictionary<string, string> {
                ["en-US"] = "reopened",
                ["de-DE"] = "wiedereröffnete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor opened an issue or a merge request, which were previously closed.",
                ["de-DE"] = "Ein Akteur öffnete ein Ticket oder eine Merge-Anfrage, die zuvor bereits geschlossen waren." });

        /// <summary>
        /// An actor triggered a pipeline with an activity.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/triggered
        /// </summary>
        public readonly xAPI_Verb triggered = new xAPI_Verb(
            context: "gitanalysis",
            key: "triggered",
            names: new Dictionary<string, string> {
                ["en-US"] = "triggered",
                ["de-DE"] = "löste aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor triggered a pipeline with an activity.",
                ["de-DE"] = "Ein Akteur löste durch eine Aktivität die Ausführung einer Pipeline aus." });

        /// <summary>
        /// An actor unapproved a merge request.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/unapproved
        /// </summary>
        public readonly xAPI_Verb unapproved = new xAPI_Verb(
            context: "gitanalysis",
            key: "unapproved",
            names: new Dictionary<string, string> {
                ["en-US"] = "unapproved",
                ["de-DE"] = "hob Genehmigung auf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor unapproved a merge request.",
                ["de-DE"] = "Ein Akteur hob die Genehmigung für eine Merge-Anfrage auf." });

        /// <summary>
        /// An actor updated an issue, a merge request or a wiki page.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/updated
        /// </summary>
        public readonly xAPI_Verb updated = new xAPI_Verb(
            context: "gitanalysis",
            key: "updated",
            names: new Dictionary<string, string> {
                ["en-US"] = "updated",
                ["de-DE"] = "aktualisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor updated an issue, a merge request or a wiki page.",
                ["de-DE"] = "Ein Akteur aktualisierte ein Ticket, eine Merge-Anfrage oder eine Wikiseite." });

        /// <summary>
        /// An actor wrote a wiki page.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gitanalysis/verbs/wrote
        /// </summary>
        public readonly xAPI_Verb wrote = new xAPI_Verb(
            context: "gitanalysis",
            key: "wrote",
            names: new Dictionary<string, string> {
                ["en-US"] = "wrote",
                ["de-DE"] = "schrieb" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor wrote a wiki page.",
                ["de-DE"] = "Ein Akteur schrieb eine Wikiseite." });

        public xAPI_Verbs_Gitanalysis() 
            : base("gitanalysis") {
        }
    }
}