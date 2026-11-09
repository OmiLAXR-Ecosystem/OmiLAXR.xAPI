using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 8 items of the xAPI_Activities of the context seriousGames as public properties.
    /// </summary>
    public sealed class xAPI_Activities_SeriousGames : xAPI_Activities {
        /// <summary>
        /// Additional explanation or information that serves the understanding of the game content.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/explanation
        /// </summary>
        public readonly xAPI_Activity explanation = new xAPI_Activity(
            context: "seriousGames",
            key: "explanation",
            names: new Dictionary<string, string> {
                ["en-US"] = "Explanation",
                ["de-DE"] = "Erklärung" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Additional explanation or information that serves the understanding of the game content.",
                ["de-DE"] = "Zusätzliche Erklärung oder Informationen, die dem Verständis der Spielinhalte dienen." });

        /// <summary>
        /// Represents a game or competition of any kind.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/game
        /// </summary>
        public readonly xAPI_Activity game = new xAPI_Activity(
            context: "seriousGames",
            key: "game",
            names: new Dictionary<string, string> {
                ["en-US"] = "game",
                ["de-DE"] = "Spiel" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents a game or competition of any kind.",
                ["de-DE"] = "Repräsentiert jede Art von Spiel." });

        /// <summary>
        /// The gamemode in which a game is played (e.g. competitive or cooperative).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/gamemode
        /// </summary>
        public readonly xAPI_Activity gamemode = new xAPI_Activity(
            context: "seriousGames",
            key: "gamemode",
            names: new Dictionary<string, string> {
                ["en-US"] = "gamemode",
                ["de-DE"] = "Spielmodus" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The gamemode in which a game is played (e.g. competitive or cooperative).",
                ["de-DE"] = "Der Spielmodus in dem ein Spiel gespielt wird (z.B. kompetetiv oder kooperativ)." });

        /// <summary>
        /// A level is some, in itself closed, part of the game which the game itself calls level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/level
        /// </summary>
        public readonly xAPI_Activity level = new xAPI_Activity(
            context: "seriousGames",
            key: "level",
            names: new Dictionary<string, string> {
                ["en-US"] = "level",
                ["de-DE"] = "Level" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A level is some, in itself closed, part of the game which the game itself calls level.",
                ["de-DE"] = "Ein Level ist ein in sich selbst geschlossener Teil eines Spiels, den das Spiel selber Level nennt." });

        /// <summary>
        /// An actor which plays the game and interacts with it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/player
        /// </summary>
        public readonly xAPI_Activity player = new xAPI_Activity(
            context: "seriousGames",
            key: "player",
            names: new Dictionary<string, string> {
                ["en-US"] = "player",
                ["de-DE"] = "Spieler" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor which plays the game and interacts with it.",
                ["de-DE"] = "Ein Agierender der das Spiel spielt und mit ihm interagiert." });

        /// <summary>
        /// A representation of something, e.g. the player ingame. Could also be an object the player can interact with.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/playstone
        /// </summary>
        public readonly xAPI_Activity playstone = new xAPI_Activity(
            context: "seriousGames",
            key: "playstone",
            names: new Dictionary<string, string> {
                ["en-US"] = "playstone",
                ["de-DE"] = "Spielstein" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A representation of something, e.g. the player ingame. Could also be an object the player can interact with.",
                ["de-DE"] = "Eine Representation von etwas, z.B. des Spielers im Spiel. Könnte auch ein Objekt sein mit welchem der Spieler im Spiel interagieren kann." });

        /// <summary>
        /// A session is one execution of a game from booting the game to exiting it.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/session
        /// </summary>
        public readonly xAPI_Activity session = new xAPI_Activity(
            context: "seriousGames",
            key: "session",
            names: new Dictionary<string, string> {
                ["en-US"] = "session",
                ["de-DE"] = "Spiel Instanz" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A session is one execution of a game from booting the game to exiting it.",
                ["de-DE"] = "Eine Spiel Instanz ist ein Durchlauf eines Spiels vom Initalisieren des Spiels bis zum Beenden." });

        /// <summary>
        /// A stage is a part of a level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/activities/stage
        /// </summary>
        public readonly xAPI_Activity stage = new xAPI_Activity(
            context: "seriousGames",
            key: "stage",
            names: new Dictionary<string, string> {
                ["en-US"] = "stage",
                ["de-DE"] = "Spielabschnitt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A stage is a part of a level.",
                ["de-DE"] = "Ein Spielabschnitt ist ein Teil eines Levels." });

        public xAPI_Activities_SeriousGames() 
            : base("seriousGames") {
        }
    }
}