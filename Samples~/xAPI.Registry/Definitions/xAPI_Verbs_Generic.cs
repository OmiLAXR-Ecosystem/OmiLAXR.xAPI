using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 61 items of the xAPI_Verbs of the context generic as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Generic : xAPI_Verbs {
        /// <summary>
        /// Indicates that the actor has accepted the object. For instance, a person accepting an award, or accepting an assignment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/accepted
        /// </summary>
        public readonly xAPI_Verb accepted = new xAPI_Verb(
            context: "generic",
            key: "accepted",
            names: new Dictionary<string, string> {
                ["en-US"] = "accepted",
                ["de-DE"] = "akzeptierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Indicates that the actor has accepted the object. For instance, a person accepting an award, or accepting an assignment.",
                ["de-DE"] = "Signalisiert, dass ein Agierender ein Objekt akzeptiert hat. Zum Beispiel: Eine Person akzeptiert eine Auszeichnung oder eine Aufgabe." });

        /// <summary>
        /// Actor accessed/viewed a page, file, video, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/accessed
        /// </summary>
        public readonly xAPI_Verb accessed = new xAPI_Verb(
            context: "generic",
            key: "accessed",
            names: new Dictionary<string, string> {
                ["en-US"] = "accessed",
                ["de-DE"] = "zugegriffen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor accessed/viewed a page, file, video, ...",
                ["de-DE"] = "Akteur hat (auf) eine Seite, eine Datei, ein Video, ... zugegriffen/angesehen" });

        /// <summary>
        /// An actor achieved some goal or score.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/achieved
        /// </summary>
        public readonly xAPI_Verb achieved = new xAPI_Verb(
            context: "generic",
            key: "achieved",
            names: new Dictionary<string, string> {
                ["en-US"] = "achieved",
                ["de-DE"] = "erreichte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor achieved some goal or score.",
                ["de-DE"] = "Ein Akteur erreichte ein Ziel oder ein Ergebnis." });

        /// <summary>
        /// An actor answered some question.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/answered
        /// </summary>
        public readonly xAPI_Verb answered = new xAPI_Verb(
            context: "generic",
            key: "answered",
            names: new Dictionary<string, string> {
                ["en-US"] = "answered",
                ["de-DE"] = "beantwortete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor answered some question.",
                ["de-DE"] = "Ein Akteur beantwortete eine Frage." });

        /// <summary>
        /// An actor asked a question. Could also asked for help or advice.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/asked
        /// </summary>
        public readonly xAPI_Verb asked = new xAPI_Verb(
            context: "generic",
            key: "asked",
            names: new Dictionary<string, string> {
                ["en-US"] = "asked",
                ["de-DE"] = "fragte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor asked a question. Could also asked for help or advice.",
                ["de-DE"] = "Ein Agierender stellte eine Frage. Es kann auch nach Hilfe oder Ratschlag gefragt werden." });

        /// <summary>
        /// An actor calibrated something. This could be an eye tracking system for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/calibrated
        /// </summary>
        public readonly xAPI_Verb calibrated = new xAPI_Verb(
            context: "generic",
            key: "calibrated",
            names: new Dictionary<string, string> {
                ["en-US"] = "calibrated",
                ["de-DE"] = "kalibrierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor calibrated something. This could be an eye tracking system for example.",
                ["de-DE"] = "Ein Agierender kalibrierte etwas. Dies kann zum Beispiel ein Eyetracking System sein." });

        /// <summary>
        /// An actor changed something. This could be the level or some settings.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/changed
        /// </summary>
        public readonly xAPI_Verb changed = new xAPI_Verb(
            context: "generic",
            key: "changed",
            names: new Dictionary<string, string> {
                ["en-US"] = "changed",
                ["de-DE"] = "veränderte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor changed something. This could be the level or some settings.",
                ["de-DE"] = "Ein Akteur veränderte etwas. Dies könnte das Level sein oder die Einstellungen." });

        /// <summary>
        /// An actor has clicked a button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "generic",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked",
                ["de-DE"] = "klickte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has clicked a button.",
                ["de-DE"] = "Der Agierende klickte einen Knopf." });

        /// <summary>
        /// An actor closed something. Could for example be the settings.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/closed
        /// </summary>
        public readonly xAPI_Verb closed = new xAPI_Verb(
            context: "generic",
            key: "closed",
            names: new Dictionary<string, string> {
                ["en-US"] = "closed",
                ["de-DE"] = "schloss" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor closed something. Could for example be the settings.",
                ["de-DE"] = "Ein Akteur schloss etwas. Könnten zum Beispiel die Einstellungen sein." });

        /// <summary>
        /// An actor collapsed something, a menu for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/collapsed
        /// </summary>
        public readonly xAPI_Verb collapsed = new xAPI_Verb(
            context: "generic",
            key: "collapsed",
            names: new Dictionary<string, string> {
                ["en-US"] = "collapsed",
                ["de-DE"] = "klappte ein" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor collapsed something, a menu for example.",
                ["de-DE"] = "Ein Agierender klappte etwas ein, ein Menü zum Beispiel ein." });

        /// <summary>
        /// An actor collected some item.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/collected
        /// </summary>
        public readonly xAPI_Verb collected = new xAPI_Verb(
            context: "generic",
            key: "collected",
            names: new Dictionary<string, string> {
                ["en-US"] = "collected",
                ["de-DE"] = "sammelte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor collected some item.",
                ["de-DE"] = "Ein Akteur sammelte einen Gegenstand ein." });

        /// <summary>
        /// An actor brought two or more objects together. This can create a new object out of the combined ones. If just a logical connection is meant, use connected.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/combined
        /// </summary>
        public readonly xAPI_Verb combined = new xAPI_Verb(
            context: "generic",
            key: "combined",
            names: new Dictionary<string, string> {
                ["en-US"] = "combined",
                ["de-DE"] = "kombinierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor brought two or more objects together. This can create a new object out of the combined ones. If just a logical connection is meant, use connected.",
                ["de-DE"] = "Ein Akteur brachte zwei oder mehr Gegenstände zusammen. Aus den kombinierten Gegenständen können neue Gegenstände entstehen. Wenn eine logische Kombination der Gegenstände gemeint ist, nutzte verband." });

        /// <summary>
        /// An actor completed some task, goal or level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/completed
        /// </summary>
        public readonly xAPI_Verb completed = new xAPI_Verb(
            context: "generic",
            key: "completed",
            names: new Dictionary<string, string> {
                ["en-US"] = "completed",
                ["de-DE"] = "schloss ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor completed some task, goal or level.",
                ["de-DE"] = "Ein Akteur schloss eine Aufgabe, ein Ziel oder ein Level ab." });

        /// <summary>
        /// An actor connected two or more items with each other. This is meant in the sense of drawn a line between the objects, while combined can make something new out of the objects.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/connected
        /// </summary>
        public readonly xAPI_Verb connected = new xAPI_Verb(
            context: "generic",
            key: "connected",
            names: new Dictionary<string, string> {
                ["en-US"] = "connected",
                ["de-DE"] = "verband" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor connected two or more items with each other. This is meant in the sense of drawn a line between the objects, while combined can make something new out of the objects.",
                ["de-DE"] = "Ein Agierender verband zwei oder mehr Objekte mit einander. Dies ist eher im Sinne der Verbindung durch eine Linie zwischen den Objekten, während mit kombinierte auch zum Beispiel neue Objekte aus den Verbundenen entstehen können." });

        /// <summary>
        /// Refers for example to a copy-and-paste action performed by an actor. E.g. An actor copied text to paste it into the adress bar of a browser.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/copied
        /// </summary>
        public readonly xAPI_Verb copied = new xAPI_Verb(
            context: "generic",
            key: "copied",
            names: new Dictionary<string, string> {
                ["en-US"] = "copied",
                ["de-DE"] = "kopierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Refers for example to a copy-and-paste action performed by an actor. E.g. An actor copied text to paste it into the adress bar of a browser.",
                ["de-DE"] = "Dieses Verb bezieht sich zum Beispiel auf die kopier-und-einfüge Operation einer Person. Z.B. eine Person hat einen Text kopiert, um ihn anschließend in die Adresszeile eines Browsers einzufügen." });

        /// <summary>
        /// An actor created something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/created
        /// </summary>
        public readonly xAPI_Verb created = new xAPI_Verb(
            context: "generic",
            key: "created",
            names: new Dictionary<string, string> {
                ["en-US"] = "created",
                ["de-DE"] = "erstellte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor created something.",
                ["de-DE"] = "Ein Akteur erstellte etwas." });

        /// <summary>
        /// A actor crossed out some text or object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/crossedOut
        /// </summary>
        public readonly xAPI_Verb crossedOut = new xAPI_Verb(
            context: "generic",
            key: "crossedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "crossedOut",
                ["de-DE"] = "streichte durch" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A actor crossed out some text or object.",
                ["de-DE"] = "Ein Acteur streichte einen Text oder ein Objekt durch." });

        /// <summary>
        /// An actor deleted something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/deleted
        /// </summary>
        public readonly xAPI_Verb deleted = new xAPI_Verb(
            context: "generic",
            key: "deleted",
            names: new Dictionary<string, string> {
                ["en-US"] = "deleted",
                ["de-DE"] = "löschte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor deleted something.",
                ["de-DE"] = "Ein Akteur löschte etwas." });

        /// <summary>
        /// An actor deselected a option.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/deselected
        /// </summary>
        public readonly xAPI_Verb deselected = new xAPI_Verb(
            context: "generic",
            key: "deselected",
            names: new Dictionary<string, string> {
                ["en-US"] = "deselected",
                ["de-DE"] = "nahm Auswahl zurück" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor deselected a option.",
                ["de-DE"] = "Ein Akteur nahm die Auswahl einer Option zurück." });

        /// <summary>
        /// A user used a local device to download data from a different distant disk.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/downloaded
        /// </summary>
        public readonly xAPI_Verb downloaded = new xAPI_Verb(
            context: "generic",
            key: "downloaded",
            names: new Dictionary<string, string> {
                ["en-US"] = "downloaded",
                ["de-DE"] = "downloadete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A user used a local device to download data from a different distant disk.",
                ["de-DE"] = "Ein Benutzer nutze ein lokales Gerät um Daten von einem entfernten Speichermedium zu laden." });

        /// <summary>
        /// An actor drew something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/drew
        /// </summary>
        public readonly xAPI_Verb drew = new xAPI_Verb(
            context: "generic",
            key: "drew",
            names: new Dictionary<string, string> {
                ["en-US"] = "drew",
                ["de-DE"] = "malte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor drew something.",
                ["de-DE"] = "Ein Agierender malte etwas." });

        /// <summary>
        /// A actor dropped some draggable into a specific area.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/dropped
        /// </summary>
        public readonly xAPI_Verb dropped = new xAPI_Verb(
            context: "generic",
            key: "dropped",
            names: new Dictionary<string, string> {
                ["en-US"] = "dropped",
                ["de-DE"] = "ließ fallen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A actor dropped some draggable into a specific area.",
                ["de-DE"] = "Ein Acteur ließ einen ziehbaren Gegenstand in ein spezielles Feld fallen." });

        /// <summary>
        /// An actor edited an object, for example their account profile. 'edited' has a strong connection to text-based input, e.g. a user edited the title. If the user uses preset values, for example realized by a dropdown menu, choose 'changed'. Also in most non-text-based input e.g. changing a color, 'changed' is the matching verb
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/edited
        /// </summary>
        public readonly xAPI_Verb edited = new xAPI_Verb(
            context: "generic",
            key: "edited",
            names: new Dictionary<string, string> {
                ["en-US"] = "edited",
                ["de-DE"] = "editierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor edited an object, for example their account profile. 'edited' has a strong connection to text-based input, e.g. a user edited the title. If the user uses preset values, for example realized by a dropdown menu, choose 'changed'. Also in most non-text-based input e.g. changing a color, 'changed' is the matching verb",
                ["de-DE"] = "Ein Acteur editierte ein Object, zum Beispiel ihren Account.'editierte' hat eine startke Verbindung zu text-basiertem Input. Z.B. Ein Benutzer editierte den Titel. Wenn dem Benutzer eine Auswahl benutzt, wie bei einem Dropdown Menü, sollte 'geändert' benutzt werden. Darüberhinaus ist in den meisten nicht-text-basierten Input, z.B. beim Ändern einer Farbe, 'änderte' das passende Verb" });

        /// <summary>
        /// An actor gave some input.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/entered
        /// </summary>
        public readonly xAPI_Verb entered = new xAPI_Verb(
            context: "generic",
            key: "entered",
            names: new Dictionary<string, string> {
                ["en-US"] = "entered",
                ["de-DE"] = "gab ein" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor gave some input.",
                ["de-DE"] = "Ein Akteur gab eine Eingabe." });

        /// <summary>
        /// An actor failed some task.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/failed
        /// </summary>
        public readonly xAPI_Verb failed = new xAPI_Verb(
            context: "generic",
            key: "failed",
            names: new Dictionary<string, string> {
                ["en-US"] = "failed",
                ["de-DE"] = "scheiterte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor failed some task.",
                ["de-DE"] = "Ein Akteur scheiterte an einer Aufgabe." });

        /// <summary>
        /// An actor found some item.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/found
        /// </summary>
        public readonly xAPI_Verb found = new xAPI_Verb(
            context: "generic",
            key: "found",
            names: new Dictionary<string, string> {
                ["en-US"] = "found",
                ["de-DE"] = "fand" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor found some item.",
                ["de-DE"] = "Ein Akteur fand einen Gegenstand." });

        /// <summary>
        /// An actor left behind some object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/left
        /// </summary>
        public readonly xAPI_Verb left = new xAPI_Verb(
            context: "generic",
            key: "left",
            names: new Dictionary<string, string> {
                ["en-US"] = "left",
                ["de-DE"] = "lies zurück" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor left behind some object.",
                ["de-DE"] = "Ein Akteur lies einen Gegenstand zurück." });

        /// <summary>
        /// An actor did some action to lock up something. Could also be locked out of a progression path for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/locked
        /// </summary>
        public readonly xAPI_Verb locked = new xAPI_Verb(
            context: "generic",
            key: "locked",
            names: new Dictionary<string, string> {
                ["en-US"] = "locked",
                ["de-DE"] = "verschloss" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor did some action to lock up something. Could also be locked out of a progression path for example.",
                ["de-DE"] = "Ein Agierender verschloss etwas, z.B. einen Gegenstand. Kann zum Beispiel aber auch ausschließen von einem Weg zum voran kommen sein." });

        /// <summary>
        /// A actor looked at a specific object. Only use if you can determine that the actor really looked at something, thriough eye-tracking for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/lookedAt
        /// </summary>
        public readonly xAPI_Verb lookedAt = new xAPI_Verb(
            context: "generic",
            key: "lookedAt",
            names: new Dictionary<string, string> {
                ["en-US"] = "looked at",
                ["de-DE"] = "schaute auf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A actor looked at a specific object. Only use if you can determine that the actor really looked at something, thriough eye-tracking for example.",
                ["de-DE"] = "Ein Acteur schaute auf eine spezifische Sache. Sollte nur genutzt werden wenn sichergestellt werden kann, dass der Spieler sich die Sache auch wirklich angeschaut hat. Mit Eyetracking kann das zum Beispiel gemacht werden." });

        /// <summary>
        /// An actor found some item and collected it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/looted
        /// </summary>
        public readonly xAPI_Verb looted = new xAPI_Verb(
            context: "generic",
            key: "looted",
            names: new Dictionary<string, string> {
                ["en-US"] = "looted",
                ["de-DE"] = "plünderte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor found some item and collected it.",
                ["de-DE"] = "Ein Akteur fand einen Gegenstand und sammelte ihn ein." });

        /// <summary>
        /// An actor lost the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/lost
        /// </summary>
        public readonly xAPI_Verb lost = new xAPI_Verb(
            context: "generic",
            key: "lost",
            names: new Dictionary<string, string> {
                ["en-US"] = "lost",
                ["de-DE"] = "verlor" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor lost the game.",
                ["de-DE"] = "Ein Akteur verlor das Spiel." });

        /// <summary>
        /// An actor made a decision.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/made
        /// </summary>
        public readonly xAPI_Verb made = new xAPI_Verb(
            context: "generic",
            key: "made",
            names: new Dictionary<string, string> {
                ["en-US"] = "made",
                ["de-DE"] = "fällte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor made a decision.",
                ["de-DE"] = "Ein Akteur fällte eine Entscheidung." });

        /// <summary>
        /// An actor moved itself or some object in the game world.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/moved
        /// </summary>
        public readonly xAPI_Verb moved = new xAPI_Verb(
            context: "generic",
            key: "moved",
            names: new Dictionary<string, string> {
                ["en-US"] = "moved",
                ["de-DE"] = "bewegte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor moved itself or some object in the game world.",
                ["de-DE"] = "Ein Akteur bewegte sich oder einen Gegenstand in der Spielwelt." });

        /// <summary>
        /// An actor opened something. Could also be the settings for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/opened
        /// </summary>
        public readonly xAPI_Verb opened = new xAPI_Verb(
            context: "generic",
            key: "opened",
            names: new Dictionary<string, string> {
                ["en-US"] = "opened",
                ["de-DE"] = "öffnete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor opened something. Could also be the settings for example.",
                ["de-DE"] = "Ein Akteur öffnete etwas. Könnten zum Beispiel auch die Einstellungen sein." });

        /// <summary>
        /// An actor brought some objects into order.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/ordered
        /// </summary>
        public readonly xAPI_Verb ordered = new xAPI_Verb(
            context: "generic",
            key: "ordered",
            names: new Dictionary<string, string> {
                ["en-US"] = "ordered",
                ["de-DE"] = "ordnete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor brought some objects into order.",
                ["de-DE"] = "Ein Akteur ordnete ein Anzahl an Gegenständen." });

        /// <summary>
        /// Refers to the copy-and-paste action performed by an actor. E.g. An actor pasted a text into a textbox
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/pasted
        /// </summary>
        public readonly xAPI_Verb pasted = new xAPI_Verb(
            context: "generic",
            key: "pasted",
            names: new Dictionary<string, string> {
                ["en-US"] = "pasted",
                ["de-DE"] = "eingefügt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Refers to the copy-and-paste action performed by an actor. E.g. An actor pasted a text into a textbox",
                ["de-DE"] = "Dieses Verb bezieht sich auf die kopier-und-einfüge Operation eines Akteurs. Z.B. ein Akteur fügte den (vorher kopierten) Text in ein Textfeld ein." });

        /// <summary>
        /// An actor played a game or something specific in a game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/played
        /// </summary>
        public readonly xAPI_Verb played = new xAPI_Verb(
            context: "generic",
            key: "played",
            names: new Dictionary<string, string> {
                ["en-US"] = "played",
                ["de-DE"] = "spielte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor played a game or something specific in a game.",
                ["de-DE"] = "Ein Akteur spielte ein Spiel oder etwas spezifisches in einem Spiel." });

        /// <summary>
        /// An actor has pressed a button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/pressed
        /// </summary>
        public readonly xAPI_Verb pressed = new xAPI_Verb(
            context: "generic",
            key: "pressed",
            names: new Dictionary<string, string> {
                ["en-US"] = "pressed",
                ["de-DE"] = "drückte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has pressed a button.",
                ["de-DE"] = "Der Agierende drückte eine Taste." });

        /// <summary>
        /// A actor or gorup pressed a specific button. Only use if the press of specific buttons should be tracked. Use the specific button as activity then. Otherwise use press as verb and button as activity.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/pressedButton
        /// </summary>
        public readonly xAPI_Verb pressedButton = new xAPI_Verb(
            context: "generic",
            key: "pressedButton",
            names: new Dictionary<string, string> {
                ["en-US"] = "pressedButton",
                ["de-DE"] = "drückte Knopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A actor or gorup pressed a specific button. Only use if the press of specific buttons should be tracked. Use the specific button as activity then. Otherwise use press as verb and button as activity.",
                ["de-DE"] = "Ein Akteur drückte einen bestimmten Knopf. Sollte nur genutzt werden, wenn das Drücken eines bestimmten Knopfes aufgezeichnet werden soll. Nutze dann den speziellen Knopf als Aktivität der Aussage. Andernfalls nutze drückte als Verb und Knopf als Aktivität." });

        /// <summary>
        /// An actor progressed in some game related way(achieved something or completed something).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/progressed
        /// </summary>
        public readonly xAPI_Verb progressed = new xAPI_Verb(
            context: "generic",
            key: "progressed",
            names: new Dictionary<string, string> {
                ["en-US"] = "progressed",
                ["de-DE"] = "erzielte Fortschritt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor progressed in some game related way(achieved something or completed something).",
                ["de-DE"] = "Ein Akteur erzielte in einer Form einen Fortschritt im Spiel(erreichte oder vollendete etwas)." });

        /// <summary>
        /// A actor read some text. Only use if it can be assured that the text is read.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/read
        /// </summary>
        public readonly xAPI_Verb read = new xAPI_Verb(
            context: "generic",
            key: "read",
            names: new Dictionary<string, string> {
                ["en-US"] = "read",
                ["de-DE"] = "las" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A actor read some text. Only use if it can be assured that the text is read.",
                ["de-DE"] = "Ein Acteur las einen Text. Sollte nur genutzt werden wenn sichergestellt werden kann, dass der Text auch wirklich gelesen wurde." });

        /// <summary>
        /// An actor received for example an item or help.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/received
        /// </summary>
        public readonly xAPI_Verb received = new xAPI_Verb(
            context: "generic",
            key: "received",
            names: new Dictionary<string, string> {
                ["en-US"] = "received",
                ["de-DE"] = "erhielt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor received for example an item or help.",
                ["de-DE"] = "Ein Akteur erhielt zum Beispiel einen Gegenstand oder Hilfe." });

        /// <summary>
        /// An actor has released a button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/released
        /// </summary>
        public readonly xAPI_Verb released = new xAPI_Verb(
            context: "generic",
            key: "released",
            names: new Dictionary<string, string> {
                ["en-US"] = "released",
                ["de-DE"] = "löste" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has released a button.",
                ["de-DE"] = "Der Agierende löste eine Taste." });

        /// <summary>
        /// An actor saved the progress.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/saved
        /// </summary>
        public readonly xAPI_Verb saved = new xAPI_Verb(
            context: "generic",
            key: "saved",
            names: new Dictionary<string, string> {
                ["en-US"] = "saved",
                ["de-DE"] = "speicherte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor saved the progress.",
                ["de-DE"] = "Ein Akteur speicherte den Fortschritt." });

        /// <summary>
        /// An actor has scrolled on a trackpad or mouse wheel.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/scrolled
        /// </summary>
        public readonly xAPI_Verb scrolled = new xAPI_Verb(
            context: "generic",
            key: "scrolled",
            names: new Dictionary<string, string> {
                ["en-US"] = "scrolled",
                ["de-DE"] = "skrollte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has scrolled on a trackpad or mouse wheel.",
                ["de-DE"] = "Der Agierende skrollte auf einem Trackpad or Mausrad." });

        /// <summary>
        /// An actor searched for an item or searched a location.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/searched
        /// </summary>
        public readonly xAPI_Verb searched = new xAPI_Verb(
            context: "generic",
            key: "searched",
            names: new Dictionary<string, string> {
                ["en-US"] = "searched",
                ["de-DE"] = "suchte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor searched for an item or searched a location.",
                ["de-DE"] = "Ein Acteur oder ein Gruppe suchte nach einem Gegenstand oder zum Beispiel auch einen Ort ab." });

        /// <summary>
        /// An actor selected some option. This could be an answer or a level for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/selected
        /// </summary>
        public readonly xAPI_Verb selected = new xAPI_Verb(
            context: "generic",
            key: "selected",
            names: new Dictionary<string, string> {
                ["en-US"] = "selected",
                ["de-DE"] = "wählte aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor selected some option. This could be an answer or a level for example.",
                ["de-DE"] = "Ein Agierender wählte eine Option. Dies könnte eine Antwort auf eine Frage oder auch ein Level sein." });

        /// <summary>
        /// An actor shared an object with another actor or a group of actors.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/shared
        /// </summary>
        public readonly xAPI_Verb shared = new xAPI_Verb(
            context: "generic",
            key: "shared",
            names: new Dictionary<string, string> {
                ["en-US"] = "shared",
                ["de-DE"] = "teilte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor shared an object with another actor or a group of actors.",
                ["de-DE"] = "Ein Agierender teilte eine Gegenstand mit einer anderen Preson oder einer Gruppe." });

        /// <summary>
        /// An actor solved some task.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/solved
        /// </summary>
        public readonly xAPI_Verb solved = new xAPI_Verb(
            context: "generic",
            key: "solved",
            names: new Dictionary<string, string> {
                ["en-US"] = "solved",
                ["de-DE"] = "löste" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor solved some task.",
                ["de-DE"] = "Ein Akteur löste eine Aufgabe." });

        /// <summary>
        /// An actor sorted some objects.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/sorted
        /// </summary>
        public readonly xAPI_Verb sorted = new xAPI_Verb(
            context: "generic",
            key: "sorted",
            names: new Dictionary<string, string> {
                ["en-US"] = "sorted",
                ["de-DE"] = "sortierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor sorted some objects.",
                ["de-DE"] = "Ein Akteur sortierte Objekte." });

        /// <summary>
        /// An actor synchronized data with an LMS for example, which means, that two objects/processes/devices synchronized between A and B or with something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/synchronized
        /// </summary>
        public readonly xAPI_Verb synchronized = new xAPI_Verb(
            context: "generic",
            key: "synchronized",
            names: new Dictionary<string, string> {
                ["en-US"] = "synchronized",
                ["de-DE"] = "synchronisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor synchronized data with an LMS for example, which means, that two objects/processes/devices synchronized between A and B or with something.",
                ["de-DE"] = "Ein Agierender synchronisierte etwas, zum Beispiel Daten mit einem LMS, d.h. zwei Objekte/Vorgänge/Geräte wurden auf einen Stand gebracht." });

        /// <summary>
        /// An actor toggled some switch.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/toggled
        /// </summary>
        public readonly xAPI_Verb toggled = new xAPI_Verb(
            context: "generic",
            key: "toggled",
            names: new Dictionary<string, string> {
                ["en-US"] = "toggled",
                ["de-DE"] = "betätigte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor toggled some switch.",
                ["de-DE"] = "Ein Agierender betätigte einen Schalter." });

        /// <summary>
        /// An actor triggered a event.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/triggered
        /// </summary>
        public readonly xAPI_Verb triggered = new xAPI_Verb(
            context: "generic",
            key: "triggered",
            names: new Dictionary<string, string> {
                ["en-US"] = "triggered",
                ["de-DE"] = "löste aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor triggered a event.",
                ["de-DE"] = "Ein Akteur löste ein Ereignis aus." });

        /// <summary>
        /// An actor unfolded something, a menu for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/unfolded
        /// </summary>
        public readonly xAPI_Verb unfolded = new xAPI_Verb(
            context: "generic",
            key: "unfolded",
            names: new Dictionary<string, string> {
                ["en-US"] = "unfolded",
                ["de-DE"] = "klappte aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor unfolded something, a menu for example.",
                ["de-DE"] = "Ein Akteur klappte etwas aus, zum Beispiel ein Menü." });

        /// <summary>
        /// An actor unlocked some option or item.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/unlocked
        /// </summary>
        public readonly xAPI_Verb unlocked = new xAPI_Verb(
            context: "generic",
            key: "unlocked",
            names: new Dictionary<string, string> {
                ["en-US"] = "unlocked",
                ["de-DE"] = "schaltete frei" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor unlocked some option or item.",
                ["de-DE"] = "Ein Akteur schaltete eine Option oder einen Gegenstand frei." });

        /// <summary>
        /// A user or group used some local device to uploaded data onto a different distant disk.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/uploaded
        /// </summary>
        public readonly xAPI_Verb uploaded = new xAPI_Verb(
            context: "generic",
            key: "uploaded",
            names: new Dictionary<string, string> {
                ["en-US"] = "uploaded",
                ["de-DE"] = "lud hoch" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A user or group used some local device to uploaded data onto a different distant disk.",
                ["de-DE"] = "Ein Benutzer oder eine Gruppe nutze ein lokales Gerät um daten auf ein entferntes Speichermedium zu laden." });

        /// <summary>
        /// An actor used some item.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/used
        /// </summary>
        public readonly xAPI_Verb used = new xAPI_Verb(
            context: "generic",
            key: "used",
            names: new Dictionary<string, string> {
                ["en-US"] = "used",
                ["de-DE"] = "benutzte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor used some item.",
                ["de-DE"] = "Ein Akteur benutze einen Gegenstand." });

        /// <summary>
        /// A group of actors voted on something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/voted
        /// </summary>
        public readonly xAPI_Verb voted = new xAPI_Verb(
            context: "generic",
            key: "voted",
            names: new Dictionary<string, string> {
                ["en-US"] = "voted",
                ["de-DE"] = "stimmte ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A group of actors voted on something.",
                ["de-DE"] = "Eine Gruppe von Acteuren stimmte für etwas ab." });

        /// <summary>
        /// An actor watched a video. Only use if you can assure the actors really watched the video, use eye-tracking for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/watched
        /// </summary>
        public readonly xAPI_Verb watched = new xAPI_Verb(
            context: "generic",
            key: "watched",
            names: new Dictionary<string, string> {
                ["en-US"] = "watched",
                ["de-DE"] = "schaute" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor watched a video. Only use if you can assure the actors really watched the video, use eye-tracking for example.",
                ["de-DE"] = "Ein Akteur schaute ein Video. Sollte nur genutzt werden wenn sichergestellt werden kann, dass das Video wirklich geschaut wurde. Eyetracking könnte dafür zum Beispiel benutzt werden." });

        /// <summary>
        /// An actor won a game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/won
        /// </summary>
        public readonly xAPI_Verb won = new xAPI_Verb(
            context: "generic",
            key: "won",
            names: new Dictionary<string, string> {
                ["en-US"] = "won",
                ["de-DE"] = "gewann" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor won a game.",
                ["de-DE"] = "Ein Akteur gewann ein Spiel." });

        /// <summary>
        /// A actor put some text into a text field.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/verbs/wrote
        /// </summary>
        public readonly xAPI_Verb wrote = new xAPI_Verb(
            context: "generic",
            key: "wrote",
            names: new Dictionary<string, string> {
                ["en-US"] = "wrote",
                ["de-DE"] = "schrieb" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A actor put some text into a text field.",
                ["de-DE"] = "Ein Akteur gab einen Text in ein Textfeld ein." });

        public xAPI_Verbs_Generic() 
            : base("generic") {
        }
    }
}