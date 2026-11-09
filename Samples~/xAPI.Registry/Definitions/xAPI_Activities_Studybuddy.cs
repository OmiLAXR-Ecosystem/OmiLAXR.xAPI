using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 7 items of the xAPI_Activities of the context studybuddy as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Studybuddy : xAPI_Activities {
        /// <summary>
        /// Interactions of a user within an LMS client (like a browser tab), e.g., key strokes, mouse movements or clicks, touches.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/clientSideInteraction
        /// </summary>
        public readonly xAPI_Activity clientSideInteraction = new xAPI_Activity(
            context: "studybuddy",
            key: "clientSideInteraction",
            names: new Dictionary<string, string> {
                ["en-US"] = "Client Side Interaction",
                ["de-DE"] = "Clientseitige Interaktion" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Interactions of a user within an LMS client (like a browser tab), e.g., key strokes, mouse movements or clicks, touches.",
                ["de-DE"] = "Nutzerinterationen in einem LMS Client (wie einem Browsertab), z. B. Tastatureingaben, Mausbewegungen oder Klicks, Toucheingaben." });

        /// <summary>
        /// A simple HTML link, leading to another website or resource.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/link
        /// </summary>
        public readonly xAPI_Activity link = new xAPI_Activity(
            context: "studybuddy",
            key: "link",
            names: new Dictionary<string, string> {
                ["en-US"] = "Link",
                ["de-DE"] = "Link" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A simple HTML link, leading to another website or resource.",
                ["de-DE"] = "Ein einfacher HTML Link, der auf eine andere Webseite oder Ressource verweist." });

        /// <summary>
        /// Basis data about a study plan, including the start term, a custom name, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/planBasisData
        /// </summary>
        public readonly xAPI_Activity planBasisData = new xAPI_Activity(
            context: "studybuddy",
            key: "planBasisData",
            names: new Dictionary<string, string> {
                ["en-US"] = "Plan Basis Data",
                ["de-DE"] = "Plan-Basisdaten" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Basis data about a study plan, including the start term, a custom name, ...",
                ["de-DE"] = "Basisdaten eines Studienverlaufsplans. Diese enthalten den Start-Term, einen selbstgesetzten Namen, ..." });

        /// <summary>
        /// The entry data of a study plan, including module positions, placeholder replacements, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/planEntryData
        /// </summary>
        public readonly xAPI_Activity planEntryData = new xAPI_Activity(
            context: "studybuddy",
            key: "planEntryData",
            names: new Dictionary<string, string> {
                ["en-US"] = "Plan Entry Data",
                ["de-DE"] = "Plan-Eintragsdaten" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The entry data of a study plan, including module positions, placeholder replacements, ...",
                ["de-DE"] = "Die Eintragsdaten eines Studienverlaufsplans. Diese enthalten die Modulpositionierungen, Platzhalterersetzungen, ..." });

        /// <summary>
        /// The automated generation of a study plan.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/planGeneration
        /// </summary>
        public readonly xAPI_Activity planGeneration = new xAPI_Activity(
            context: "studybuddy",
            key: "planGeneration",
            names: new Dictionary<string, string> {
                ["en-US"] = "Plan Generation",
                ["de-DE"] = "Plangenerierung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The automated generation of a study plan.",
                ["de-DE"] = "Die automatisierte Generierung eines Studienverlaufsplans." });

        /// <summary>
        /// The interactive study planning tool.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/studybuddy
        /// </summary>
        public readonly xAPI_Activity studybuddy = new xAPI_Activity(
            context: "studybuddy",
            key: "studybuddy",
            names: new Dictionary<string, string> {
                ["en-US"] = "StudyBuddy",
                ["de-DE"] = "StudyBuddy" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The interactive study planning tool.",
                ["de-DE"] = "Der interaktive Studienverlaufsplaner." });

        /// <summary>
        /// An actor's study plan.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/studybuddy/activities/studyplan
        /// </summary>
        public readonly xAPI_Activity studyplan = new xAPI_Activity(
            context: "studybuddy",
            key: "studyplan",
            names: new Dictionary<string, string> {
                ["en-US"] = "Study Plan",
                ["de-DE"] = "Studienverlaufsplan" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor's study plan.",
                ["de-DE"] = "Der Studienverlaufsplan eines Akteurs." });

        public xAPI_Activities_Studybuddy() 
            : base("studybuddy") {
        }
    }
}