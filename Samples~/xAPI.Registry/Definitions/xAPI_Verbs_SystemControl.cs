using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 12 items of the xAPI_Verbs of the context systemControl as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_SystemControl : xAPI_Verbs {
        /// <summary>
        /// An actor ended a session, game or level without completing it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/canceled
        /// </summary>
        public readonly xAPI_Verb canceled = new xAPI_Verb(
            context: "systemControl",
            key: "canceled",
            names: new Dictionary<string, string> {
                ["en-US"] = "canceled",
                ["de-DE"] = "brach ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor ended a session, game or level without completing it.",
                ["de-DE"] = "Ein Akteur brach eine Spiel Instanz, ein Spiel oder ein Level ab ohne es zu vollenden." });

        /// <summary>
        /// An actor ended a game session. This verb is only used with the gamesession activity for better session tracking.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/ended
        /// </summary>
        public readonly xAPI_Verb ended = new xAPI_Verb(
            context: "systemControl",
            key: "ended",
            names: new Dictionary<string, string> {
                ["en-US"] = "ended",
                ["de-DE"] = "beendete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor ended a game session. This verb is only used with the gamesession activity for better session tracking.",
                ["de-DE"] = "Ein Akteur beendete eine Spiel Instanz. Dieses Verb wird nur mit der gamesession Aktivität verwendet, um Spiel Instanzen besser verfolgen zu können." });

        /// <summary>
        /// A player finished an activity in a game session. This could be the game itself, a level or stage for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/finished
        /// </summary>
        public readonly xAPI_Verb finished = new xAPI_Verb(
            context: "systemControl",
            key: "finished",
            names: new Dictionary<string, string> {
                ["en-US"] = "finished",
                ["de-DE"] = "schloss ab" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A player finished an activity in a game session. This could be the game itself, a level or stage for example.",
                ["de-DE"] = "Ein Spieler schloss eine Aktivität in einer Spielinstanz ab. Dies könnte zum Beispiel ein Spiel, ein Level oder ein Spielabschnitt sein." });

        /// <summary>
        /// The user changes a component, so that it's focussed. The user selects the component to receive input from the user by an event such as a mouse button click or keypress.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/focused
        /// </summary>
        public readonly xAPI_Verb focused = new xAPI_Verb(
            context: "systemControl",
            key: "focused",
            names: new Dictionary<string, string> {
                ["en-US"] = "focused",
                ["de-DE"] = "fokussierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The user changes a component, so that it's focussed. The user selects the component to receive input from the user by an event such as a mouse button click or keypress.",
                ["de-DE"] = "Der Nutzende verändert ein Element einer grafischen Benutzeroberflächen, sodass es im Fokus ist und zum Beispiel Tastatureingaben oder Mausevents aufnimmt." });

        /// <summary>
        /// An actor initialized a game session. This verb is only used with the gamesession activity for better session tracking.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/initialized
        /// </summary>
        public readonly xAPI_Verb initialized = new xAPI_Verb(
            context: "systemControl",
            key: "initialized",
            names: new Dictionary<string, string> {
                ["en-US"] = "initialized",
                ["de-DE"] = "initialisierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor initialized a game session. This verb is only used with the gamesession activity for better session tracking.",
                ["de-DE"] = "Ein Akteur initialisierte eine Spielinstanz. Dieses Verb wird nur mit der gamesession Aktivität verwendet, um Spielinstanzen besser verfolgen zu können." });

        /// <summary>
        /// An actor loaded something in the game (a level or menu for example).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/loaded
        /// </summary>
        public readonly xAPI_Verb loaded = new xAPI_Verb(
            context: "systemControl",
            key: "loaded",
            names: new Dictionary<string, string> {
                ["en-US"] = "loaded",
                ["de-DE"] = "lud" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor loaded something in the game (a level or menu for example).",
                ["de-DE"] = "Ein Akteur hat etwas im Spiel geladen. Dies kann zum Beispiel ein Menü oder Level sein." });

        /// <summary>
        /// A player logged into a session.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/loggedIn
        /// </summary>
        public readonly xAPI_Verb loggedIn = new xAPI_Verb(
            context: "systemControl",
            key: "loggedIn",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged In",
                ["de-DE"] = "loggte sich ein" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A player logged into a session.",
                ["de-DE"] = "Ein Spieler loggte sich in eine Spiel Instanz ein." });

        /// <summary>
        /// A player logged out of a session.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/loggedOut
        /// </summary>
        public readonly xAPI_Verb loggedOut = new xAPI_Verb(
            context: "systemControl",
            key: "loggedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "logged out",
                ["de-DE"] = "loggte sich aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A player logged out of a session.",
                ["de-DE"] = "Ein Spieler loggte sich aus einer Spiel Instanz aus." });

        /// <summary>
        /// An actor paused an activity in a game session.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/paused
        /// </summary>
        public readonly xAPI_Verb paused = new xAPI_Verb(
            context: "systemControl",
            key: "paused",
            names: new Dictionary<string, string> {
                ["en-US"] = "paused",
                ["de-DE"] = "pausierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor paused an activity in a game session.",
                ["de-DE"] = "Ein Akteur pausierte eine Aktivität in einer Spiel Instanz." });

        /// <summary>
        /// An actor resumed an activity in a game session.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/resumed
        /// </summary>
        public readonly xAPI_Verb resumed = new xAPI_Verb(
            context: "systemControl",
            key: "resumed",
            names: new Dictionary<string, string> {
                ["en-US"] = "resumed",
                ["de-DE"] = "setzte fort" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor resumed an activity in a game session.",
                ["de-DE"] = "Ein Akteur setzte eine Aktivität in einer Spiel Instanz fort." });

        /// <summary>
        /// A player started an activity in a game session. This could be the game itself, a level or a stage for example.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "systemControl",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started",
                ["de-DE"] = "startete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A player started an activity in a game session. This could be the game itself, a level or a stage for example.",
                ["de-DE"] = "Ein Spieler startete eine Aktivität in einer Spielinstanz. Dies könnte zum Beispiel ein Spiel selber sein, ein Level oder ein Spielabschnitt." });

        /// <summary>
        /// The user changes a component, so that it's unfocused. The user selects another component to receive input from the user by an event such as a mouse button click or keypress.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/verbs/unfocused
        /// </summary>
        public readonly xAPI_Verb unfocused = new xAPI_Verb(
            context: "systemControl",
            key: "unfocused",
            names: new Dictionary<string, string> {
                ["en-US"] = "unfocused",
                ["de-DE"] = "entfokussierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The user changes a component, so that it's unfocused. The user selects another component to receive input from the user by an event such as a mouse button click or keypress.",
                ["de-DE"] = "Der Nutzende verändert ein Element einer grafischen Benutzeroberflächen, sodass es im nicht im Fokus ist, sodass es keine (zum Beispiel) Tastatureingaben oder Mausevents aufnimmt." });

        public xAPI_Verbs_SystemControl() 
            : base("systemControl") {
        }
    }
}