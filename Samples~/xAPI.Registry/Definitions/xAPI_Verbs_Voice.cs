using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 5 items of the xAPI_Verbs of the context voice as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Voice : xAPI_Verbs {
        /// <summary>
        /// An actor asked something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/verbs/asked
        /// </summary>
        public readonly xAPI_Verb asked = new xAPI_Verb(
            context: "voice",
            key: "asked",
            names: new Dictionary<string, string> {
                ["en-US"] = "asked",
                ["de-DE"] = "fragte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor asked something.",
                ["de-DE"] = "Eine Akteurin hat etwas gefragt." });

        /// <summary>
        /// An actor has commanded with his or her voice, which was recorded with speech recognition or annotated by hand.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/verbs/commanded
        /// </summary>
        public readonly xAPI_Verb commanded = new xAPI_Verb(
            context: "voice",
            key: "commanded",
            names: new Dictionary<string, string> {
                ["en-US"] = "commanded",
                ["de-DE"] = "befahl" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has commanded with his or her voice, which was recorded with speech recognition or annotated by hand.",
                ["de-DE"] = "Eine Akteurin hat ein verbales Kommando gegeben, das von der Spracherkennung oder durch händische Bearbeitung von Daten erfasst wurde." });

        /// <summary>
        /// An actor has interrupted someone/ cut someone off.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/verbs/interrupted
        /// </summary>
        public readonly xAPI_Verb interrupted = new xAPI_Verb(
            context: "voice",
            key: "interrupted",
            names: new Dictionary<string, string> {
                ["en-US"] = "interrupted",
                ["de-DE"] = "unterbrach" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has interrupted someone/ cut someone off.",
                ["de-DE"] = "Eine Akteurin hat jemanden unterbrochen/ ist jemandem ins Wort gefallen." });

        /// <summary>
        /// An actor has mumbled something, which was not recognizable.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/verbs/mumbled
        /// </summary>
        public readonly xAPI_Verb mumbled = new xAPI_Verb(
            context: "voice",
            key: "mumbled",
            names: new Dictionary<string, string> {
                ["en-US"] = "mumbled",
                ["de-DE"] = "nuschelte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has mumbled something, which was not recognizable.",
                ["de-DE"] = "Eine Akteurin hat etwas genuschelt, was nicht näher beschrieben werden kann." });

        /// <summary>
        /// An actor said something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/verbs/said
        /// </summary>
        public readonly xAPI_Verb said = new xAPI_Verb(
            context: "voice",
            key: "said",
            names: new Dictionary<string, string> {
                ["en-US"] = "said",
                ["de-DE"] = "sagte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor said something.",
                ["de-DE"] = "Eine Akteurin hat etwas gesagt." });

        public xAPI_Verbs_Voice() 
            : base("voice") {
        }
    }
}