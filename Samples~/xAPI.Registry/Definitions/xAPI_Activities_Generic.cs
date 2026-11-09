using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 34 items of the xAPI_Activities of the context generic as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Generic : xAPI_Activities {
        /// <summary>
        /// Response to a question given or received by the user.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/answer
        /// </summary>
        public readonly xAPI_Activity answer = new xAPI_Activity(
            context: "generic",
            key: "answer",
            names: new Dictionary<string, string> {
                ["en-US"] = "answer",
                ["de-DE"] = "Antwort" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Response to a question given or received by the user.",
                ["de-DE"] = "Eine Antwort - kann auf eine Frage gegeben oder erhalten werden." });

        /// <summary>
        /// A button to go backward on a page or a graphical user interface (navigation).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/backwardButton
        /// </summary>
        public readonly xAPI_Activity backwardButton = new xAPI_Activity(
            context: "generic",
            key: "backwardButton",
            names: new Dictionary<string, string> {
                ["en-US"] = "backward button",
                ["de-DE"] = "Zurück Knopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A button to go backward on a page or a graphical user interface (navigation).",
                ["de-DE"] = "Ein Knopf um auf einer Seite oder dem Bildschirm zurückzugehen (Navigation)." });

        /// <summary>
        /// A card, for example showning information inside a game or to display a task in a Kanban-Board.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/card
        /// </summary>
        public readonly xAPI_Activity card = new xAPI_Activity(
            context: "generic",
            key: "card",
            names: new Dictionary<string, string> {
                ["en-US"] = "card",
                ["de-DE"] = "Karte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A card, for example showning information inside a game or to display a task in a Kanban-Board.",
                ["de-DE"] = "Eine Karte, die zum Beispiel Informationen in einem Spiel anzeigt oder eine Aufgabe in einem Kanban-Board repräsentiert." });

        /// <summary>
        /// A widget which allows users to select a color.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/colorPicker
        /// </summary>
        public readonly xAPI_Activity colorPicker = new xAPI_Activity(
            context: "generic",
            key: "colorPicker",
            names: new Dictionary<string, string> {
                ["en-US"] = "color picker",
                ["de-DE"] = "Farbwähler" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A widget which allows users to select a color.",
                ["de-DE"] = "Ein Widget welches es dem Nutzer erlaubt eine Farbe auszuwählen." });

        /// <summary>
        /// A decision to be made which is relevant for the game/process/scenario/situation outcome.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/decision
        /// </summary>
        public readonly xAPI_Activity decision = new xAPI_Activity(
            context: "generic",
            key: "decision",
            names: new Dictionary<string, string> {
                ["en-US"] = "decision",
                ["de-DE"] = "Entscheidung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A decision to be made which is relevant for the game/process/scenario/situation outcome.",
                ["de-DE"] = "Eine Entscheidung die getroffen werden muss und welche den Spielausgang/den Prozess/das Szenario/die Situation beieinflusst." });

        /// <summary>
        /// An electronic document of the type produced by office productivity software such as a word processing document, spreadsheet, slides etc. Depending on the context it can also describe e.g. a document in a game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/document
        /// </summary>
        public readonly xAPI_Activity document = new xAPI_Activity(
            context: "generic",
            key: "document",
            names: new Dictionary<string, string> {
                ["en-US"] = "document",
                ["de-DE"] = "Dokument" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An electronic document of the type produced by office productivity software such as a word processing document, spreadsheet, slides etc. Depending on the context it can also describe e.g. a document in a game.",
                ["de-DE"] = "Ein elektronisches Dokument, das mit einer Büro-Software erstellt wird, z. B. ein Textverarbeitungsdokument, eine Tabellenkalkulation, eine Folie usw. Abhängig vom Kontext kann es z.B. auch ein Dokument in einem Spiel beschreiben." });

        /// <summary>
        /// A system to track gazes of an actor.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/eyeTrackingSystem
        /// </summary>
        public readonly xAPI_Activity eyeTrackingSystem = new xAPI_Activity(
            context: "generic",
            key: "eyeTrackingSystem",
            names: new Dictionary<string, string> {
                ["en-US"] = "eye tracking system",
                ["de-DE"] = "Eye-Tracking System" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A system to track gazes of an actor.",
                ["de-DE"] = "Ein System um die Augenbewegungen eines Akteurs aufzuzeichnen." });

        /// <summary>
        /// A collection of in - most cases - connected data on a disk which is stored together under a particular name.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/file
        /// </summary>
        public readonly xAPI_Activity file = new xAPI_Activity(
            context: "generic",
            key: "file",
            names: new Dictionary<string, string> {
                ["en-US"] = "File",
                ["de-DE"] = "Datei" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A collection of in - most cases - connected data on a disk which is stored together under a particular name.",
                ["de-DE"] = "Eine Sammlung von meist zusammenhängenden Daten auf einem Speichermedium die zusammen unter einem bestimmten Namen gespeichert werden." });

        /// <summary>
        /// A button to go forward on a page or a screen (navigation).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/forwardButton
        /// </summary>
        public readonly xAPI_Activity forwardButton = new xAPI_Activity(
            context: "generic",
            key: "forwardButton",
            names: new Dictionary<string, string> {
                ["en-US"] = "forward button",
                ["de-DE"] = "Weiter Knopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A button to go forward on a page or a screen (navigation).",
                ["de-DE"] = "Ein Knopf um auf einer Seite oder dem Bildschirm weiterzugehen (Navigation)." });

        /// <summary>
        /// A goal is something that the actor wants to achieve, the purpose of doing a task or group of tasks. It can have subtasks and subgoals.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/goal
        /// </summary>
        public readonly xAPI_Activity goal = new xAPI_Activity(
            context: "generic",
            key: "goal",
            names: new Dictionary<string, string> {
                ["en-US"] = "goal",
                ["de-DE"] = "Ziel" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A goal is something that the actor wants to achieve, the purpose of doing a task or group of tasks. It can have subtasks and subgoals.",
                ["de-DE"] = "Ein Ziel ist etwas, das eine Person erreichen möchte, der Zweck der Durchführung einer Aufgabe oder einer Gruppe von Aufgaben. Es kann Unteraufgaben und Unterziele haben." });

        /// <summary>
        /// Represents a grouping of objects or persons in which member objects can join or leave.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/group
        /// </summary>
        public readonly xAPI_Activity group = new xAPI_Activity(
            context: "generic",
            key: "group",
            names: new Dictionary<string, string> {
                ["en-US"] = "group",
                ["de-DE"] = "Gruppe" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents a grouping of objects or persons in which member objects can join or leave.",
                ["de-DE"] = "Stellt eine Gruppierung von Objekten oder Personen dar, in der die Mitgliedsobjekte der Gruppe beitreten oder sie verlassen können." });

        /// <summary>
        /// Something an actor can ask for to find the solution to a task.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/help
        /// </summary>
        public readonly xAPI_Activity help = new xAPI_Activity(
            context: "generic",
            key: "help",
            names: new Dictionary<string, string> {
                ["en-US"] = "help",
                ["de-DE"] = "Hilfe" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something an actor can ask for to find the solution to a task.",
                ["de-DE"] = "Etwas wonach eine Person fragen kann um eine Lösung für eine Aufgabe zu finden." });

        /// <summary>
        /// Represents a graphical image. Can be an interactible, for example objects of this type may contain an additional fullImage property whose value is an Activity Streams Media Link to a "full-sized" representation of the image.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/image
        /// </summary>
        public readonly xAPI_Activity image = new xAPI_Activity(
            context: "generic",
            key: "image",
            names: new Dictionary<string, string> {
                ["en-US"] = "image",
                ["de-DE"] = "Bild" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents a graphical image. Can be an interactible, for example objects of this type may contain an additional fullImage property whose value is an Activity Streams Media Link to a \"full-sized\" representation of the image.",
                ["de-DE"] = "Ein grafisches Bild. Es kann sich um ein interaktives Objekt handeln, z. B. können Objekte dieses Typs eine zusätzliche Vollbild-Eigenschaft enthalten, deren Wert zu einer größeren Darstellung des Bildes führt." });

        /// <summary>
        /// A keyboard to input text or interact with the game in another way.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/keyboard
        /// </summary>
        public readonly xAPI_Activity keyboard = new xAPI_Activity(
            context: "generic",
            key: "keyboard",
            names: new Dictionary<string, string> {
                ["en-US"] = "keyboard",
                ["de-DE"] = "Tastatur" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A keyboard to input text or interact with the game in another way.",
                ["de-DE"] = "Eine Tastatur um Text einzugeben oder in einer anderen Form mit dem Spiel zu interagieren." });

        /// <summary>
        /// A reference to data that the user can follow. Links can either point to a whole document (e.g. website) or to a specific element within a document.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/link
        /// </summary>
        public readonly xAPI_Activity link = new xAPI_Activity(
            context: "generic",
            key: "link",
            names: new Dictionary<string, string> {
                ["en-US"] = "Hyperlink",
                ["de-DE"] = "Hyperlink" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A reference to data that the user can follow. Links can either point to a whole document (e.g. website) or to a specific element within a document.",
                ["de-DE"] = "Ein Querverweis auf ein elektronischces Dokument, welches dem Benutzer ermöglicht zu dem Dokument (z.B. einer Website) oder zu einem bestimmten Abschnitt in dem Dokument zu springen." });

        /// <summary>
        /// A list of possible choices that are shown, e.g. start menu or ingame menu for settings.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/menu
        /// </summary>
        public readonly xAPI_Activity menu = new xAPI_Activity(
            context: "generic",
            key: "menu",
            names: new Dictionary<string, string> {
                ["en-US"] = "menu",
                ["de-DE"] = "Menü" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A list of possible choices that are shown, e.g. start menu or ingame menu for settings.",
                ["de-DE"] = "Eine Liste möglicher Optionen, die angezeigt werden, z. B. das Startmenü oder das Spielmenü für Einstellungen." });

        /// <summary>
        /// A mouse to use UI or interact with the system in another way.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/mouse
        /// </summary>
        public readonly xAPI_Activity mouse = new xAPI_Activity(
            context: "generic",
            key: "mouse",
            names: new Dictionary<string, string> {
                ["en-US"] = "mouse",
                ["de-DE"] = "Maus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A mouse to use UI or interact with the system in another way.",
                ["de-DE"] = "Eine Maus um die Benutzeroberfläche zu benutzen oder in einer anderen Form mit dem System zu interagieren." });

        /// <summary>
        /// A number shown on the screen that can be interacted with in some way for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/number
        /// </summary>
        public readonly xAPI_Activity number = new xAPI_Activity(
            context: "generic",
            key: "number",
            names: new Dictionary<string, string> {
                ["en-US"] = "number",
                ["de-DE"] = "Nummer" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A number shown on the screen that can be interacted with in some way for example.",
                ["de-DE"] = "Eine Nummer, die auf dem Bildschirm angezeigt wird und mit der zum Beispiel interagiert werden kann." });

        /// <summary>
        /// An option is something a player can decide for or against in the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/option
        /// </summary>
        public readonly xAPI_Activity option = new xAPI_Activity(
            context: "generic",
            key: "option",
            names: new Dictionary<string, string> {
                ["en-US"] = "option",
                ["de-DE"] = "Option" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An option is something a player can decide for or against in the game.",
                ["de-DE"] = "Ein Spieler kann sich für oder gegen eine Option entscheiden." });

        /// <summary>
        /// A question can be asked or answered.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/question
        /// </summary>
        public readonly xAPI_Activity question = new xAPI_Activity(
            context: "generic",
            key: "question",
            names: new Dictionary<string, string> {
                ["en-US"] = "question",
                ["de-DE"] = "Frage" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A question can be asked or answered.",
                ["de-DE"] = "Eine Frage kann gestellt oder beantwortet werden." });

        /// <summary>
        /// A system interacting with the game which is not running on the same machine as the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/remoteSystem
        /// </summary>
        public readonly xAPI_Activity remoteSystem = new xAPI_Activity(
            context: "generic",
            key: "remoteSystem",
            names: new Dictionary<string, string> {
                ["en-US"] = "remote system",
                ["de-DE"] = "Fernsystem" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A system interacting with the game which is not running on the same machine as the game.",
                ["de-DE"] = "Ein System, welches mit dem Spiel interagiert aber nicht auf der selben Maschine wie das Spiel läuft." });

        /// <summary>
        /// Data which is gathered by a sensor.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/sensorData
        /// </summary>
        public readonly xAPI_Activity sensorData = new xAPI_Activity(
            context: "generic",
            key: "sensorData",
            names: new Dictionary<string, string> {
                ["en-US"] = "sensor data",
                ["de-DE"] = "Sensorendaten" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Data which is gathered by a sensor.",
                ["de-DE"] = "Daten, welche von einem Sensor erfasst werden." });

        /// <summary>
        /// The settings of a system.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/settings
        /// </summary>
        public readonly xAPI_Activity settings = new xAPI_Activity(
            context: "generic",
            key: "settings",
            names: new Dictionary<string, string> {
                ["en-US"] = "settings",
                ["de-DE"] = "Einstellungen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The settings of a system.",
                ["de-DE"] = "Die EInstellungen eines Systems." });

        /// <summary>
        /// The solution to a task in the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/solution
        /// </summary>
        public readonly xAPI_Activity solution = new xAPI_Activity(
            context: "generic",
            key: "solution",
            names: new Dictionary<string, string> {
                ["en-US"] = "solution",
                ["de-DE"] = "Lösung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The solution to a task in the game.",
                ["de-DE"] = "Die Lösung zu einer Aufgabe im Spiel." });

        /// <summary>
        /// The status wether a task can be completed in the current state.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/solvability
        /// </summary>
        public readonly xAPI_Activity solvability = new xAPI_Activity(
            context: "generic",
            key: "solvability",
            names: new Dictionary<string, string> {
                ["en-US"] = "solvability",
                ["de-DE"] = "Lösbarkeit" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The status wether a task can be completed in the current state.",
                ["de-DE"] = "Der Zustand, ob die aktuelle Aufgabe noch gelöst werden kann mit dem aktuelle Systemzustand." });

        /// <summary>
        /// A button to start a video.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/startVideoButton
        /// </summary>
        public readonly xAPI_Activity startVideoButton = new xAPI_Activity(
            context: "generic",
            key: "startVideoButton",
            names: new Dictionary<string, string> {
                ["en-US"] = "start video button",
                ["de-DE"] = "Videostart-Knopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A button to start a video.",
                ["de-DE"] = "Ein Knopf um ein Video zu starten." });

        /// <summary>
        /// A button to stop a video.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/stopVideoButton
        /// </summary>
        public readonly xAPI_Activity stopVideoButton = new xAPI_Activity(
            context: "generic",
            key: "stopVideoButton",
            names: new Dictionary<string, string> {
                ["en-US"] = "stop video button",
                ["de-DE"] = "Videostopp-Knopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A button to stop a video.",
                ["de-DE"] = "Ein Knopf um ein Video zu stoppen." });

        /// <summary>
        /// A device to interact with the system.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/tangible
        /// </summary>
        public readonly xAPI_Activity tangible = new xAPI_Activity(
            context: "generic",
            key: "tangible",
            names: new Dictionary<string, string> {
                ["en-US"] = "tangible",
                ["de-DE"] = "Tangible" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A device to interact with the system.",
                ["de-DE"] = "Ein Gerät um mit dem System zu interagieren." });

        /// <summary>
        /// Some part of the goal or something to be completed to progress within the game or a level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/task
        /// </summary>
        public readonly xAPI_Activity task = new xAPI_Activity(
            context: "generic",
            key: "task",
            names: new Dictionary<string, string> {
                ["en-US"] = "task",
                ["de-DE"] = "Aufgabe" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Some part of the goal or something to be completed to progress within the game or a level.",
                ["de-DE"] = "Eine Aufgabe, die zum Erreichen des Ziels erfüllt werden muss oder zum Abschließen eines Levels." });

        /// <summary>
        /// A text which can be read or entered.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/text
        /// </summary>
        public readonly xAPI_Activity text = new xAPI_Activity(
            context: "generic",
            key: "text",
            names: new Dictionary<string, string> {
                ["en-US"] = "text",
                ["de-DE"] = "Text" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A text which can be read or entered.",
                ["de-DE"] = "Ein Text der gelesen oder eingegeben werden kann." });

        /// <summary>
        /// A tip on how to solve a task.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/tip
        /// </summary>
        public readonly xAPI_Activity tip = new xAPI_Activity(
            context: "generic",
            key: "tip",
            names: new Dictionary<string, string> {
                ["en-US"] = "tip",
                ["de-DE"] = "Tipp" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A tip on how to solve a task.",
                ["de-DE"] = "Ein Tipp um eine Aufgabe zu lösen." });

        /// <summary>
        /// A tooltip is a little pop-up, which gives some information about a certain element.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/tooltip
        /// </summary>
        public readonly xAPI_Activity tooltip = new xAPI_Activity(
            context: "generic",
            key: "tooltip",
            names: new Dictionary<string, string> {
                ["en-US"] = "tooltip",
                ["de-DE"] = "Tooltip" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A tooltip is a little pop-up, which gives some information about a certain element.",
                ["de-DE"] = "Ein Tooltip ist ein kleines Pop-up-Fenster in Anwendungsprogrammen oder Webseiten. Es zeigt eine Beschreibung zu einem Element der grafischen Benutzungsoberfläche" });

        /// <summary>
        /// A video which can be watched inside the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/video
        /// </summary>
        public readonly xAPI_Activity video = new xAPI_Activity(
            context: "generic",
            key: "video",
            names: new Dictionary<string, string> {
                ["en-US"] = "video",
                ["de-DE"] = "Video" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A video which can be watched inside the game.",
                ["de-DE"] = "Ein Video, welches im Spiel angeschaut werden kann." });

        /// <summary>
        /// A word shown on the screen that eventually can be interacted with in some way.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/activities/word
        /// </summary>
        public readonly xAPI_Activity word = new xAPI_Activity(
            context: "generic",
            key: "word",
            names: new Dictionary<string, string> {
                ["en-US"] = "word",
                ["de-DE"] = "Wort" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A word shown on the screen that eventually can be interacted with in some way.",
                ["de-DE"] = "Ein Wort, welches auf dem Bildschirm angezeigt wird und mit dem eventuell interagiert werden kann." });

        public xAPI_Activities_Generic() 
            : base("generic") {
        }
    }
}