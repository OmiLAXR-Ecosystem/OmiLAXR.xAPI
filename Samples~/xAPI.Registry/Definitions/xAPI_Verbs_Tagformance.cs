using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 12 items of the xAPI_Verbs of the context tagformance as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_Tagformance : xAPI_Verbs {
        /// <summary>
        /// An actor changed a value of an ui element.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/changed
        /// </summary>
        public readonly xAPI_Verb changed = new xAPI_Verb(
            context: "tagformance",
            key: "changed",
            names: new Dictionary<string, string> {
                ["en-US"] = "selected" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor changed a value of an ui element." });

        /// <summary>
        /// An actor clicked on something on the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "tagformance",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor clicked on something on the screen." });

        /// <summary>
        /// An actor has written down the his/her thought.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/commented
        /// </summary>
        public readonly xAPI_Verb commented = new xAPI_Verb(
            context: "tagformance",
            key: "commented",
            names: new Dictionary<string, string> {
                ["en-US"] = "commented" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has written down the his/her thought." });

        /// <summary>
        /// An actor has deleted a digital artefact from the software.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/deleted
        /// </summary>
        public readonly xAPI_Verb deleted = new xAPI_Verb(
            context: "tagformance",
            key: "deleted",
            names: new Dictionary<string, string> {
                ["en-US"] = "deleted" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has deleted a digital artefact from the software." });

        /// <summary>
        /// An actor has exported a digital artefact from the software.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/exported
        /// </summary>
        public readonly xAPI_Verb exported = new xAPI_Verb(
            context: "tagformance",
            key: "exported",
            names: new Dictionary<string, string> {
                ["en-US"] = "exported" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has exported a digital artefact from the software." });

        /// <summary>
        /// An actor has generated a digital artefact from the software.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/generated
        /// </summary>
        public readonly xAPI_Verb generated = new xAPI_Verb(
            context: "tagformance",
            key: "generated",
            names: new Dictionary<string, string> {
                ["en-US"] = "generated" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has generated a digital artefact from the software." });

        /// <summary>
        /// An actor logged in to the portal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/loggedIn
        /// </summary>
        public readonly xAPI_Verb loggedIn = new xAPI_Verb(
            context: "tagformance",
            key: "loggedIn",
            names: new Dictionary<string, string> {
                ["en-US"] = "Log In" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor logged in to the portal." });

        /// <summary>
        /// An actor logged out of the portal.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/loggedOut
        /// </summary>
        public readonly xAPI_Verb loggedOut = new xAPI_Verb(
            context: "tagformance",
            key: "loggedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "Log Out" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor logged out of the portal." });

        /// <summary>
        /// An actor has saved a digital artefact from the software.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/saved
        /// </summary>
        public readonly xAPI_Verb saved = new xAPI_Verb(
            context: "tagformance",
            key: "saved",
            names: new Dictionary<string, string> {
                ["en-US"] = "saved" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has saved a digital artefact from the software." });

        /// <summary>
        /// An actor has started the measurements.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "tagformance",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has started the measurements." });

        /// <summary>
        /// An actor zoomed into the visual element like the graph generated.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/zoomedIn
        /// </summary>
        public readonly xAPI_Verb zoomedIn = new xAPI_Verb(
            context: "tagformance",
            key: "zoomedIn",
            names: new Dictionary<string, string> {
                ["en-US"] = "zoomed in" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor zoomed into the visual element like the graph generated." });

        /// <summary>
        /// An actor zoomed out of a visual element like the graph generated.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/verbs/zoomedOut
        /// </summary>
        public readonly xAPI_Verb zoomedOut = new xAPI_Verb(
            context: "tagformance",
            key: "zoomedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "zoomed out" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor zoomed out of a visual element like the graph generated." });

        public xAPI_Verbs_Tagformance() 
            : base("tagformance") {
        }
    }
}