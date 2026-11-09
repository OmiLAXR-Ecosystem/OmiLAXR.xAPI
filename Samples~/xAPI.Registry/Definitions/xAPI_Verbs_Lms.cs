using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 47 items of the xAPI_Verbs of the context lms as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Lms : xAPI_Verbs {
        /// <summary>
        /// Actor accessed a page, file, video, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/accessed
        /// </summary>
        public readonly xAPI_Verb accessed = new xAPI_Verb(
            context: "lms",
            key: "accessed",
            names: new Dictionary<string, string> {
                ["en-US"] = "accessed",
                ["de-DE"] = "griff zu auf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor accessed a page, file, video, ...",
                ["de-DE"] = "Akteur hat auf eine Seite, eine Datei, ein Video, ... zugegriffen" });

        /// <summary>
        /// Actor added an object/person to a collection
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/added
        /// </summary>
        public readonly xAPI_Verb added = new xAPI_Verb(
            context: "lms",
            key: "added",
            names: new Dictionary<string, string> {
                ["en-US"] = "added",
                ["de-DE"] = "fügte hinzu" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor added an object/person to a collection",
                ["de-DE"] = "Akteur hat eine/n Person/Gegenstand zu einer Sammlung hinzugefügt" });

        /// <summary>
        /// An Actor gave an answer to a question.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/answered
        /// </summary>
        public readonly xAPI_Verb answered = new xAPI_Verb(
            context: "lms",
            key: "answered",
            names: new Dictionary<string, string> {
                ["en-US"] = "answered",
                ["de-DE"] = "beantwortete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An Actor gave an answer to a question.",
                ["de-DE"] = "Ein Akteur hat eine Antwort auf eine Frage gegeben." });

        /// <summary>
        /// Actor approved an object (in Moodle "learning plan")
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/approved
        /// </summary>
        public readonly xAPI_Verb approved = new xAPI_Verb(
            context: "lms",
            key: "approved",
            names: new Dictionary<string, string> {
                ["en-US"] = "approved",
                ["de-DE"] = "genehmigte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor approved an object (in Moodle \"learning plan\")",
                ["de-DE"] = "Akteur genehmigte ein Objekt (in Moodle \"Lernplan\")" });

        /// <summary>
        /// Actor assigned an object/task/activity to someone
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/assigned
        /// </summary>
        public readonly xAPI_Verb assigned = new xAPI_Verb(
            context: "lms",
            key: "assigned",
            names: new Dictionary<string, string> {
                ["en-US"] = "assigned",
                ["de-DE"] = "teilte zu" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor assigned an object/task/activity to someone",
                ["de-DE"] = "Akteur wurde ein/e Objekt/Aufgabe/Aktivität zugeteilt" });

        /// <summary>
        /// Actor blocked a person
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/blocked
        /// </summary>
        public readonly xAPI_Verb blocked = new xAPI_Verb(
            context: "lms",
            key: "blocked",
            names: new Dictionary<string, string> {
                ["en-US"] = "blocked",
                ["de-DE"] = "sperrte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor blocked a person",
                ["de-DE"] = "Akteur hat eine Person gesperrt" });

        /// <summary>
        /// Actor cancelled an activity, a meeting
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/cancelled
        /// </summary>
        public readonly xAPI_Verb cancelled = new xAPI_Verb(
            context: "lms",
            key: "cancelled",
            names: new Dictionary<string, string> {
                ["en-US"] = "cancelled",
                ["de-DE"] = "sagte ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor cancelled an activity, a meeting",
                ["de-DE"] = "Akteur hat eine Aktivität, ein Meeting abgesagt" });

        /// <summary>
        /// Actor closed an object (i.e. forum thread)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/closed
        /// </summary>
        public readonly xAPI_Verb closed = new xAPI_Verb(
            context: "lms",
            key: "closed",
            names: new Dictionary<string, string> {
                ["en-US"] = "closed",
                ["de-DE"] = "schloss" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor closed an object (i.e. forum thread)",
                ["de-DE"] = "Akteur hat ein Objekt (z. B. Forumsdiskussion) geschlossen" });

        /// <summary>
        /// Actor completed an activity/task
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/completed
        /// </summary>
        public readonly xAPI_Verb completed = new xAPI_Verb(
            context: "lms",
            key: "completed",
            names: new Dictionary<string, string> {
                ["en-US"] = "completed",
                ["de-DE"] = "stellte fertig" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor completed an activity/task",
                ["de-DE"] = "Akteur hat eine Aktivität/Aufgabe fertiggestellt" });

        /// <summary>
        /// Actor created an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/created
        /// </summary>
        public readonly xAPI_Verb created = new xAPI_Verb(
            context: "lms",
            key: "created",
            names: new Dictionary<string, string> {
                ["en-US"] = "created",
                ["de-DE"] = "erstellte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor created an object",
                ["de-DE"] = "Akteur hat ein Objekt erstellt" });

        /// <summary>
        /// Actor deleted an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/deleted
        /// </summary>
        public readonly xAPI_Verb deleted = new xAPI_Verb(
            context: "lms",
            key: "deleted",
            names: new Dictionary<string, string> {
                ["en-US"] = "deleted",
                ["de-DE"] = "löschte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor deleted an object",
                ["de-DE"] = "Akteur hat ein Objekt gelöscht" });

        /// <summary>
        /// Actor downloaded an object (e. g. a PDF file)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/downloaded
        /// </summary>
        public readonly xAPI_Verb downloaded = new xAPI_Verb(
            context: "lms",
            key: "downloaded",
            names: new Dictionary<string, string> {
                ["en-US"] = "downloaded",
                ["de-DE"] = "lud herunter" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor downloaded an object (e. g. a PDF file)",
                ["de-DE"] = "Akteur hat ein Objekt (z. B. eine PDF Datei) heruntergeladen" });

        /// <summary>
        /// Actor exported an object/data
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/exported
        /// </summary>
        public readonly xAPI_Verb exported = new xAPI_Verb(
            context: "lms",
            key: "exported",
            names: new Dictionary<string, string> {
                ["en-US"] = "exported",
                ["de-DE"] = "exportierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor exported an object/data",
                ["de-DE"] = "Akteur hat ein Objekt/Daten exportiert" });

        /// <summary>
        /// Actor failed an activity (quiz attempt, upload, log in)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/failed
        /// </summary>
        public readonly xAPI_Verb failed = new xAPI_Verb(
            context: "lms",
            key: "failed",
            names: new Dictionary<string, string> {
                ["en-US"] = "failed",
                ["de-DE"] = "scheiterte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor failed an activity (quiz attempt, upload, log in)",
                ["de-DE"] = "Akteur scheiterte an einer Aktivität (Quizversuch, Upload, Einloggen)" });

        /// <summary>
        /// Actor rated an object/person
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/graded
        /// </summary>
        public readonly xAPI_Verb graded = new xAPI_Verb(
            context: "lms",
            key: "graded",
            names: new Dictionary<string, string> {
                ["en-US"] = "graded",
                ["de-DE"] = "benotete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor rated an object/person",
                ["de-DE"] = "Akteur hat ein/e Objekt/Person benotet" });

        /// <summary>
        /// Actor hid an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/hid
        /// </summary>
        public readonly xAPI_Verb hid = new xAPI_Verb(
            context: "lms",
            key: "hid",
            names: new Dictionary<string, string> {
                ["en-US"] = "hid",
                ["de-DE"] = "blendete aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor hid an object",
                ["de-DE"] = "Akteur hat ein Objekt ausgeblendet" });

        /// <summary>
        /// Actor imported an object/data
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/imported
        /// </summary>
        public readonly xAPI_Verb imported = new xAPI_Verb(
            context: "lms",
            key: "imported",
            names: new Dictionary<string, string> {
                ["en-US"] = "imported",
                ["de-DE"] = "importierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor imported an object/data",
                ["de-DE"] = "Akteur hat ein Objekt/Daten importiert" });

        /// <summary>
        /// An Actor did not gave an answer to a question. Might occur in quizzes if a question is left open.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/leftUnanswered
        /// </summary>
        public readonly xAPI_Verb leftUnanswered = new xAPI_Verb(
            context: "lms",
            key: "leftUnanswered",
            names: new Dictionary<string, string> {
                ["en-US"] = "left unanswered",
                ["de-DE"] = "ließ unbeantwortet" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An Actor did not gave an answer to a question. Might occur in quizzes if a question is left open.",
                ["de-DE"] = "Ein Akteur hat keine Antwort auf eine Frage gegeben. Kann z. B. in Tests auftreten, wenn das Antwortfeld einer Frage leer ist." });

        /// <summary>
        /// Actor linked an object/person to an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/linked
        /// </summary>
        public readonly xAPI_Verb linked = new xAPI_Verb(
            context: "lms",
            key: "linked",
            names: new Dictionary<string, string> {
                ["en-US"] = "linked",
                ["de-DE"] = "verknüpfte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor linked an object/person to an object",
                ["de-DE"] = "Akteur hat ein/e Objekt/Person mit einem Objekt verknüpft" });

        /// <summary>
        /// Actor locked an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/locked
        /// </summary>
        public readonly xAPI_Verb locked = new xAPI_Verb(
            context: "lms",
            key: "locked",
            names: new Dictionary<string, string> {
                ["en-US"] = "locked",
                ["de-DE"] = "sperrte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor locked an object",
                ["de-DE"] = "Akteur hat ein Objekt gesperrt" });

        /// <summary>
        /// Actor logged in (as him-/herself)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/loggedIn
        /// </summary>
        public readonly xAPI_Verb loggedIn = new xAPI_Verb(
            context: "lms",
            key: "loggedIn",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged in",
                ["de-DE"] = "meldete sich an" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor logged in (as him-/herself)",
                ["de-DE"] = "Akteur hat sich angemeldet (als er/sie selbst)" });

        /// <summary>
        /// Actor logged in as another person
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/loggedInAs
        /// </summary>
        public readonly xAPI_Verb loggedInAs = new xAPI_Verb(
            context: "lms",
            key: "loggedInAs",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged in as",
                ["de-DE"] = "meldete sich an als" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor logged in as another person",
                ["de-DE"] = "Akteur hat sich als eine andere Person angemeldet" });

        /// <summary>
        /// Actor logged out
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/loggedOut
        /// </summary>
        public readonly xAPI_Verb loggedOut = new xAPI_Verb(
            context: "lms",
            key: "loggedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged out",
                ["de-DE"] = "meldete ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor logged out",
                ["de-DE"] = "Akteur hat sich abgemeldet" });

        /// <summary>
        /// Actor moved an object/person from one group/area to another
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/moved
        /// </summary>
        public readonly xAPI_Verb moved = new xAPI_Verb(
            context: "lms",
            key: "moved",
            names: new Dictionary<string, string> {
                ["en-US"] = "moved",
                ["de-DE"] = "bewegte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor moved an object/person from one group/area to another",
                ["de-DE"] = "Akteuer hat ein/e Objekt/Person von einer Gruppe/Region in eine andere bewegt" });

        /// <summary>
        /// Actor paused an activity
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/paused
        /// </summary>
        public readonly xAPI_Verb paused = new xAPI_Verb(
            context: "lms",
            key: "paused",
            names: new Dictionary<string, string> {
                ["en-US"] = "paused",
                ["de-DE"] = "pausierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor paused an activity",
                ["de-DE"] = "Akteur pausierte eine Aktivität" });

        /// <summary>
        /// Actor changed the grading of an object/person.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/regraded
        /// </summary>
        public readonly xAPI_Verb regraded = new xAPI_Verb(
            context: "lms",
            key: "regraded",
            names: new Dictionary<string, string> {
                ["en-US"] = "regraded",
                ["de-DE"] = "benotete neu" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor changed the grading of an object/person.",
                ["de-DE"] = "Akteur hat ein/e Objekt/Person neu benotet. Eine bestehende Bewertung wurde geändert." });

        /// <summary>
        /// Actor removed an object/person from a collection
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/removed
        /// </summary>
        public readonly xAPI_Verb removed = new xAPI_Verb(
            context: "lms",
            key: "removed",
            names: new Dictionary<string, string> {
                ["en-US"] = "removed",
                ["de-DE"] = "entfernte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor removed an object/person from a collection",
                ["de-DE"] = "Akteur hat ein/e Objekt/Person von einer Sammlung entfernt" });

        /// <summary>
        /// Actor reopened an activity (assignment submission, forum)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/reopened
        /// </summary>
        public readonly xAPI_Verb reopened = new xAPI_Verb(
            context: "lms",
            key: "reopened",
            names: new Dictionary<string, string> {
                ["en-US"] = "reopened",
                ["de-DE"] = "wiedereröffnete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor reopened an activity (assignment submission, forum)",
                ["de-DE"] = "Akteuer hat eine Aktivität (Aufgabenabgabe, Forum) wiedereröffnet" });

        /// <summary>
        /// Actor replaced an object/person
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/replaced
        /// </summary>
        public readonly xAPI_Verb replaced = new xAPI_Verb(
            context: "lms",
            key: "replaced",
            names: new Dictionary<string, string> {
                ["en-US"] = "replaced",
                ["de-DE"] = "ersetzte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor replaced an object/person",
                ["de-DE"] = "Akteur hat ein/e Objekt/Person ersetzt" });

        /// <summary>
        /// Actor requested an object/access/information
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/requested
        /// </summary>
        public readonly xAPI_Verb requested = new xAPI_Verb(
            context: "lms",
            key: "requested",
            names: new Dictionary<string, string> {
                ["en-US"] = "requested",
                ["de-DE"] = "forderte an" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor requested an object/access/information",
                ["de-DE"] = "Akteur hat ein/en Objekt/Zugang/Informationen angefordert" });

        /// <summary>
        /// Actor resetted an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/resetted
        /// </summary>
        public readonly xAPI_Verb resetted = new xAPI_Verb(
            context: "lms",
            key: "resetted",
            names: new Dictionary<string, string> {
                ["en-US"] = "resetted",
                ["de-DE"] = "setzte zurück" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor resetted an object",
                ["de-DE"] = "Akteur hat ein Objekt zurückgesetzt" });

        /// <summary>
        /// Actor restored a previous version of an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/restored
        /// </summary>
        public readonly xAPI_Verb restored = new xAPI_Verb(
            context: "lms",
            key: "restored",
            names: new Dictionary<string, string> {
                ["en-US"] = "restored",
                ["de-DE"] = "stellte wieder her" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor restored a previous version of an object",
                ["de-DE"] = "Akteur hat eine vorherige Version eines Objektes wiederhergestellt" });

        /// <summary>
        /// Actor resumed a previously paused activity
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/resumed
        /// </summary>
        public readonly xAPI_Verb resumed = new xAPI_Verb(
            context: "lms",
            key: "resumed",
            names: new Dictionary<string, string> {
                ["en-US"] = "resumed",
                ["de-DE"] = "nahm wieder auf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor resumed a previously paused activity",
                ["de-DE"] = "Akteur nahm eine zuvor pausierte Aktivität wieder auf" });

        /// <summary>
        /// Actor reviewed an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/reviewed
        /// </summary>
        public readonly xAPI_Verb reviewed = new xAPI_Verb(
            context: "lms",
            key: "reviewed",
            names: new Dictionary<string, string> {
                ["en-US"] = "reviewed",
                ["de-DE"] = "prüfte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor reviewed an object",
                ["de-DE"] = "Akteur hat ein Objekt geprüft" });

        /// <summary>
        /// Actor searched for something
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/searched
        /// </summary>
        public readonly xAPI_Verb searched = new xAPI_Verb(
            context: "lms",
            key: "searched",
            names: new Dictionary<string, string> {
                ["en-US"] = "searched",
                ["de-DE"] = "suchte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor searched for something",
                ["de-DE"] = "Akteur hat nach etwas gesucht" });

        /// <summary>
        /// Actor sent a message to a person/group
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/sent
        /// </summary>
        public readonly xAPI_Verb sent = new xAPI_Verb(
            context: "lms",
            key: "sent",
            names: new Dictionary<string, string> {
                ["en-US"] = "sent",
                ["de-DE"] = "sendete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor sent a message to a person/group",
                ["de-DE"] = "Akteur hat eine Nachricht zu einer Person/Gruppe gesendet" });

        /// <summary>
        /// Actor started an activity
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "lms",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started",
                ["de-DE"] = "startete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor started an activity",
                ["de-DE"] = "Akteur hat eine Aktivität gestartet" });

        /// <summary>
        /// Actor stopped an activity/process
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/stopped
        /// </summary>
        public readonly xAPI_Verb stopped = new xAPI_Verb(
            context: "lms",
            key: "stopped",
            names: new Dictionary<string, string> {
                ["en-US"] = "stopped",
                ["de-DE"] = "stoppte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor stopped an activity/process",
                ["de-DE"] = "Akteur hat eine/n Aktivität/Prozess gestoppt" });

        /// <summary>
        /// Actor submitted a quiz, assignment, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/submitted
        /// </summary>
        public readonly xAPI_Verb submitted = new xAPI_Verb(
            context: "lms",
            key: "submitted",
            names: new Dictionary<string, string> {
                ["en-US"] = "submitted",
                ["de-DE"] = "gab ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor submitted a quiz, assignment, ...",
                ["de-DE"] = "Akteur hat ein Quiz, eine Abgabe, ... abgegeben." });

        /// <summary>
        /// Actor succeeded an activity
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/succeeded
        /// </summary>
        public readonly xAPI_Verb succeeded = new xAPI_Verb(
            context: "lms",
            key: "succeeded",
            names: new Dictionary<string, string> {
                ["en-US"] = "succeeded",
                ["de-DE"] = "gelang" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor succeeded an activity",
                ["de-DE"] = "Akteur ist eine Aktivität gelungen" });

        /// <summary>
        /// Actor triggered a process
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/triggered
        /// </summary>
        public readonly xAPI_Verb triggered = new xAPI_Verb(
            context: "lms",
            key: "triggered",
            names: new Dictionary<string, string> {
                ["en-US"] = "triggered",
                ["de-DE"] = "löste aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor triggered a process",
                ["de-DE"] = "Akteur hat einen Prozess ausgelöst" });

        /// <summary>
        /// Actor unapproved an object (in Moodle "learning plan")
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/unapproved
        /// </summary>
        public readonly xAPI_Verb unapproved = new xAPI_Verb(
            context: "lms",
            key: "unapproved",
            names: new Dictionary<string, string> {
                ["en-US"] = "unapproved",
                ["de-DE"] = "genehmigte nicht" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor unapproved an object (in Moodle \"learning plan\")",
                ["de-DE"] = "Akteur hat ein Objekt (in Moodle \"learning plan\") nicht genehmigt" });

        /// <summary>
        /// Actor unblocked a blocked person
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/unblocked
        /// </summary>
        public readonly xAPI_Verb unblocked = new xAPI_Verb(
            context: "lms",
            key: "unblocked",
            names: new Dictionary<string, string> {
                ["en-US"] = "unblocked",
                ["de-DE"] = "entblockte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor unblocked a blocked person",
                ["de-DE"] = "Akteur hat eine blockierte Person entblockt" });

        /// <summary>
        /// Actor unlinked an object/person from an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/unlinked
        /// </summary>
        public readonly xAPI_Verb unlinked = new xAPI_Verb(
            context: "lms",
            key: "unlinked",
            names: new Dictionary<string, string> {
                ["en-US"] = "unlinked",
                ["de-DE"] = "trennte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor unlinked an object/person from an object",
                ["de-DE"] = "Akteur hat ein/e Objekt/Person von einem Objekt getrennt" });

        /// <summary>
        /// Actor unlocked an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/unlocked
        /// </summary>
        public readonly xAPI_Verb unlocked = new xAPI_Verb(
            context: "lms",
            key: "unlocked",
            names: new Dictionary<string, string> {
                ["en-US"] = "unlocked",
                ["de-DE"] = "gab frei" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor unlocked an object",
                ["de-DE"] = "Akteur hat ein Objekt freigegeben" });

        /// <summary>
        /// Actor updated the content of an object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/updated
        /// </summary>
        public readonly xAPI_Verb updated = new xAPI_Verb(
            context: "lms",
            key: "updated",
            names: new Dictionary<string, string> {
                ["en-US"] = "updated",
                ["de-DE"] = "aktualisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor updated the content of an object",
                ["de-DE"] = "Akteur aktualisierte den Inhalt eines Objekts." });

        /// <summary>
        /// Actor removed the assignment of an object/task/activity to someone
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/verbs/withdrew
        /// </summary>
        public readonly xAPI_Verb withdrew = new xAPI_Verb(
            context: "lms",
            key: "withdrew",
            names: new Dictionary<string, string> {
                ["en-US"] = "withdrew",
                ["de-DE"] = "zog zurück" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor removed the assignment of an object/task/activity to someone",
                ["de-DE"] = "Akteur hat die Zuteilung eines/r Objektes/Aufgabe/Aktivität zurückgezogen" });

        public xAPI_Verbs_Lms() 
            : base("lms") {
        }
    }
}