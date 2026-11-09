using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 5 items of the xAPI_Activities of the context systemControl as public properties.
    /// </summary>
    public sealed class xAPI_Activities_SystemControl : xAPI_Activities {
        /// <summary>
        /// Represents a game or competition of any kind.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/activities/game
        /// </summary>
        public readonly xAPI_Activity game = new xAPI_Activity(
            context: "systemControl",
            key: "game",
            names: new Dictionary<string, string> {
                ["en-US"] = "game",
                ["de-DE"] = "Spiel" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents a game or competition of any kind.",
                ["de-DE"] = "Repräsentiert jede Art von Spiel." });

        /// <summary>
        /// Represents an instruction provided by the system.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/activities/instruction
        /// </summary>
        public readonly xAPI_Activity instruction = new xAPI_Activity(
            context: "systemControl",
            key: "instruction",
            names: new Dictionary<string, string> {
                ["en-US"] = "instruction",
                ["de-DE"] = "Anweisung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents an instruction provided by the system.",
                ["de-DE"] = "Repräsentiert eine Anweisung, die vom System erteilt wird." });

        /// <summary>
        /// A level is some, in itself closed, part of the game which the game itself calls level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/activities/level
        /// </summary>
        public readonly xAPI_Activity level = new xAPI_Activity(
            context: "systemControl",
            key: "level",
            names: new Dictionary<string, string> {
                ["en-US"] = "level",
                ["de-DE"] = "Level" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A level is some, in itself closed, part of the game which the game itself calls level.",
                ["de-DE"] = "Ein Level ist ein in sich selbst geschlossener Teil eines Spiels, den das Spiel selber Level nennt." });

        /// <summary>
        /// A session is one execution of a game from booting the game to exiting it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/activities/session
        /// </summary>
        public readonly xAPI_Activity session = new xAPI_Activity(
            context: "systemControl",
            key: "session",
            names: new Dictionary<string, string> {
                ["en-US"] = "session",
                ["de-DE"] = "Spiel Instanz" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A session is one execution of a game from booting the game to exiting it.",
                ["de-DE"] = "Eine Spiel Instanz ist ein Durchlauf eines Spiels vom Initalisieren des Spiels bis zum Beenden." });

        /// <summary>
        /// A stage is a part of a level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/systemControl/activities/stage
        /// </summary>
        public readonly xAPI_Activity stage = new xAPI_Activity(
            context: "systemControl",
            key: "stage",
            names: new Dictionary<string, string> {
                ["en-US"] = "stage",
                ["de-DE"] = "Spielabschnitt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A stage is a part of a level.",
                ["de-DE"] = "Ein Spielabschnitt ist ein Teil eines Levels." });

        public xAPI_Activities_SystemControl() 
            : base("systemControl") {
        }
    }
}