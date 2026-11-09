using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 5 items of the xAPI_Activities of the context multitouch as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Multitouch : xAPI_Activities {
        /// <summary>
        /// Something an actor can press, which then triggers an action in the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/activities/button
        /// </summary>
        public readonly xAPI_Activity button = new xAPI_Activity(
            context: "multitouch",
            key: "button",
            names: new Dictionary<string, string> {
                ["en-US"] = "button",
                ["de-DE"] = "Knopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something an actor can press, which then triggers an action in the game.",
                ["de-DE"] = "Etwas was ein Akteur drücken kann, was dann eine Aktion im Spiel hervorruft." });

        /// <summary>
        /// Something which can be collected inside the game to fullfill a task or goal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/activities/collectable
        /// </summary>
        public readonly xAPI_Activity collectable = new xAPI_Activity(
            context: "multitouch",
            key: "collectable",
            names: new Dictionary<string, string> {
                ["en-US"] = "collectable",
                ["de-DE"] = "einsammelbares Objekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something which can be collected inside the game to fullfill a task or goal.",
                ["de-DE"] = "Ein Objekt, welches im Spiel eingesammelt werden kann um ein Spielziel zu erreichen oder eine Aufgabe zu erfüllen." });

        /// <summary>
        /// Something that can be dragged across the screen in the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/activities/draggable
        /// </summary>
        public readonly xAPI_Activity draggable = new xAPI_Activity(
            context: "multitouch",
            key: "draggable",
            names: new Dictionary<string, string> {
                ["en-US"] = "draggable",
                ["de-DE"] = "ziehbares Objekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something that can be dragged across the screen in the game.",
                ["de-DE"] = "Etwas was im Spiel über den Bildschirm gezogen werden kann." });

        /// <summary>
        /// Something a player can interact with in the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/activities/interactable
        /// </summary>
        public readonly xAPI_Activity interactable = new xAPI_Activity(
            context: "multitouch",
            key: "interactable",
            names: new Dictionary<string, string> {
                ["en-US"] = "interactable",
                ["de-DE"] = "interagierfähiges Objekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something a player can interact with in the game.",
                ["de-DE"] = "Etwas womit der Spieler im Spiel interagieren kann." });

        /// <summary>
        /// The screen showing the game and being clicked or touched on for interaction with the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/activities/screen
        /// </summary>
        public readonly xAPI_Activity screen = new xAPI_Activity(
            context: "multitouch",
            key: "screen",
            names: new Dictionary<string, string> {
                ["en-US"] = "screen",
                ["de-DE"] = "Bildschirm" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The screen showing the game and being clicked or touched on for interaction with the game.",
                ["de-DE"] = "Der Bildschirm der das Spiel anzeigt und auf dem geklickt werden kann oder der berührt wird um mit dem Spiel zu interagieren." });

        public xAPI_Activities_Multitouch() 
            : base("multitouch") {
        }
    }
}