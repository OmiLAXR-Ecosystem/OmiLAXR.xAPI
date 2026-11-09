using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 8 items of the xAPI_Verbs of the context media as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Media : xAPI_Verbs {
        /// <summary>
        /// An actor reached the end of a media element and its playing was stopped by the player itself.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/finished
        /// </summary>
        public readonly xAPI_Verb finished = new xAPI_Verb(
            context: "media",
            key: "finished",
            names: new Dictionary<string, string> {
                ["en-US"] = "finished",
                ["de-DE"] = "beendete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor reached the end of a media element and its playing was stopped by the player itself.",
                ["de-DE"] = "Ein Akteur erreichte das Ende eines Medienelements und der Player beendete die Wiedergabe." });

        /// <summary>
        /// An actor interacted with a media element. This might have changed the elements volume or playback rate.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/interacted
        /// </summary>
        public readonly xAPI_Verb interacted = new xAPI_Verb(
            context: "media",
            key: "interacted",
            names: new Dictionary<string, string> {
                ["en-US"] = "interacted",
                ["de-DE"] = "interagierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor interacted with a media element. This might have changed the elements volume or playback rate.",
                ["de-DE"] = "Ein Akteur interagierte mit einem Medienelement. Das kann z. B. die Anpassung der Lautstärke oder Wiedergabegeschwindigkeit bedeuten." });

        /// <summary>
        /// An actor paused a playing media element.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/paused
        /// </summary>
        public readonly xAPI_Verb paused = new xAPI_Verb(
            context: "media",
            key: "paused",
            names: new Dictionary<string, string> {
                ["en-US"] = "paused",
                ["de-DE"] = "pausierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor paused a playing media element.",
                ["de-DE"] = "Ein Akteur pausierte die Wiedergabe eines Medienelements." });

        /// <summary>
        /// An actor restarted playing a media element after finishing it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/restarted
        /// </summary>
        public readonly xAPI_Verb restarted = new xAPI_Verb(
            context: "media",
            key: "restarted",
            names: new Dictionary<string, string> {
                ["en-US"] = "restarted",
                ["de-DE"] = "startete neu" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor restarted playing a media element after finishing it.",
                ["de-DE"] = "Ein Akteur startete die Wiedergabe eines Medienelements erneut, nachdem diese zuvor beendet wurde." });

        /// <summary>
        /// An actor continued playing a media element.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/resumed
        /// </summary>
        public readonly xAPI_Verb resumed = new xAPI_Verb(
            context: "media",
            key: "resumed",
            names: new Dictionary<string, string> {
                ["en-US"] = "resumed",
                ["de-DE"] = "fortgesetzt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor continued playing a media element.",
                ["de-DE"] = "Ein Akteur setzte die Wiedergabe eines Medienelements fort." });

        /// <summary>
        /// An actor seeked to a part of the media element either forward or backward.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/seeked
        /// </summary>
        public readonly xAPI_Verb seeked = new xAPI_Verb(
            context: "media",
            key: "seeked",
            names: new Dictionary<string, string> {
                ["en-US"] = "seeked",
                ["de-DE"] = "sprang" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor seeked to a part of the media element either forward or backward.",
                ["de-DE"] = "Ein Akteur sprang zu einem Teil eines Medienelements. Entweder einen vorausligenden Teil oder durch einen Sprung zurück, einen zurückliegenden." });

        /// <summary>
        /// An actor skipped a part of the media element either forward or backward. LEGACY! Use seeked instead.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/skipped
        /// </summary>
        public readonly xAPI_Verb skipped = new xAPI_Verb(
            context: "media",
            key: "skipped",
            names: new Dictionary<string, string> {
                ["en-US"] = "skipped",
                ["de-DE"] = "übersprang" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor skipped a part of the media element either forward or backward. LEGACY! Use seeked instead.",
                ["de-DE"] = "Ein Akteur übersprang einen Teil eines Medienelements. Entweder einen vorausligenden Teil oder durch einen Sprung zurück, einen zurückliegenden. VERALTET! Nutze stattdessen sprang (seeked)." });

        /// <summary>
        /// An actor started playing a media element.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "media",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started",
                ["de-DE"] = "startete" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor started playing a media element.",
                ["de-DE"] = "Ein Akteur startete die Wiedergabe eines Medienelements." });

        public xAPI_Verbs_Media() 
            : base("media") {
        }
    }
}