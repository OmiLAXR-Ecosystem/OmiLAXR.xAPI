using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 17 items of the xAPI_Verbs of the context ide as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Ide : xAPI_Verbs {
        /// <summary>
        /// An actor changed something in the IDE (an asset for example).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/changed
        /// </summary>
        public readonly xAPI_Verb changed = new xAPI_Verb(
            context: "ide",
            key: "changed",
            names: new Dictionary<string, string> {
                ["en-US"] = "changed",
                ["de-DE"] = "änderte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor changed something in the IDE (an asset for example).",
                ["de-DE"] = "Ein Akteur änderte etwas in der IDE (ein Asset zum Beispiel)." });

        /// <summary>
        /// An actor has clicked a button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "ide",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked",
                ["de-DE"] = "klickte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has clicked a button.",
                ["de-DE"] = "Ein Akteur klickte einen Knopf." });

        /// <summary>
        /// Actor closed a application, asset, video, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/closed
        /// </summary>
        public readonly xAPI_Verb closed = new xAPI_Verb(
            context: "ide",
            key: "closed",
            names: new Dictionary<string, string> {
                ["en-US"] = "closed",
                ["de-DE"] = "schloss" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor closed a application, asset, video, ...",
                ["de-DE"] = "Akteur hat eine Applikation, ein Asset, ein Video, ... geschlossen." });

        /// <summary>
        /// An actor has created a component or asset.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/created
        /// </summary>
        public readonly xAPI_Verb created = new xAPI_Verb(
            context: "ide",
            key: "created",
            names: new Dictionary<string, string> {
                ["en-US"] = "created",
                ["de-DE"] = "erstellte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has created a component or asset.",
                ["de-DE"] = "Ein Akteur erstellte eine Komponente oder Asset." });

        /// <summary>
        /// An actor has entered a window with the mouse.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/entered
        /// </summary>
        public readonly xAPI_Verb entered = new xAPI_Verb(
            context: "ide",
            key: "entered",
            names: new Dictionary<string, string> {
                ["en-US"] = "entered",
                ["de-DE"] = "betrat" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has entered a window with the mouse.",
                ["de-DE"] = "Ein Akteur betrat ein Fenster mit der Maus." });

        /// <summary>
        /// An actor has focused a control element or window.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/focused
        /// </summary>
        public readonly xAPI_Verb focused = new xAPI_Verb(
            context: "ide",
            key: "focused",
            names: new Dictionary<string, string> {
                ["en-US"] = "focused",
                ["de-DE"] = "fokussierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has focused a control element or window.",
                ["de-DE"] = "Ein Akteur fokussierte ein Kontrollelement oder ein Fenster." });

        /// <summary>
        /// An actor initialized a game session. This verb is only used with the gamesession activity for better session tracking.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/initialized
        /// </summary>
        public readonly xAPI_Verb initialized = new xAPI_Verb(
            context: "ide",
            key: "initialized",
            names: new Dictionary<string, string> {
                ["en-US"] = "initialized",
                ["de-DE"] = "initialisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor initialized a game session. This verb is only used with the gamesession activity for better session tracking.",
                ["de-DE"] = "Ein Akteur initialisierte eine Spiel Instanz. Dieses Verb wird nur mit der gamesession Aktivität verwendet, um Spiel Instanzen besser verfolgen zu können." });

        /// <summary>
        /// An actor has left a window with the mouse.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/left
        /// </summary>
        public readonly xAPI_Verb left = new xAPI_Verb(
            context: "ide",
            key: "left",
            names: new Dictionary<string, string> {
                ["en-US"] = "left",
                ["de-DE"] = "verließ" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has left a window with the mouse.",
                ["de-DE"] = "Ein Akteur verließ ein Fenster mit der Maus." });

        /// <summary>
        /// An actor loaded something in the IDE (an asset for example).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/loaded
        /// </summary>
        public readonly xAPI_Verb loaded = new xAPI_Verb(
            context: "ide",
            key: "loaded",
            names: new Dictionary<string, string> {
                ["en-US"] = "loaded",
                ["de-DE"] = "lud" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor loaded something in the IDE (an asset for example).",
                ["de-DE"] = "Ein Akteur lud etwas in der IDE (ein Asset zum Beispiel)." });

        /// <summary>
        /// Actor accessed/viewed a application, asset, video, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/opened
        /// </summary>
        public readonly xAPI_Verb opened = new xAPI_Verb(
            context: "ide",
            key: "opened",
            names: new Dictionary<string, string> {
                ["en-US"] = "opened",
                ["de-DE"] = "öffnete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor accessed/viewed a application, asset, video, ...",
                ["de-DE"] = "Akteur hat eine Applikation, ein Asset, ein Video, ... geöffnet." });

        /// <summary>
        /// An actor has removed a component or asset.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/removed
        /// </summary>
        public readonly xAPI_Verb removed = new xAPI_Verb(
            context: "ide",
            key: "removed",
            names: new Dictionary<string, string> {
                ["en-US"] = "removed",
                ["de-DE"] = "entfernte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has removed a component or asset.",
                ["de-DE"] = "Ein Akteur entfernte eine Komponente oder Asset." });

        /// <summary>
        /// An actor saved something in the IDE (an asset for example).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/saved
        /// </summary>
        public readonly xAPI_Verb saved = new xAPI_Verb(
            context: "ide",
            key: "saved",
            names: new Dictionary<string, string> {
                ["en-US"] = "saved",
                ["de-DE"] = "speicherte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor saved something in the IDE (an asset for example).",
                ["de-DE"] = "Ein Akteur speicherte etwas in der IDE (ein Asset zum Beispiel)." });

        /// <summary>
        /// An actor has searched in a search field.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/searched
        /// </summary>
        public readonly xAPI_Verb searched = new xAPI_Verb(
            context: "ide",
            key: "searched",
            names: new Dictionary<string, string> {
                ["en-US"] = "searched",
                ["de-DE"] = "searched" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has searched in a search field.",
                ["de-DE"] = "Ein Akteur suchte in einem Suchfeld." });

        /// <summary>
        /// An actor has selected a control element or window.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/selected
        /// </summary>
        public readonly xAPI_Verb selected = new xAPI_Verb(
            context: "ide",
            key: "selected",
            names: new Dictionary<string, string> {
                ["en-US"] = "selected",
                ["de-DE"] = "selektierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has selected a control element or window.",
                ["de-DE"] = "Ein Akteur selektierte ein Kontrollelement oder ein Fenster." });

        /// <summary>
        /// An actor started a plugin or application.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "ide",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started",
                ["de-DE"] = "startete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor started a plugin or application.",
                ["de-DE"] = "Ein Akteur startete ein Plugin oder eine Applikation." });

        /// <summary>
        /// An actor has unfocused a control element or window.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/unfocused
        /// </summary>
        public readonly xAPI_Verb unfocused = new xAPI_Verb(
            context: "ide",
            key: "unfocused",
            names: new Dictionary<string, string> {
                ["en-US"] = "unfocused",
                ["de-DE"] = "entfokussierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has unfocused a control element or window.",
                ["de-DE"] = "Ein Akteur entfokussierte ein Kontrollelement oder ein Fenster." });

        /// <summary>
        /// An actor has unselected a control element or window.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/verbs/unselected
        /// </summary>
        public readonly xAPI_Verb unselected = new xAPI_Verb(
            context: "ide",
            key: "unselected",
            names: new Dictionary<string, string> {
                ["en-US"] = "unselected",
                ["de-DE"] = "entselektierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has unselected a control element or window.",
                ["de-DE"] = "Ein Akteur entselektierte ein Kontrollelement oder ein Fenster." });

        public xAPI_Verbs_Ide() 
            : base("ide") {
        }
    }
}