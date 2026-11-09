using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 15 items of the xAPI_Activities of the context observation as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Observation : xAPI_Activities {
        /// <summary>
        /// Provides 11 items xAPI_Activity of the context 'observation' as public properties.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/mainscores
        /// </summary>
        public readonly xAPI_Activities_Observation_Mainscores mainscores = new xAPI_Activities_Observation_Mainscores();

        /// <summary>
        /// Provides 33 items xAPI_Activity of the context 'observation' as public properties.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/subscores
        /// </summary>
        public readonly xAPI_Activities_Observation_Subscores subscores = new xAPI_Activities_Observation_Subscores();

        /// <summary>
        /// Verb bezieht sich auf Anweisungen
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/anweisungen
        /// </summary>
        public readonly xAPI_Activity anweisungen = new xAPI_Activity(
            context: "observation",
            key: "anweisungen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Anweisungen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Verb bezieht sich auf Anweisungen" });

        /// <summary>
        /// Von Beobachtern durchgeführte Aufgabenerklärung
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/erklaerung
        /// </summary>
        public readonly xAPI_Activity erklaerung = new xAPI_Activity(
            context: "observation",
            key: "erklaerung",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Erklärung" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Von Beobachtern durchgeführte Aufgabenerklärung" });

        /// <summary>
        /// Verb bezieht sich auf das Abgeben der Führung
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/fuehrung_ab
        /// </summary>
        public readonly xAPI_Activity fuehrung_ab = new xAPI_Activity(
            context: "observation",
            key: "fuehrung_ab",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Führung ab" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Verb bezieht sich auf das Abgeben der Führung" });

        /// <summary>
        /// Verb bezieht sich auf das Abgeben des Materials
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/material_ab
        /// </summary>
        public readonly xAPI_Activity material_ab = new xAPI_Activity(
            context: "observation",
            key: "material_ab",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Führung ab" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Verb bezieht sich auf das Abgeben des Materials" });

        /// <summary>
        /// Gegnstände die zum Aufgabenlösen zur Verfügung gestellt werden
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/material
        /// </summary>
        public readonly xAPI_Activity material = new xAPI_Activity(
            context: "observation",
            key: "material",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Material" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Gegnstände die zum Aufgabenlösen zur Verfügung gestellt werden" });

        /// <summary>
        /// Verb bezieht sich auf andere Mitschüler
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/mitschueler
        /// </summary>
        public readonly xAPI_Activity mitschueler = new xAPI_Activity(
            context: "observation",
            key: "mitschueler",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Mitschüler" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Verb bezieht sich auf andere Mitschüler" });

        /// <summary>
        /// Konkreter Gegenstand, der zum Aufgabenlösen zur Verfügung gestellt wurde
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/schere
        /// </summary>
        public readonly xAPI_Activity schere = new xAPI_Activity(
            context: "observation",
            key: "schere",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Schere" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Konkreter Gegenstand, der zum Aufgabenlösen zur Verfügung gestellt wurde" });

        /// <summary>
        /// Verb bezieht sich auf andere Akteure
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/andere
        /// </summary>
        public readonly xAPI_Activity andere = new xAPI_Activity(
            context: "observation",
            key: "andere",
            names: new Dictionary<string, string> {
                ["de-DE"] = "andere" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Verb bezieht sich auf andere Akteure" });

        /// <summary>
        /// aus dem Fenster
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/aus_dem_Fenster
        /// </summary>
        public readonly xAPI_Activity aus_dem_Fenster = new xAPI_Activity(
            context: "observation",
            key: "aus_dem_Fenster",
            names: new Dictionary<string, string> {
                ["de-DE"] = "aus dem Fenster" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "aus dem Fenster" });

        /// <summary>
        /// mit Betrachtung einiger Details
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/es_sich_genauer_an
        /// </summary>
        public readonly xAPI_Activity es_sich_genauer_an = new xAPI_Activity(
            context: "observation",
            key: "es_sich_genauer_an",
            names: new Dictionary<string, string> {
                ["de-DE"] = "es sich genauer an" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "mit Betrachtung einiger Details" });

        /// <summary>
        /// genaure Informationen über Aufgaben
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/nach_Aufgaben_Details
        /// </summary>
        public readonly xAPI_Activity nach_Aufgaben_Details = new xAPI_Activity(
            context: "observation",
            key: "nach_Aufgaben_Details",
            names: new Dictionary<string, string> {
                ["de-DE"] = "nach Aufgaben Details" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "genaure Informationen über Aufgaben" });

        /// <summary>
        /// Von Akteur selbst erbrachte Denkleistung
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/seine_Idee
        /// </summary>
        public readonly xAPI_Activity seine_Idee = new xAPI_Activity(
            context: "observation",
            key: "seine_Idee",
            names: new Dictionary<string, string> {
                ["de-DE"] = "seine Idee" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Von Akteur selbst erbrachte Denkleistung" });

        /// <summary>
        /// Verb bezieht sich auf Objekte, die nichts mit der Aufgabenstellung zutun haben.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/sich_mit_anderen_Dingen
        /// </summary>
        public readonly xAPI_Activity sich_mit_anderen_Dingen = new xAPI_Activity(
            context: "observation",
            key: "sich_mit_anderen_Dingen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "sich mit anderen Dingen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Verb bezieht sich auf Objekte, die nichts mit der Aufgabenstellung zutun haben." });

        public xAPI_Activities_Observation() 
            : base("observation") {
        }
    }
}