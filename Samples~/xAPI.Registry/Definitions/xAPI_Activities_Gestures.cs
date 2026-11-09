using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 2 items of the xAPI_Activities of the context gestures as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Gestures : xAPI_Activities {
        /// <summary>
        /// Actors physical (left or right) hand.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/activities/hand
        /// </summary>
        public readonly xAPI_Activity hand = new xAPI_Activity(
            context: "gestures",
            key: "hand",
            names: new Dictionary<string, string> {
                ["en-US"] = "hand",
                ["de-DE"] = "Hand" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actors physical (left or right) hand.",
                ["de-DE"] = "Physikalische (linke oder rechte) Hand vom Akteur." });

        /// <summary>
        /// Actors physical head.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/activities/head
        /// </summary>
        public readonly xAPI_Activity head = new xAPI_Activity(
            context: "gestures",
            key: "head",
            names: new Dictionary<string, string> {
                ["en-US"] = "head",
                ["de-DE"] = "Kopf" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actors physical head.",
                ["de-DE"] = "Physikalische Kopf vom Akteur." });

        public xAPI_Activities_Gestures() 
            : base("gestures") {
        }
    }
}