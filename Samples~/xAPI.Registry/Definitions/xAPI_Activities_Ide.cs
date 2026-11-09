using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 7 items of the xAPI_Activities of the context ide as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Ide : xAPI_Activities {
        /// <summary>
        /// An application is a specialized software program designed for a specific purpose.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/application
        /// </summary>
        public readonly xAPI_Activity application = new xAPI_Activity(
            context: "ide",
            key: "application",
            names: new Dictionary<string, string> {
                ["en-US"] = "application",
                ["de-DE"] = "Applikation" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An application is a specialized software program designed for a specific purpose.",
                ["de-DE"] = "Eine Applikation ist eine spezielle Softwareanwendung, die für einen bestimmten Zweck entwickelt wurde." });

        /// <summary>
        /// Libraries, templates, configuration or multimedia files such as source code, images, videos.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/asset
        /// </summary>
        public readonly xAPI_Activity asset = new xAPI_Activity(
            context: "ide",
            key: "asset",
            names: new Dictionary<string, string> {
                ["en-US"] = "asset",
                ["de-DE"] = "Asset" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Libraries, templates, configuration or multimedia files such as source code, images, videos.",
                ["de-DE"] = "Bibliotheken, Vorlagen, Konfigurations- oder Multimediadateien, wie zum Bespiel Quellcode, Bilder, Videos." });

        /// <summary>
        /// A component is a container with functionality for the IDE or application.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/component
        /// </summary>
        public readonly xAPI_Activity component = new xAPI_Activity(
            context: "ide",
            key: "component",
            names: new Dictionary<string, string> {
                ["en-US"] = "component",
                ["de-DE"] = "Komponente" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A component is a container with functionality for the IDE or application.",
                ["de-DE"] = "Eine Komponente ist ein Halter für Functionalität der IDE oder Applikation." });

        /// <summary>
        /// Something an actor can press, which then triggers an action in the IDE.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/control
        /// </summary>
        public readonly xAPI_Activity control = new xAPI_Activity(
            context: "ide",
            key: "control",
            names: new Dictionary<string, string> {
                ["en-US"] = "control element",
                ["de-DE"] = "Kontrollelement" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something an actor can press, which then triggers an action in the IDE.",
                ["de-DE"] = "Etwas was ein Akteur drücken kann, was dann eine Aktion in der IDE hervorruft." });

        /// <summary>
        /// An object of the IDE, which is not a component or asset, but has no other concrete purpose.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/ideObject
        /// </summary>
        public readonly xAPI_Activity ideObject = new xAPI_Activity(
            context: "ide",
            key: "ideObject",
            names: new Dictionary<string, string> {
                ["en-US"] = "IDE object",
                ["de-DE"] = "IDE Objekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An object of the IDE, which is not a component or asset, but has no other concrete purpose.",
                ["de-DE"] = "Ein Objekt der IDE, welches keine Komponente und kein Asset ist, aber keinen anderen speziellen Zweck kann." });

        /// <summary>
        /// A project is a temporary endeavor designed to achieve a specific goal or set of objectives.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/project
        /// </summary>
        public readonly xAPI_Activity project = new xAPI_Activity(
            context: "ide",
            key: "project",
            names: new Dictionary<string, string> {
                ["en-US"] = "project",
                ["de-DE"] = "Projekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A project is a temporary endeavor designed to achieve a specific goal or set of objectives.",
                ["de-DE"] = "Ein Projekt ist ein zeitlich begrenztes Vorhaben, das darauf ausgerichtet ist, ein bestimmtes Ziel oder eine bestimmte Reihe von Zielen zu erreichen." });

        /// <summary>
        /// A window of an IDE is an area with controls which can be either docked or in front of the IDE.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/activities/window
        /// </summary>
        public readonly xAPI_Activity window = new xAPI_Activity(
            context: "ide",
            key: "window",
            names: new Dictionary<string, string> {
                ["en-US"] = "window",
                ["de-DE"] = "Fenster" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A window of an IDE is an area with controls which can be either docked or in front of the IDE.",
                ["de-DE"] = "Ein Fenster der IDE ist ein Bereich mit Kontrollelementen, welches entweder an der IDE befestigt ist oder frei ist." });

        public xAPI_Activities_Ide() 
            : base("ide") {
        }
    }
}