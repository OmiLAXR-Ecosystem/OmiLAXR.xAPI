using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 9 items of the xAPI_Verbs of the context observation as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Observation : xAPI_Verbs {
        /// <summary>
        /// Ein Akteur beschäftigt sich mit etwas
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/beschaeftigt
        /// </summary>
        public readonly xAPI_Verb beschaeftigt = new xAPI_Verb(
            context: "observation",
            key: "beschaeftigt",
            names: new Dictionary<string, string> {
                ["de-DE"] = "beschäftigt" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur beschäftigt sich mit etwas" });

        /// <summary>
        /// Ein Akteur erklärt jemand anderen etwas verbal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/erklaert
        /// </summary>
        public readonly xAPI_Verb erklaert = new xAPI_Verb(
            context: "observation",
            key: "erklaert",
            names: new Dictionary<string, string> {
                ["de-DE"] = "erklärt" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur erklärt jemand anderen etwas verbal." });

        /// <summary>
        /// Ein Akteur erzählt etwas verbal
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/erzaehlt
        /// </summary>
        public readonly xAPI_Verb erzaehlt = new xAPI_Verb(
            context: "observation",
            key: "erzaehlt",
            names: new Dictionary<string, string> {
                ["de-DE"] = "erzählt" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur erzählt etwas verbal" });

        /// <summary>
        /// Ein Akteur fragt etwas
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/fragt
        /// </summary>
        public readonly xAPI_Verb fragt = new xAPI_Verb(
            context: "observation",
            key: "fragt",
            names: new Dictionary<string, string> {
                ["de-DE"] = "fragt" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur fragt etwas" });

        /// <summary>
        /// Ein Akteur gibt etwas
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/gibt
        /// </summary>
        public readonly xAPI_Verb gibt = new xAPI_Verb(
            context: "observation",
            key: "gibt",
            names: new Dictionary<string, string> {
                ["de-DE"] = "gibt" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur gibt etwas" });

        /// <summary>
        /// Ein Akteur motiviert jemanden
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/motiviert
        /// </summary>
        public readonly xAPI_Verb motiviert = new xAPI_Verb(
            context: "observation",
            key: "motiviert",
            names: new Dictionary<string, string> {
                ["de-DE"] = "motiviert" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur motiviert jemanden" });

        /// <summary>
        /// Ein Akteur nimmt etwas
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/nimmt
        /// </summary>
        public readonly xAPI_Verb nimmt = new xAPI_Verb(
            context: "observation",
            key: "nimmt",
            names: new Dictionary<string, string> {
                ["de-DE"] = "nimmt" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur nimmt etwas" });

        /// <summary>
        /// Ein Akteur sieht etwas
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/sieht
        /// </summary>
        public readonly xAPI_Verb sieht = new xAPI_Verb(
            context: "observation",
            key: "sieht",
            names: new Dictionary<string, string> {
                ["de-DE"] = "sieht" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur sieht etwas" });

        /// <summary>
        /// Ein Akteur unterbricht jemand oder etwas anderen verbal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/verbs/unterbricht
        /// </summary>
        public readonly xAPI_Verb unterbricht = new xAPI_Verb(
            context: "observation",
            key: "unterbricht",
            names: new Dictionary<string, string> {
                ["de-DE"] = "unterbricht" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Ein Akteur unterbricht jemand oder etwas anderen verbal." });

        public xAPI_Verbs_Observation() 
            : base("observation") {
        }
    }
}