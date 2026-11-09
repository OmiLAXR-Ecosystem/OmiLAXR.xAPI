using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 35 items of the xAPI_Activities of the context lms as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Lms : xAPI_Activities {
        /// <summary>
        /// An assignment object. Provides the students with a task description and further needed materials and allows to upload a submission.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/assign
        /// </summary>
        public readonly xAPI_Activity assign = new xAPI_Activity(
            context: "lms",
            key: "assign",
            names: new Dictionary<string, string> {
                ["en-US"] = "Assignment",
                ["de-DE"] = "Aufgabe" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An assignment object. Provides the students with a task description and further needed materials and allows to upload a submission.",
                ["de-DE"] = "Eine Aufgabe. Gibt eine Aufgabenstellung vor und weiteres benötigtes Material und ermöglicht das Hochladen einer Abgabe." });

        /// <summary>
        /// A book, containing multiple texts and images, structured as chapters.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/book
        /// </summary>
        public readonly xAPI_Activity book = new xAPI_Activity(
            context: "lms",
            key: "book",
            names: new Dictionary<string, string> {
                ["en-US"] = "Book",
                ["de-DE"] = "Buch" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A book, containing multiple texts and images, structured as chapters.",
                ["de-DE"] = "Ein Buch welches Texte und Bilder in einzelnen Kapiteln darstellt." });

        /// <summary>
        /// A chapter of a book.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/book_chapter
        /// </summary>
        public readonly xAPI_Activity book_chapter = new xAPI_Activity(
            context: "lms",
            key: "book_chapter",
            names: new Dictionary<string, string> {
                ["en-US"] = "Book Chapter",
                ["de-DE"] = "Buchkapitel" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A chapter of a book.",
                ["de-DE"] = "Ein Kapitel in einem Buch." });

        /// <summary>
        /// A chat to communicate with others.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/chat
        /// </summary>
        public readonly xAPI_Activity chat = new xAPI_Activity(
            context: "lms",
            key: "chat",
            names: new Dictionary<string, string> {
                ["en-US"] = "Chat",
                ["de-DE"] = "Chat" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A chat to communicate with others.",
                ["de-DE"] = "Ein Chat um mit anderen zu kommunizieren." });

        /// <summary>
        /// An activity to present course participants a list of pre-defined answers to choose from.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/choice
        /// </summary>
        public readonly xAPI_Activity choice = new xAPI_Activity(
            context: "lms",
            key: "choice",
            names: new Dictionary<string, string> {
                ["en-US"] = "Choice",
                ["de-DE"] = "Abstimmung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An activity to present course participants a list of pre-defined answers to choose from.",
                ["de-DE"] = "Aktivität um Kursteilnehmenden eine Liste vorgegebener Antwortmöglichkeiten zur Abstimmung zu stellen." });

        /// <summary>
        /// Interactions of a user within an LMS client (like a browser tab), e.g., key strokes, mouse movements or clicks, touches.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/clientSideInteraction
        /// </summary>
        public readonly xAPI_Activity clientSideInteraction = new xAPI_Activity(
            context: "lms",
            key: "clientSideInteraction",
            names: new Dictionary<string, string> {
                ["en-US"] = "Client Side Interaction",
                ["de-DE"] = "Clientseitige Interaktionen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Interactions of a user within an LMS client (like a browser tab), e.g., key strokes, mouse movements or clicks, touches.",
                ["de-DE"] = "Nutzerinterationen in einem LMS Client (wie einem Browsertab), z. B. Tastatureingaben, Mausbewegungen oder Klicks, Toucheingaben." });

        /// <summary>
        /// The client's view on the LMS, usually a tab in a browser.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/clientView
        /// </summary>
        public readonly xAPI_Activity clientView = new xAPI_Activity(
            context: "lms",
            key: "clientView",
            names: new Dictionary<string, string> {
                ["en-US"] = "Client View",
                ["de-DE"] = "Client Ansicht" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The client's view on the LMS, usually a tab in a browser.",
                ["de-DE"] = "Die Ansicht eines Clients auf das LMS, meist ein Tab in einem Browser." });

        /// <summary>
        /// A course within an LMS. Contains learning materials and activities
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/course
        /// </summary>
        public readonly xAPI_Activity course = new xAPI_Activity(
            context: "lms",
            key: "course",
            names: new Dictionary<string, string> {
                ["en-US"] = "Course",
                ["de-DE"] = "Kurs" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A course within an LMS. Contains learning materials and activities",
                ["de-DE"] = "Ein Kurs in einem LMS. Enthält Lernmaterialien und -aktivitäten" });

        /// <summary>
        /// An activity to create surveys, questionnaires or polls with.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/feedback
        /// </summary>
        public readonly xAPI_Activity feedback = new xAPI_Activity(
            context: "lms",
            key: "feedback",
            names: new Dictionary<string, string> {
                ["en-US"] = "Feedback",
                ["de-DE"] = "Feedback" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An activity to create surveys, questionnaires or polls with.",
                ["de-DE"] = "Eine Aktivität mit der Umfragen oder Fragebögen erstellt werden können." });

        /// <summary>
        /// A collection of files.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/folder
        /// </summary>
        public readonly xAPI_Activity folder = new xAPI_Activity(
            context: "lms",
            key: "folder",
            names: new Dictionary<string, string> {
                ["en-US"] = "Folder",
                ["de-DE"] = "Verzeichnis" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A collection of files.",
                ["de-DE"] = "Eine Sammlung verschiedener Dateien." });

        /// <summary>
        /// A forum for discussion.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/forum
        /// </summary>
        public readonly xAPI_Activity forum = new xAPI_Activity(
            context: "lms",
            key: "forum",
            names: new Dictionary<string, string> {
                ["en-US"] = "Forum",
                ["de-DE"] = "Forum" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A forum for discussion.",
                ["de-DE"] = "Ein Forum für Diskussionen." });

        /// <summary>
        /// A single discussion/thread within a forum.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/forumDiscussion
        /// </summary>
        public readonly xAPI_Activity forumDiscussion = new xAPI_Activity(
            context: "lms",
            key: "forumDiscussion",
            names: new Dictionary<string, string> {
                ["en-US"] = "Discussion",
                ["de-DE"] = "Diskussion" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single discussion/thread within a forum.",
                ["de-DE"] = "Eine einzelne Diskussion in einem Forum." });

        /// <summary>
        /// A single post within a forum's discussion.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/forumPost
        /// </summary>
        public readonly xAPI_Activity forumPost = new xAPI_Activity(
            context: "lms",
            key: "forumPost",
            names: new Dictionary<string, string> {
                ["en-US"] = "Forum Post",
                ["de-DE"] = "Forumsbeitrag" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single post within a forum's discussion.",
                ["de-DE"] = "Eine einzelner Beitrag in einer Forumsdiskussion." });

        /// <summary>
        /// A collection of definitions, resources and information.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/glossary
        /// </summary>
        public readonly xAPI_Activity glossary = new xAPI_Activity(
            context: "lms",
            key: "glossary",
            names: new Dictionary<string, string> {
                ["en-US"] = "Glossary",
                ["de-DE"] = "Glossar" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A collection of definitions, resources and information.",
                ["de-DE"] = "Eine Sammlung verschiedener Definitionen, Ressourcen und Informationen." });

        /// <summary>
        /// A single entry within a glossary (e.g. a definition, resource or information).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/glossaryEntry
        /// </summary>
        public readonly xAPI_Activity glossaryEntry = new xAPI_Activity(
            context: "lms",
            key: "glossaryEntry",
            names: new Dictionary<string, string> {
                ["en-US"] = "Glossary Entry",
                ["de-DE"] = "Glossareintrag" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single entry within a glossary (e.g. a definition, resource or information).",
                ["de-DE"] = "Ein einzelner Eintrag in einem Glossar (z. B. eine Definition, Ressource oder Information)." });

        /// <summary>
        /// Single item that represents the grading of a single activity within a course. Can be used for grade or point calculation for the whole course.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/gradeItem
        /// </summary>
        public readonly xAPI_Activity gradeItem = new xAPI_Activity(
            context: "lms",
            key: "gradeItem",
            names: new Dictionary<string, string> {
                ["en-US"] = "Grade Item",
                ["de-DE"] = "Bewertungselement" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Single item that represents the grading of a single activity within a course. Can be used for grade or point calculation for the whole course.",
                ["de-DE"] = "Einzelnes Element das die Bewertung einer einzelnen Aktivität in einem Kurs repräsentiert. Kann für die Berechnung einer Note oder Punktzahl für den gesamten Kurs genutzt werden." });

        /// <summary>
        /// H5P is an abbreviation for HTML5 Package - interactive content such as presentations, videos and other multimedia, questions, quizzes, games and more. The H5P activity enables H5P to be uploaded and added to a course.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/h5pactivity
        /// </summary>
        public readonly xAPI_Activity h5pactivity = new xAPI_Activity(
            context: "lms",
            key: "h5pactivity",
            names: new Dictionary<string, string> {
                ["en-US"] = "Interactive Content (H5P)",
                ["de-DE"] = "Interaktiver Inhalt (H5P)" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "H5P is an abbreviation for HTML5 Package - interactive content such as presentations, videos and other multimedia, questions, quizzes, games and more. The H5P activity enables H5P to be uploaded and added to a course.",
                ["de-DE"] = "H5P ist eine Abkürzung für HTML5 Package - interaktive Inhalte wie Präsentationen, Videos und andere multimediale Inhalte, Fragen, Tests, Spiele und mehr. Mit der H5P-Aktivität kann H5P hochgeladen und einem Kurs hinzugefügt werden." });

        /// <summary>
        /// H5P (HVP) is an abbreviation for HTML5 Package - interactive content such as presentations, videos and other multimedia, questions, quizzes, games and more. The H5P activity enables H5P to be uploaded and added to a course.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/hvp
        /// </summary>
        public readonly xAPI_Activity hvp = new xAPI_Activity(
            context: "lms",
            key: "hvp",
            names: new Dictionary<string, string> {
                ["en-US"] = "Interactive Content (H5P)",
                ["de-DE"] = "Interaktiver Inhalt (H5P)" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "H5P (HVP) is an abbreviation for HTML5 Package - interactive content such as presentations, videos and other multimedia, questions, quizzes, games and more. The H5P activity enables H5P to be uploaded and added to a course.",
                ["de-DE"] = "H5P (HVP) ist eine Abkürzung für HTML5 Package - interaktive Inhalte wie Präsentationen, Videos und andere multimediale Inhalte, Fragen, Tests, Spiele und mehr. Mit der H5P-Aktivität kann H5P hochgeladen und einem Kurs hinzugefügt werden." });

        /// <summary>
        /// A collection of pages and links to guide course participants through a topic.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/lesson
        /// </summary>
        public readonly xAPI_Activity lesson = new xAPI_Activity(
            context: "lms",
            key: "lesson",
            names: new Dictionary<string, string> {
                ["en-US"] = "Lesson",
                ["de-DE"] = "Lektion" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A collection of pages and links to guide course participants through a topic.",
                ["de-DE"] = "Eine Sammlung von Seiten und Verlinkungen die Kursteilnehmende durch ein Thema führt." });

        /// <summary>
        /// A Learning Management System (LMS)
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/lms
        /// </summary>
        public readonly xAPI_Activity lms = new xAPI_Activity(
            context: "lms",
            key: "lms",
            names: new Dictionary<string, string> {
                ["en-US"] = "LMS",
                ["de-DE"] = "LMS" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A Learning Management System (LMS)",
                ["de-DE"] = "Ein Lernmanagementsystem (LMS)" });

        /// <summary>
        /// A page within a course displaying custom content like text, images, videos and more.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/page
        /// </summary>
        public readonly xAPI_Activity page = new xAPI_Activity(
            context: "lms",
            key: "page",
            names: new Dictionary<string, string> {
                ["en-US"] = "Page",
                ["de-DE"] = "Seite" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A page within a course displaying custom content like text, images, videos and more.",
                ["de-DE"] = "Eine Seite im Kurs, die verschiedene Inhalte wie Text, Bilder, Videos und andere darstellt." });

        /// <summary>
        /// Plugin for collaborative markup on PDF documents.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/pdfannotator
        /// </summary>
        public readonly xAPI_Activity pdfannotator = new xAPI_Activity(
            context: "lms",
            key: "pdfannotator",
            names: new Dictionary<string, string> {
                ["en-US"] = "PDF-Annotation",
                ["de-DE"] = "PDF-Annotation" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Plugin for collaborative markup on PDF documents.",
                ["de-DE"] = "Plugin zum kollaborativem Markieren von PDF Dokumenten." });

        /// <summary>
        /// A single question that can be used in quizzes.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/question
        /// </summary>
        public readonly xAPI_Activity question = new xAPI_Activity(
            context: "lms",
            key: "question",
            names: new Dictionary<string, string> {
                ["en-US"] = "Question",
                ["de-DE"] = "Frage" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single question that can be used in quizzes.",
                ["de-DE"] = "Eine einzelne Frage, die in Quizzen genutzt werden kann." });

        /// <summary>
        /// A single attempt of a question.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/questionAttempt
        /// </summary>
        public readonly xAPI_Activity questionAttempt = new xAPI_Activity(
            context: "lms",
            key: "questionAttempt",
            names: new Dictionary<string, string> {
                ["en-US"] = "Question Attempt",
                ["de-DE"] = "Fragenversuch" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single attempt of a question.",
                ["de-DE"] = "Ein einzelner Versuch einer Fragenbearbeitung." });

        /// <summary>
        /// A category groupinng different questions e.g. by topic or course.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/questionCategory
        /// </summary>
        public readonly xAPI_Activity questionCategory = new xAPI_Activity(
            context: "lms",
            key: "questionCategory",
            names: new Dictionary<string, string> {
                ["en-US"] = "Question Category",
                ["de-DE"] = "Fragenkategorie" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A category groupinng different questions e.g. by topic or course.",
                ["de-DE"] = "Eine Kategorie, welche Fragen z. B. anhand eines Themas oder Kurses gruppiert." });

        /// <summary>
        /// A quiz object. Contains one or more questions that can be answered by a student.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/quiz
        /// </summary>
        public readonly xAPI_Activity quiz = new xAPI_Activity(
            context: "lms",
            key: "quiz",
            names: new Dictionary<string, string> {
                ["en-US"] = "Quiz",
                ["de-DE"] = "Test" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A quiz object. Contains one or more questions that can be answered by a student.",
                ["de-DE"] = "Ein Test-Objekt. Kann eine oder mehr Fragen enthalten, die von Studierenden beantwortet werden können." });

        /// <summary>
        /// A single attempt of a quiz. Contains attempts of the questions used in the quiz, this attempt relates to.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/quizAttempt
        /// </summary>
        public readonly xAPI_Activity quizAttempt = new xAPI_Activity(
            context: "lms",
            key: "quizAttempt",
            names: new Dictionary<string, string> {
                ["en-US"] = "Quiz Attempt",
                ["de-DE"] = "Testversuch" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single attempt of a quiz. Contains attempts of the questions used in the quiz, this attempt relates to.",
                ["de-DE"] = "Ein einzelner Versuch einer Testbearbeitung. Enthält Versuche von Fragen, die in dem Test verwendet werden, zu dem dieser Versuch gehört." });

        /// <summary>
        /// Interface to review a (graded) quiz attempt. Might contain feedback to given answers and the sample solution.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/quizAttemptReview
        /// </summary>
        public readonly xAPI_Activity quizAttemptReview = new xAPI_Activity(
            context: "lms",
            key: "quizAttemptReview",
            names: new Dictionary<string, string> {
                ["en-US"] = "Quiz Attempt Review",
                ["de-DE"] = "Testversuch Überprüfung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Interface to review a (graded) quiz attempt. Might contain feedback to given answers and the sample solution.",
                ["de-DE"] = "Ansicht zur Überprüfung eines (bewerteten) Testversuchs. Kann Feedback zu gegebenen Antworten sowie eine Beispiellösung enthalten." });

        /// <summary>
        /// Overview of a quz attempt. Allows to see which questions are answered and which are not or only partially.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/quizAttemptSummary
        /// </summary>
        public readonly xAPI_Activity quizAttemptSummary = new xAPI_Activity(
            context: "lms",
            key: "quizAttemptSummary",
            names: new Dictionary<string, string> {
                ["en-US"] = "Quiz Attempt Summary",
                ["de-DE"] = "Testversuch Zusammenfassung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Overview of a quz attempt. Allows to see which questions are answered and which are not or only partially.",
                ["de-DE"] = "Übersicht eines Testversuchs. Erlaubt die Einsicht, für welche Aufgaben eine Antwort gegeben ist und für welche nicht oder nur teilweise." });

        /// <summary>
        /// The position within a quiz, a question is placed in. Represented by an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/quizSlot
        /// </summary>
        public readonly xAPI_Activity quizSlot = new xAPI_Activity(
            context: "lms",
            key: "quizSlot",
            names: new Dictionary<string, string> {
                ["en-US"] = "Quiz Slot",
                ["de-DE"] = "Testslot" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The position within a quiz, a question is placed in. Represented by an integer.",
                ["de-DE"] = "Die Position in einem Test, in die eine Frage eingesetzt wird. Dargestellt als Ganzzahl." });

        /// <summary>
        /// A course resource as a single file (e.g. PDF).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/resource
        /// </summary>
        public readonly xAPI_Activity resource = new xAPI_Activity(
            context: "lms",
            key: "resource",
            names: new Dictionary<string, string> {
                ["en-US"] = "Resource",
                ["de-DE"] = "Ressource" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A course resource as a single file (e.g. PDF).",
                ["de-DE"] = "Eine Kursressource als einzelne Datei (z. B. PDF)." });

        /// <summary>
        /// An URL object, linking to another website or web resource.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/url
        /// </summary>
        public readonly xAPI_Activity url = new xAPI_Activity(
            context: "lms",
            key: "url",
            names: new Dictionary<string, string> {
                ["en-US"] = "URL",
                ["de-DE"] = "Link" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An URL object, linking to another website or web resource.",
                ["de-DE"] = "Ein Link, der auf eine andere Webseite oder Webressource weiterleitet." });

        /// <summary>
        /// A collection of pages linking to each other. All versions of the pages are stored to keep track of edits.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/wiki
        /// </summary>
        public readonly xAPI_Activity wiki = new xAPI_Activity(
            context: "lms",
            key: "wiki",
            names: new Dictionary<string, string> {
                ["en-US"] = "Wiki",
                ["de-DE"] = "Wiki" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A collection of pages linking to each other. All versions of the pages are stored to keep track of edits.",
                ["de-DE"] = "Eine Sammlung von untereinander verlinkten Seiten. Alle Versionen der Seiten werden gespeichert um die Bearbeitungshistorie festzuhalten." });

        /// <summary>
        /// A single page within a wiki.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/wikiPage
        /// </summary>
        public readonly xAPI_Activity wikiPage = new xAPI_Activity(
            context: "lms",
            key: "wikiPage",
            names: new Dictionary<string, string> {
                ["en-US"] = "Wiki Page",
                ["de-DE"] = "Wiki Seite" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A single page within a wiki.",
                ["de-DE"] = "Eine einzelne Seite in einem Wiki." });

        /// <summary>
        /// A Workshop, also Peer Assessment, object is a multiple step task. Students submit assignments via file or text and grade the submission of others based on a review sheet provided by the lecturer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/lms/activities/workshop
        /// </summary>
        public readonly xAPI_Activity workshop = new xAPI_Activity(
            context: "lms",
            key: "workshop",
            names: new Dictionary<string, string> {
                ["en-US"] = "Workshop",
                ["de-DE"] = "Gegenseitige Beurteilung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A Workshop, also Peer Assessment, object is a multiple step task. Students submit assignments via file or text and grade the submission of others based on a review sheet provided by the lecturer.",
                ["de-DE"] = "Die Gegenseitige Beurteilung erlaubt Lernenden eine Abgabe zu tätigen und die anderer anhand eines von den Lehrenden bereitgestellten Bewertungsbogen zu bewerten." });

        public xAPI_Activities_Lms() 
            : base("lms") {
        }
    }
}