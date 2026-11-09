using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context seriousGames of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_SeriousGames : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_SeriousGames() 
            : base("seriousGames") {
        }

        /// <summary>
        /// The identifier for the game in which the event happened. Can be a string or integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/context/game
        /// </summary>
        public xAPI_Extensions_Context_SeriousGames game(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "game",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "game",
                        ["de-DE"] = "Spiel" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The identifier for the game in which the event happened. Can be a string or integer.",
                        ["de-DE"] = "Der Identifikator dafür welches Spiel gespielt wird. Kann ein String oder Integer sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The gamemode in which the game is played. Can be a string or integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/context/gamemode
        /// </summary>
        public xAPI_Extensions_Context_SeriousGames gamemode(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "gamemode",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "gamemode",
                        ["de-DE"] = "Spielmodus" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The gamemode in which the game is played. Can be a string or integer.",
                        ["de-DE"] = "Der Spielmodus in welchem das Spiel gespielt wird. Kann ein String oder ein Integer sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The level in which or for which something happened. Can be an integer or a string.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/context/level
        /// </summary>
        public xAPI_Extensions_Context_SeriousGames level(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "level",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "level",
                        ["de-DE"] = "Level" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The level in which or for which something happened. Can be an integer or a string.",
                        ["de-DE"] = "Das Level in welchem ein Ereignis stattfand. Kann ein String oder Integer sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of players participating at the game. Has to be an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/context/numberOfPlayers
        /// </summary>
        public xAPI_Extensions_Context_SeriousGames numberOfPlayers(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberOfPlayers",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number of players",
                        ["de-DE"] = "Spieleranzahl" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of players participating at the game. Has to be an integer.",
                        ["de-DE"] = "Die Anzahl an Spielern welche am Spiel teilnehmen. Muss ein Integer sein." }),
                 value);
            return this;
        }
    }
}