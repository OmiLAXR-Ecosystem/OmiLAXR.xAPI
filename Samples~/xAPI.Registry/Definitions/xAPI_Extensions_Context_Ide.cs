using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context ide of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_Ide : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_Ide() 
            : base("ide") {
        }

        /// <summary>
        /// The IDE is compiling.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/compiling
        /// </summary>
        public xAPI_Extensions_Context_Ide compiling(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "compiling",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "compiling",
                        ["de-DE"] = "kompiliert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The IDE is compiling.",
                        ["de-DE"] = "Die IDE kompiliert." }),
                 value);
            return this;
        }

        /// <summary>
        /// Is true if IDE is in debug mode. Boolean value.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/debugMode
        /// </summary>
        public xAPI_Extensions_Context_Ide debugMode(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "debugMode",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "debug mode",
                        ["de-DE"] = "Debug Modus" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Is true if IDE is in debug mode. Boolean value.",
                        ["de-DE"] = "Ist wahr, wenn die IDE im Debug Modus ist. Boolscher Wert." }),
                 value);
            return this;
        }

        /// <summary>
        /// A software tool that helps programmers write and develop code by providing a variety of useful features in one application.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/ide
        /// </summary>
        public xAPI_Extensions_Context_Ide ide(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "ide",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "Integrated Development Environment",
                        ["de-DE"] = "Integrierte Entwicklungsumgebung" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A software tool that helps programmers write and develop code by providing a variety of useful features in one application.",
                        ["de-DE"] = "Eine Software, die Programmierern bei der Entwicklung und dem Schreiben von Code hilft, indem sie eine Vielzahl nützlicher Funktionen in einer Anwendung bereitstellt." }),
                 value);
            return this;
        }

        /// <summary>
        /// The license of the IDE.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/license
        /// </summary>
        public xAPI_Extensions_Context_Ide license(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "license",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "license of IDE",
                        ["de-DE"] = "License der IDE" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The license of the IDE.",
                        ["de-DE"] = "Die Lizens der IDE." }),
                 value);
            return this;
        }

        /// <summary>
        /// The IDE is pausing.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/pausing
        /// </summary>
        public xAPI_Extensions_Context_Ide pausing(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "pausing",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "pausing",
                        ["de-DE"] = "pausiert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The IDE is pausing.",
                        ["de-DE"] = "Die IDE ist pausiert." }),
                 value);
            return this;
        }

        /// <summary>
        /// The IDE is running.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/running
        /// </summary>
        public xAPI_Extensions_Context_Ide running(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "running",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "running",
                        ["de-DE"] = "läuft" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The IDE is running.",
                        ["de-DE"] = "Die IDE läuft." }),
                 value);
            return this;
        }

        /// <summary>
        /// A list of IDE tools. Must be a string array.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/tools
        /// </summary>
        public xAPI_Extensions_Context_Ide tools(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "tools",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "tools",
                        ["de-DE"] = "Tools" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "A list of IDE tools. Must be a string array.",
                        ["de-DE"] = "Eine Liste mit IDE Tools. Muss ein String Array sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The IDE is updating.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/updating
        /// </summary>
        public xAPI_Extensions_Context_Ide updating(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "updating",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "updating",
                        ["de-DE"] = "aktualisiert" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The IDE is updating.",
                        ["de-DE"] = "Die IDE aktualisiert." }),
                 value);
            return this;
        }

        /// <summary>
        /// The version of the IDE. It should follow the semantic versioning principle of 'MAJOR.MINOR.PATCH'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/ide/extensions/context/version
        /// </summary>
        public xAPI_Extensions_Context_Ide version(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "version",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "version of IDE",
                        ["de-DE"] = "Version der IDE" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The version of the IDE. It should follow the semantic versioning principle of 'MAJOR.MINOR.PATCH'.",
                        ["de-DE"] = "Die Version der IDE. Es sollte dem Prinzip der semantischen Versionierung folgen 'MAJOR.MINOR.PATCH'." }),
                 value);
            return this;
        }
    }
}