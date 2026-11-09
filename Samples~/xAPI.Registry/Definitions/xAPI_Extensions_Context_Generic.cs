using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context generic of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_Generic : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_Generic() 
            : base("generic") {
        }

        /// <summary>
        /// An assignment for a specific topic or a defined learning goal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/context/assignment
        /// </summary>
        public xAPI_Extensions_Context_Generic assignment(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "assignment",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "assignment",
                        ["de-DE"] = "Aufgabe" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "An assignment for a specific topic or a defined learning goal.",
                        ["de-DE"] = "Eine Aufgabe für ein bestimmtes Thema oder ein definiertes Lernziel." }),
                 value);
            return this;
        }

        /// <summary>
        /// A learning scenario, which can consist of multiple learning units.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/context/learningScenario
        /// </summary>
        public xAPI_Extensions_Context_Generic learningScenario(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "learningScenario",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "learning scenario",
                        ["de-DE"] = "Lernszenario" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A learning scenario, which can consist of multiple learning units.",
                        ["de-DE"] = "Ein Lernszenario, welches aus mehreren Lerneinheiten bestehen kann." }),
                 value);
            return this;
        }

        /// <summary>
        /// A learning unit, where a specific topic is taught or a specific learning goal should be achieved with a set of assignments.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/context/learningUnit
        /// </summary>
        public xAPI_Extensions_Context_Generic learningUnit(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "learningUnit",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "learning unit",
                        ["de-DE"] = "Lerneinheit" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A learning unit, where a specific topic is taught or a specific learning goal should be achieved with a set of assignments.",
                        ["de-DE"] = "Eine Lerneinheit, in der ein bestimmtes Thema beigebracht wird oder ein bestimmtes Lernziel mit Hilfe von Aufgaben erreicht werden soll." }),
                 value);
            return this;
        }

        /// <summary>
        /// A task of an assignment or learning unit.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/context/task
        /// </summary>
        public xAPI_Extensions_Context_Generic task(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "task",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "task",
                        ["de-DE"] = "Aufgabenschritt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A task of an assignment or learning unit.",
                        ["de-DE"] = "Eine Aufgabe in einer Lerneinheit oder eine Teilaufgabe, die einer mehrteiligen Aufgabe zugeordnet sein kann." }),
                 value);
            return this;
        }

        /// <summary>
        /// The version of the application instance. It should follow the semantic versioning principle of 'MAJOR.MINOR.PATCH'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/generic/extensions/context/version
        /// </summary>
        public xAPI_Extensions_Context_Generic version(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "version",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "version",
                        ["de-DE"] = "Version" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The version of the application instance. It should follow the semantic versioning principle of 'MAJOR.MINOR.PATCH'.",
                        ["de-DE"] = "Die Version der Applikationsinstanz. Es sollte dem Prinzip der semantischen Versionierung folgen 'MAJOR.MINOR.PATCH'." }),
                 value);
            return this;
        }
    }
}