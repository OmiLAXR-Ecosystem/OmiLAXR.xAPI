using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 3 items of the xAPI_Verbs of the context exerciseGenerator as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_ExerciseGenerator : xAPI_Verbs {
        /// <summary>
        /// Actor accessed/viewed the generator, an existing exercise, ... 
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/exerciseGenerator/verbs/accessed
        /// </summary>
        public readonly xAPI_Verb accessed = new xAPI_Verb(
            context: "exerciseGenerator",
            key: "accessed",
            names: new Dictionary<string, string> {
                ["en-US"] = "accessed",
                ["de-DE"] = "zugegriffen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor accessed/viewed the generator, an existing exercise, ... ",
                ["de-DE"] = "Akteur hat auf den Generator, eine existierende Aufgabe, ... zugegriffen." });

        /// <summary>
        /// Actor exported an exercise, e.g. as a PDF, image, ...
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/exerciseGenerator/verbs/exported
        /// </summary>
        public readonly xAPI_Verb exported = new xAPI_Verb(
            context: "exerciseGenerator",
            key: "exported",
            names: new Dictionary<string, string> {
                ["en-US"] = "exported",
                ["de-DE"] = "exportierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor exported an exercise, e.g. as a PDF, image, ...",
                ["de-DE"] = "Akteur hat eine Aufgabe exportiert, z. B. als PDF, Bild, ..." });

        /// <summary>
        /// Actor used the exercise generator to generate a new exercise..
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/exerciseGenerator/verbs/generated
        /// </summary>
        public readonly xAPI_Verb generated = new xAPI_Verb(
            context: "exerciseGenerator",
            key: "generated",
            names: new Dictionary<string, string> {
                ["en-US"] = "generated",
                ["de-DE"] = "generierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Actor used the exercise generator to generate a new exercise..",
                ["de-DE"] = "Akteur nutzte den Aufgabengenerator um eine neue Aufgabe generieren zu lassen." });

        public xAPI_Verbs_ExerciseGenerator() 
            : base("exerciseGenerator") {
        }
    }
}