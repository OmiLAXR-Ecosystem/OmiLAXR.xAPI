using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 4 items of the xAPI_Verbs of the context 360tours as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_360tours : xAPI_Verbs {
        /// <summary>
        /// An actor exported a 360° tour to an external destination.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/verbs/exported
        /// </summary>
        public readonly xAPI_Verb exported = new xAPI_Verb(
            context: "360tours",
            key: "exported",
            names: new Dictionary<string, string> {
                ["en-US"] = "exported",
                ["de-DE"] = "exportierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor exported a 360° tour to an external destination.",
                ["de-DE"] = "Ein Akteur exportierte eine 360° Tour zu einer externen Ressource." });

        /// <summary>
        /// An actor set a mediapage as the new entry point.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/verbs/homed
        /// </summary>
        public readonly xAPI_Verb homed = new xAPI_Verb(
            context: "360tours",
            key: "homed",
            names: new Dictionary<string, string> {
                ["en-US"] = "homed",
                ["de-DE"] = "als Einstiegspunkt festgelegt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor set a mediapage as the new entry point.",
                ["de-DE"] = "Ein Akteur hat eine Medienseite als neuen Einstiegspunkt festgelegt." });

        /// <summary>
        /// An actor imported a 360° tour from an external destination.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/verbs/imported
        /// </summary>
        public readonly xAPI_Verb imported = new xAPI_Verb(
            context: "360tours",
            key: "imported",
            names: new Dictionary<string, string> {
                ["en-US"] = "imported",
                ["de-DE"] = "importierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor imported a 360° tour from an external destination.",
                ["de-DE"] = "Ein Akteur importierte eine 360° Tour von einer externen Ressource." });

        /// <summary>
        /// An actor changed the name of a 360° tour.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/verbs/renamed
        /// </summary>
        public readonly xAPI_Verb renamed = new xAPI_Verb(
            context: "360tours",
            key: "renamed",
            names: new Dictionary<string, string> {
                ["en-US"] = "renamend",
                ["de-DE"] = "benannte um" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor changed the name of a 360° tour.",
                ["de-DE"] = "Ein Akteur benannte eine 360° Tour um." });

        public xAPI_Verbs_360tours() 
            : base("360tours") {
        }
    }
}