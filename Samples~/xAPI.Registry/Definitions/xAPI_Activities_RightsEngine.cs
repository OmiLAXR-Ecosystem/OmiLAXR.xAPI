using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 7 items of the xAPI_Activities of the context rightsEngine as public properties.
    /// </summary>
    public sealed class xAPI_Activities_RightsEngine : xAPI_Activities {
        /// <summary>
        /// A JSON-based representation of a user's consent for the collection of single data logs and analyses. Always linked to exactly one schema.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/consent
        /// </summary>
        public readonly xAPI_Activity consent = new xAPI_Activity(
            context: "rightsEngine",
            key: "consent",
            names: new Dictionary<string, string> {
                ["en-US"] = "Consent",
                ["de-DE"] = "Zustimmung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A JSON-based representation of a user's consent for the collection of single data logs and analyses. Always linked to exactly one schema.",
                ["de-DE"] = "Eine JSON-basierte Repräsentation der Zustimmung eines Akteurs zur Sammlung einzelner Datenpunkte und Analysen. Immer mit genau einem Schema verknüpft." });

        /// <summary>
        /// A cross provider schema defines the intended, combined data collection and analyses across multiple (at least two) single providers.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/crossProviderSchema
        /// </summary>
        public readonly xAPI_Activity crossProviderSchema = new xAPI_Activity(
            context: "rightsEngine",
            key: "crossProviderSchema",
            names: new Dictionary<string, string> {
                ["en-US"] = "Cross Provider Schema",
                ["de-DE"] = "Providerübergreifendes Schema" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A cross provider schema defines the intended, combined data collection and analyses across multiple (at least two) single providers.",
                ["de-DE"] = "Ein Providerübergreifendes Schema listet die intendierte, kombinierte Datensammlung und die Analysen für mehrere (mindestens zwei) Provider auf." });

        /// <summary>
        /// A version of a cross provider schema defines the intended, combined data collection and analyses across multiple (at least two) single providers. Different versions of a cross-provider schema can differ in terms of the providers, provider contexts, verbs, objects, analyses or translations and descriptions they contain.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/crossProviderSchemaVersion
        /// </summary>
        public readonly xAPI_Activity crossProviderSchemaVersion = new xAPI_Activity(
            context: "rightsEngine",
            key: "crossProviderSchemaVersion",
            names: new Dictionary<string, string> {
                ["en-US"] = "Cross Provider Schema Version",
                ["de-DE"] = "Providerübergreifende Schema Version" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A version of a cross provider schema defines the intended, combined data collection and analyses across multiple (at least two) single providers. Different versions of a cross-provider schema can differ in terms of the providers, provider contexts, verbs, objects, analyses or translations and descriptions they contain.",
                ["de-DE"] = "Ein Version eines providerübergreifenden Schemas listet die intendierte, kombinierte Datensammlung und die Analysen für mehrere (mindestens zwei) Provider auf. Verschiedene Versionen eines providerübergreifenden Schemas können sich in Bezug auf die enthaltenen Provider, Provider-Kontexte, Verben, Objekte, Analysen oder Übersetzungen und Beschreibungen unterscheiden." });

        /// <summary>
        /// A provider collecting data as xAPI statements and sending these statements to a Rights Engine. A provider may have multiple associated contexts and schema versions.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/provider
        /// </summary>
        public readonly xAPI_Activity provider = new xAPI_Activity(
            context: "rightsEngine",
            key: "provider",
            names: new Dictionary<string, string> {
                ["en-US"] = "Provider",
                ["de-DE"] = "Provider" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A provider collecting data as xAPI statements and sending these statements to a Rights Engine. A provider may have multiple associated contexts and schema versions.",
                ["de-DE"] = "Ein Provider, welcher Daten als xAPI Statements sammelt und an eine Rights Engine sendet. Ein Provider kann mehrere zugeordnete Kontexte sowie Schemaversionen haben." });

        /// <summary>
        /// A context of a provider. This can be a course, a profile, a subpage, etc.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/providerContext
        /// </summary>
        public readonly xAPI_Activity providerContext = new xAPI_Activity(
            context: "rightsEngine",
            key: "providerContext",
            names: new Dictionary<string, string> {
                ["en-US"] = "Provider Context",
                ["de-DE"] = "Provider-Kontext" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A context of a provider. This can be a course, a profile, a subpage, etc.",
                ["de-DE"] = "Ein Kontext eines Providers. Dies kann ein Kurs, ein Profil, eine Unterseite, etc. sein." });

        /// <summary>
        /// A Rights Engine managing consent to provider schemas and providing functionalities for data disclosure and data removal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/rightsEngine
        /// </summary>
        public readonly xAPI_Activity rightsEngine = new xAPI_Activity(
            context: "rightsEngine",
            key: "rightsEngine",
            names: new Dictionary<string, string> {
                ["en-US"] = "Rights Engine",
                ["de-DE"] = "Rights Engine" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A Rights Engine managing consent to provider schemas and providing functionalities for data disclosure and data removal.",
                ["de-DE"] = "Eine Rights Engine, welche Zustimmungen zu Provider Schemas verwaltet sowie Funktionalitäten für Datenauskünfte und Datenlöschung bereitstellt." });

        /// <summary>
        /// A version of a single provider schema defines the intended data collection and analyses for a single provider, a single platform. Different versions of a schema for the same provider can differ in terms of the verbs, objects, analyses or translations and descriptions they contain.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/rightsEngine/activities/singleProviderSchemaVersion
        /// </summary>
        public readonly xAPI_Activity singleProviderSchemaVersion = new xAPI_Activity(
            context: "rightsEngine",
            key: "singleProviderSchemaVersion",
            names: new Dictionary<string, string> {
                ["en-US"] = "Single Provider Schema Version",
                ["de-DE"] = "Einzel-Provider Schema Version" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A version of a single provider schema defines the intended data collection and analyses for a single provider, a single platform. Different versions of a schema for the same provider can differ in terms of the verbs, objects, analyses or translations and descriptions they contain.",
                ["de-DE"] = "Ein Version eines Einzel-Provider Schema listet die intendierte Datensammlung und die Analysen für einen einzelnen Provider, eine einzelne Plattform, auf. Verschiedene Versionen eines Schemas für einen Provider können sich in Bezug auf die enthaltenen Verben, Objekte, Analysen oder Übersetzungen und Beschreibungen unterscheiden." });

        public xAPI_Activities_RightsEngine() 
            : base("rightsEngine") {
        }
    }
}