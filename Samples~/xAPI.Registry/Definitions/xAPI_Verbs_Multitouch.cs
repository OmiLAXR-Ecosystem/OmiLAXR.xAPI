using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 12 items of the xAPI_Verbs of the context multitouch as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Multitouch : xAPI_Verbs {
        /// <summary>
        /// An actor clicked on something on the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "multitouch",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked",
                ["de-DE"] = "klickte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor clicked on something on the screen.",
                ["de-DE"] = "Ein Akteur klickte auf ein Objekt auf dem Bildschirm." });

        /// <summary>
        /// An actor clicked two times at the same spot in a short time period. Can also bve done with a finger or tangible.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/doubleclicked
        /// </summary>
        public readonly xAPI_Verb doubleclicked = new xAPI_Verb(
            context: "multitouch",
            key: "doubleclicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "doubleclicked",
                ["de-DE"] = "doppelklickte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor clicked two times at the same spot in a short time period. Can also bve done with a finger or tangible.",
                ["de-DE"] = "Ein Akteur klickte zwei mal auf den selben Punkt kurz hintereinander. Kann auch mit dem Finger oder einem Tangible gemacht werden." });

        /// <summary>
        /// An actor dragged a draggable object across the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/dragged
        /// </summary>
        public readonly xAPI_Verb dragged = new xAPI_Verb(
            context: "multitouch",
            key: "dragged",
            names: new Dictionary<string, string> {
                ["en-US"] = "dragged",
                ["de-DE"] = "zog" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor dragged a draggable object across the screen.",
                ["de-DE"] = "Ein Akteur zog ein ziehbares Objekt über den Bildschirm." });

        /// <summary>
        /// An actor dragged a draggable across the screen and let it go of further without guidence.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/flicked
        /// </summary>
        public readonly xAPI_Verb flicked = new xAPI_Verb(
            context: "multitouch",
            key: "flicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "flicked",
                ["de-DE"] = "schnippte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor dragged a draggable across the screen and let it go of further without guidence.",
                ["de-DE"] = "Ein Akteur zog ein ziehbares Objekt über den Bildschirm und lies es in der Bewegung los was dazu führte, dass das Objekt sich weiter bewegte." });

        /// <summary>
        /// An actor interacted with the game or an game object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/interacted
        /// </summary>
        public readonly xAPI_Verb interacted = new xAPI_Verb(
            context: "multitouch",
            key: "interacted",
            names: new Dictionary<string, string> {
                ["en-US"] = "interacted",
                ["de-DE"] = "interagierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor interacted with the game or an game object.",
                ["de-DE"] = "Ein Akteur interagierte mit dem Spiel oder einem Objekt im Spiel." });

        /// <summary>
        /// An actor held down the mousebutton, a finger or a tangible at one spot. How much time has to pass until a press becomes a longpress is up to the user.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/longpressed
        /// </summary>
        public readonly xAPI_Verb longpressed = new xAPI_Verb(
            context: "multitouch",
            key: "longpressed",
            names: new Dictionary<string, string> {
                ["en-US"] = "longpressed",
                ["de-DE"] = "hielt gedrückt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor held down the mousebutton, a finger or a tangible at one spot. How much time has to pass until a press becomes a longpress is up to the user.",
                ["de-DE"] = "Ein Akteur hielt eine Maustaste, einen Finger oder ein Tangible länger auf einem Punkt gedrückt. Wie lange es dauert bis ein drücken ein gedrückt halten wird ist dem Nutzer überlassen." });

        /// <summary>
        /// An actor mirrored some game object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/mirrored
        /// </summary>
        public readonly xAPI_Verb mirrored = new xAPI_Verb(
            context: "multitouch",
            key: "mirrored",
            names: new Dictionary<string, string> {
                ["en-US"] = "mirrored",
                ["de-DE"] = "spiegelte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor mirrored some game object.",
                ["de-DE"] = "Ein Akteur spiegelte ein Spiel Objekt." });

        /// <summary>
        /// An actor activated a button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/pressed
        /// </summary>
        public readonly xAPI_Verb pressed = new xAPI_Verb(
            context: "multitouch",
            key: "pressed",
            names: new Dictionary<string, string> {
                ["en-US"] = "pressed",
                ["de-DE"] = "drückte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor activated a button.",
                ["de-DE"] = "Ein Akteur aktivierte einen Knopf." });

        /// <summary>
        /// An actor rotated a game object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/rotated
        /// </summary>
        public readonly xAPI_Verb rotated = new xAPI_Verb(
            context: "multitouch",
            key: "rotated",
            names: new Dictionary<string, string> {
                ["en-US"] = "rotated",
                ["de-DE"] = "rotierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor rotated a game object.",
                ["de-DE"] = "Ein Akteur rotierte ein Spiel Objekt." });

        /// <summary>
        /// An actor touched the screen or something on the screen with a finger or tangible.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/touched
        /// </summary>
        public readonly xAPI_Verb touched = new xAPI_Verb(
            context: "multitouch",
            key: "touched",
            names: new Dictionary<string, string> {
                ["en-US"] = "touched",
                ["de-DE"] = "berührte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor touched the screen or something on the screen with a finger or tangible.",
                ["de-DE"] = "Ein Akteur berührte den Bildschirm oder etwas auf dem Bildschirm mit einem Finger oder Tangible." });

        /// <summary>
        /// An actor zoomed into some visual part of the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/zoomedIn
        /// </summary>
        public readonly xAPI_Verb zoomedIn = new xAPI_Verb(
            context: "multitouch",
            key: "zoomedIn",
            names: new Dictionary<string, string> {
                ["en-US"] = "zoomed in",
                ["de-DE"] = "vergrößerte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor zoomed into some visual part of the game.",
                ["de-DE"] = "Ein Akteur vergrößerte einen sichtbaren Teil des Spiels." });

        /// <summary>
        /// An actor zoomed out of some visual part of the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/multitouch/verbs/zoomedOut
        /// </summary>
        public readonly xAPI_Verb zoomedOut = new xAPI_Verb(
            context: "multitouch",
            key: "zoomedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "zoomed out",
                ["de-DE"] = "verkleinerte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor zoomed out of some visual part of the game.",
                ["de-DE"] = "Ein Akteur verkleinerte einen sichtbaren Teil des Spiels." });

        public xAPI_Verbs_Multitouch() 
            : base("multitouch") {
        }
    }
}