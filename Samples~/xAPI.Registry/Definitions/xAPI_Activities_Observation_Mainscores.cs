using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 11 items of the xAPI_Activities of the context observation as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Observation_Mainscores : xAPI_Activities {
        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Achtsamkeit zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/achtsamkeit
        /// </summary>
        public readonly xAPI_Activity achtsamkeit = new xAPI_Activity(
            context: "observation",
            key: "achtsamkeit",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Achtsamkeit" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Achtsamkeit zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Geduld zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/geduld
        /// </summary>
        public readonly xAPI_Activity geduld = new xAPI_Activity(
            context: "observation",
            key: "geduld",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Geduld" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Geduld zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Kommunikationsfähigkeiten zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kommunikationsfaehigkeiten
        /// </summary>
        public readonly xAPI_Activity kommunikationsfaehigkeiten = new xAPI_Activity(
            context: "observation",
            key: "kommunikationsfaehigkeiten",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Kommunikationsfähigkeiten" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Kommunikationsfähigkeiten zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Kreativität zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/kreativitaet
        /// </summary>
        public readonly xAPI_Activity kreativitaet = new xAPI_Activity(
            context: "observation",
            key: "kreativitaet",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Kreativität" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Kreativität zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Methodisches Potenzial zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/methodisches_Potenzial
        /// </summary>
        public readonly xAPI_Activity methodisches_Potenzial = new xAPI_Activity(
            context: "observation",
            key: "methodisches_Potenzial",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Methodisches Potenzial" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Methodisches Potenzial zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Motivation und Leistungsbereitschaft zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/motivation_und_Leistungsbereitschaft
        /// </summary>
        public readonly xAPI_Activity motivation_und_Leistungsbereitschaft = new xAPI_Activity(
            context: "observation",
            key: "motivation_und_Leistungsbereitschaft",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Motivation und Leistungsbereitschaft" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Motivation und Leistungsbereitschaft zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Praktisches Potenzial zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/praktisches_Potenzial
        /// </summary>
        public readonly xAPI_Activity praktisches_Potenzial = new xAPI_Activity(
            context: "observation",
            key: "praktisches_Potenzial",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Praktisches Potenzial" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Praktisches Potenzial zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Problemlösent zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/problemloesen
        /// </summary>
        public readonly xAPI_Activity problemloesen = new xAPI_Activity(
            context: "observation",
            key: "problemloesen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Problemlösen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Problemlösent zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Räumliches Vorstellungsvermögen zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/raeumliches_Vorstellungsvermoegen
        /// </summary>
        public readonly xAPI_Activity raeumliches_Vorstellungsvermoegen = new xAPI_Activity(
            context: "observation",
            key: "raeumliches_Vorstellungsvermoegen",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Räumliches Vorstellungsvermögen" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Räumliches Vorstellungsvermögen zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Soziale Potenziale zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/soziale_Potenziale
        /// </summary>
        public readonly xAPI_Activity soziale_Potenziale = new xAPI_Activity(
            context: "observation",
            key: "soziale_Potenziale",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Soziale Potenziale" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Soziale Potenziale zeigt" });

        /// <summary>
        /// Mainscore (5/5) wenn ein Akteuer Sprachkompetenz zeigt
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/observation/activities/sprachkompetenz
        /// </summary>
        public readonly xAPI_Activity sprachkompetenz = new xAPI_Activity(
            context: "observation",
            key: "sprachkompetenz",
            names: new Dictionary<string, string> {
                ["de-DE"] = "Sprachkompetenz" },
            descriptions: new Dictionary<string, string> {
                ["de-DE"] = "Mainscore (5/5) wenn ein Akteuer Sprachkompetenz zeigt" });

        public xAPI_Activities_Observation_Mainscores() 
            : base("observation") {
        }
    }
}