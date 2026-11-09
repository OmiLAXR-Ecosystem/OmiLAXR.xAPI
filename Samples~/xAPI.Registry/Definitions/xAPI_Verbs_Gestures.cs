using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 5 items of the xAPI_Verbs of the context gestures as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Gestures : xAPI_Verbs {
        /// <summary>
        /// An actor has gazed a part of her body in a direction.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/verbs/gazed
        /// </summary>
        public readonly xAPI_Verb gazed = new xAPI_Verb(
            context: "gestures",
            key: "gazed",
            names: new Dictionary<string, string> {
                ["en-US"] = "gazed",
                ["de-DE"] = "richtete aus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has gazed a part of her body in a direction.",
                ["de-DE"] = "Eine Akteurin richtete ihr Körperteil in eine Richtung aus." });

        /// <summary>
        /// An actor has gestured with part of her body (e.g. hands, feets, ...).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/verbs/gestured
        /// </summary>
        public readonly xAPI_Verb gestured = new xAPI_Verb(
            context: "gestures",
            key: "gestured",
            names: new Dictionary<string, string> {
                ["en-US"] = "gestured",
                ["de-DE"] = "gestikulierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has gestured with part of her body (e.g. hands, feets, ...).",
                ["de-DE"] = "Eine Akteurin gestikulierte mit einem ihrer Körperteile (z.B. Hände, Füße, ...)." });

        /// <summary>
        /// An actor has nodded with her head. Could be collected by computation of headset movement or a webcam or by hand annotation.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/verbs/nodded
        /// </summary>
        public readonly xAPI_Verb nodded = new xAPI_Verb(
            context: "gestures",
            key: "nodded",
            names: new Dictionary<string, string> {
                ["en-US"] = "nodding",
                ["de-DE"] = "nickte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has nodded with her head. Could be collected by computation of headset movement or a webcam or by hand annotation.",
                ["de-DE"] = "Eine Akteurin nickte mit ihrem Kopf. Könnte zum Beispiel erkannt worden sein, indem Headset Daten ausgewertet wurden, eine Erkennung in einem Video geschehen ist oder durch eine händische Annotation." });

        /// <summary>
        /// An actor performed something, e.g. a gesture
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/verbs/performed
        /// </summary>
        public readonly xAPI_Verb performed = new xAPI_Verb(
            context: "gestures",
            key: "performed",
            names: new Dictionary<string, string> {
                ["en-US"] = "performed",
                ["de-DE"] = "verrichtete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor performed something, e.g. a gesture",
                ["de-DE"] = "Ein Akteur hat etwas getan, z.B. eine Geste verrichtet." });

        /// <summary>
        /// An actor has shaked something, for example a part of her body.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/gestures/verbs/shaked
        /// </summary>
        public readonly xAPI_Verb shaked = new xAPI_Verb(
            context: "gestures",
            key: "shaked",
            names: new Dictionary<string, string> {
                ["en-US"] = "shaked",
                ["de-DE"] = "schüttelte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has shaked something, for example a part of her body.",
                ["de-DE"] = "Eine Akteurin schüttelte etwas, zum Beispiel einen Körperteil wie ihren Kopf." });

        public xAPI_Verbs_Gestures() 
            : base("gestures") {
        }
    }
}