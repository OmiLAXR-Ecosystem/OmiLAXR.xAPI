using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 6 items of the xAPI_Verbs of the context uhfReader as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_UhfReader : xAPI_Verbs {
        /// <summary>
        /// An actor clicked on something on the UHF Reader software.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "uhfReader",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor clicked on something on the UHF Reader software." });

        /// <summary>
        /// An actor connected an device (e.g. transponder) to the physical reader.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/verbs/connected
        /// </summary>
        public readonly xAPI_Verb connected = new xAPI_Verb(
            context: "uhfReader",
            key: "connected",
            names: new Dictionary<string, string> {
                ["en-US"] = "connected" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor connected an device (e.g. transponder) to the physical reader." });

        /// <summary>
        /// A user evaluates a target (e.g. transponder).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/verbs/evaluate
        /// </summary>
        public readonly xAPI_Verb evaluate = new xAPI_Verb(
            context: "uhfReader",
            key: "evaluate",
            names: new Dictionary<string, string> {
                ["en-US"] = "evaluate" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A user evaluates a target (e.g. transponder)." });

        /// <summary>
        /// An actor selects an activity mode or experiment mode from menu.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/verbs/selected
        /// </summary>
        public readonly xAPI_Verb selected = new xAPI_Verb(
            context: "uhfReader",
            key: "selected",
            names: new Dictionary<string, string> {
                ["en-US"] = "selected" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor selects an activity mode or experiment mode from menu." });

        /// <summary>
        /// An actor started an activity or process.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "uhfReader",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor started an activity or process." });

        /// <summary>
        /// An actor copied the TID from the screen. Then the actor can paste it in google to research on the transponder.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/verbs/tidCopied
        /// </summary>
        public readonly xAPI_Verb tidCopied = new xAPI_Verb(
            context: "uhfReader",
            key: "tidCopied",
            names: new Dictionary<string, string> {
                ["en-US"] = "tid copied" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor copied the TID from the screen. Then the actor can paste it in google to research on the transponder." });

        public xAPI_Verbs_UhfReader() 
            : base("uhfReader") {
        }
    }
}