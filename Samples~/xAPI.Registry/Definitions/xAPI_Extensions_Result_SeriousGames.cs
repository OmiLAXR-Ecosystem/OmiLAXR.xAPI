using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context seriousGames of type result as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Result_SeriousGames : xAPI_Extensions_Result {

        public xAPI_Extensions_Result_SeriousGames() 
            : base("seriousGames") {
        }

        /// <summary>
        /// The result of a change of the gamemode. Can be a string or integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/gamemode
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames gamemode(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "gamemode",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "gamemode",
                        ["de-DE"] = "Spielmodus" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The result of a change of the gamemode. Can be a string or integer.",
                        ["de-DE"] = "Der neue Spielmodus der aus dem Ereignis hervorgeht." }),
                 value);
            return this;
        }

        /// <summary>
        /// The current health of a player character. Has to be an integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/health
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames health(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "health",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "health",
                        ["de-DE"] = "Leben" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The current health of a player character. Has to be an integer.",
                        ["de-DE"] = "Das momentane Leben eines Spielers. Muss ein Integer sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The result of a level change. Has to be a string or integer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/level
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames level(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "level",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "level",
                        ["de-DE"] = "Level" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The result of a level change. Has to be a string or integer.",
                        ["de-DE"] = "Das neue Level welches das Ergebnis des Ereignisses ist." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of instances in which the player marked an incorrect solution as correct.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/numberCommissionErrors
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames numberCommissionErrors(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberCommissionErrors",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number commission-errors",
                        ["de-DE"] = "Anzahl Commissionsfehler" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of instances in which the player marked an incorrect solution as correct.",
                        ["de-DE"] = "Die Anzahl der Male, in denen der Spielende es eine falsche Lösung als richtig markiert hat." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number attempts that have been completed, either by winning or loosing.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/numberCompleted
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames numberCompleted(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberCompleted",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number completed",
                        ["de-DE"] = "Anzahl beendet" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number attempts that have been completed, either by winning or loosing.",
                        ["de-DE"] = "Die Anzahl der Versuche, die beendet wurden, sowohl durch Gewinnen als auch Verlieren." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of Errors that have been made in a gamemode or level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/numberErrors
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames numberErrors(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberErrors",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number errors",
                        ["de-DE"] = "Anzahl Fehler" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of Errors that have been made in a gamemode or level.",
                        ["de-DE"] = "Die Anzahl der Fehler, die in einem Spielmodus oder Level gemacht wurden." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of instances in which the player failed to mark a correct solution as correct.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/numberOmissionErrors
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames numberOmissionErrors(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberOmissionErrors",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number omission-errors",
                        ["de-DE"] = "Anzahl Omissionsfehler" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of instances in which the player failed to mark a correct solution as correct.",
                        ["de-DE"] = "Die Anzahl der Male, in denen der Spielende es versäumt hat, eine korrekte Lösung als richtig zu markieren." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of levels that have been started in a gamemode.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/numberStarted
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames numberStarted(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberStarted",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number started",
                        ["de-DE"] = "Anzahl Gestarted" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of levels that have been started in a gamemode.",
                        ["de-DE"] = "Die Anzahl der Level, die in einem Spielmodus gestartet wurden." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of instances in which the user was able to complete a level successfully.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/numberSucceeded
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames numberSucceeded(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberSucceeded",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number succeeded",
                        ["de-DE"] = "Anzahl geschafft" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of instances in which the user was able to complete a level successfully.",
                        ["de-DE"] = "Die Anzahl der Male, in denen der Nutzende es geschafft hat, ein Level erfolgreich abzuschließen." }),
                 value);
            return this;
        }

        /// <summary>
        /// The position of an object in the game. Can be in X, Y and Z coordinates.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/position
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames position(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "position",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "position",
                        ["de-DE"] = "Position" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The position of an object in the game. Can be in X, Y and Z coordinates.",
                        ["de-DE"] = "Die Position eines Objektes im Spiel. Können X-, Y- und Z-Koordinaten sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The progess a player or group achieved in the game or level. 1.0 Progress would mean the game or level was completed in every aspect. Has to be a double between 0 and 1.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/progress
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames progress(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "progress",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "progress",
                        ["de-DE"] = "Fortschritt" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The progess a player or group achieved in the game or level. 1.0 Progress would mean the game or level was completed in every aspect. Has to be a double between 0 and 1.",
                        ["de-DE"] = "Der Fortschritt welchen ein Spieler oder eine Gruppe erreichte in einem Level oder Spiel. 1.0 Fortschritt hieße das Spiel oder level wurde vollständig abgeschlossen. Muss ein double zwischen 0 und 1 sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// Some relevant score which is tracked by the game. Can be an integer or double.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/score
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames score(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "score",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "score",
                        ["de-DE"] = "Ergebnis" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Some relevant score which is tracked by the game. Can be an integer or double.",
                        ["de-DE"] = "Ein relevantes Ergebnis welches während des Spiels aufgezeichnet wird. Kann ein Integer oder Double sein." }),
                 value);
            return this;
        }

        /// <summary>
        /// The sum of the playtime that has been spent in a gamemode or level.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/seriousGames/extensions/result/sumPlaytime
        /// </summary>
        public xAPI_Extensions_Result_SeriousGames sumPlaytime(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "sumPlaytime",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "sum playtime",
                        ["de-DE"] = "Summe Spielzeit" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The sum of the playtime that has been spent in a gamemode or level.",
                        ["de-DE"] = "Die Summe der Spielzeit, die in einem Spielmodus oder Level verbracht wurde." }),
                 value);
            return this;
        }
    }
}