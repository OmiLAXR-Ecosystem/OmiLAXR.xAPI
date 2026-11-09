using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 4 items of the xAPI_Activities of the context voice as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Voice : xAPI_Activities {
        /// <summary>
        /// A keyword is a word the actor can use to interact with the system.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/activities/keyword
        /// </summary>
        public readonly xAPI_Activity keyword = new xAPI_Activity(
            context: "voice",
            key: "keyword",
            names: new Dictionary<string, string> {
                ["en-US"] = "keyword",
                ["de-DE"] = "Schlüsselwort" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A keyword is a word the actor can use to interact with the system.",
                ["de-DE"] = "Ein Schlüsselwort ist ein Wort, das für die Interaktion mit dem System genutzt werden kann." });

        /// <summary>
        /// A fixed teleport point in VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/activities/phrase
        /// </summary>
        public readonly xAPI_Activity phrase = new xAPI_Activity(
            context: "voice",
            key: "phrase",
            names: new Dictionary<string, string> {
                ["en-US"] = "teleport point",
                ["de-DE"] = "Teleport Punkt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A fixed teleport point in VR environment.",
                ["de-DE"] = "Ein fester Teleport Punkt in der VR Umgebung." });

        /// <summary>
        /// A question is a specialized sentence, which expresses a problem, a point which need to be considered, a doubt, argument or uncertainty. A question often has a prompting character.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/activities/question
        /// </summary>
        public readonly xAPI_Activity question = new xAPI_Activity(
            context: "voice",
            key: "question",
            names: new Dictionary<string, string> {
                ["en-US"] = "question",
                ["de-DE"] = "Frage" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A question is a specialized sentence, which expresses a problem, a point which need to be considered, a doubt, argument or uncertainty. A question often has a prompting character.",
                ["de-DE"] = "Eine Frage ist ein besonderer Satz, der verschiedene Zwecke verfolgt und eine Aufforderung, Unsicherheit, Idee oder einen ähnliches enthält, häufig mit dem Ziel eine Antwort oder Erklärung zu provozieren." });

        /// <summary>
        /// A sentence is a group of words.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/voice/activities/sentence
        /// </summary>
        public readonly xAPI_Activity sentence = new xAPI_Activity(
            context: "voice",
            key: "sentence",
            names: new Dictionary<string, string> {
                ["en-US"] = "sentence",
                ["de-DE"] = "Satz" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A sentence is a group of words.",
                ["de-DE"] = "Ein Satz besteht aus einer Gruppe von Wörtern." });

        public xAPI_Activities_Voice() 
            : base("voice") {
        }
    }
}