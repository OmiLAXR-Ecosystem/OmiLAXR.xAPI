using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 22 items of the xAPI_Verbs of the context vrRfidChamber as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_VrRfidChamber : xAPI_Verbs {
        /// <summary>
        /// An actor clicked something on the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/clicked
        /// </summary>
        public readonly xAPI_Verb clicked = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "clicked",
            names: new Dictionary<string, string> {
                ["en-US"] = "clicked" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor clicked something on the screen." });

        /// <summary>
        /// An actor closed an the door of the RFID chamber.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/closed
        /// </summary>
        public readonly xAPI_Verb closed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "closed",
            names: new Dictionary<string, string> {
                ["en-US"] = "closed" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor closed an the door of the RFID chamber." });

        /// <summary>
        /// The system scan is completed to check the RFID output.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/completed
        /// </summary>
        public readonly xAPI_Verb completed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "completed",
            names: new Dictionary<string, string> {
                ["en-US"] = "completed" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The system scan is completed to check the RFID output." });

        /// <summary>
        /// An actor dragged and pulled an object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/dragPull
        /// </summary>
        public readonly xAPI_Verb dragPull = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "dragPull",
            names: new Dictionary<string, string> {
                ["en-US"] = "dragPull" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor dragged and pulled an object." });

        /// <summary>
        /// An actor dragged and pushed an object on the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/dragPush
        /// </summary>
        public readonly xAPI_Verb dragPush = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "dragPush",
            names: new Dictionary<string, string> {
                ["en-US"] = "dragPush" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor dragged and pushed an object on the screen." });

        /// <summary>
        /// An actor has dragged an object across the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/dragged
        /// </summary>
        public readonly xAPI_Verb dragged = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "dragged",
            names: new Dictionary<string, string> {
                ["en-US"] = "dragged" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has dragged an object across the screen." });

        /// <summary>
        /// An actor has focused on the RFID tag.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/focussed
        /// </summary>
        public readonly xAPI_Verb focussed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "focussed",
            names: new Dictionary<string, string> {
                ["en-US"] = "focused" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has focused on the RFID tag." });

        /// <summary>
        /// An actor has interacted with the object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/interacted
        /// </summary>
        public readonly xAPI_Verb interacted = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "interacted",
            names: new Dictionary<string, string> {
                ["en-US"] = "interacted" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has interacted with the object." });

        /// <summary>
        /// An actor has opened the object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/opened
        /// </summary>
        public readonly xAPI_Verb opened = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "opened",
            names: new Dictionary<string, string> {
                ["en-US"] = "opened" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has opened the object." });

        /// <summary>
        /// An actor panned the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/panned
        /// </summary>
        public readonly xAPI_Verb panned = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "panned",
            names: new Dictionary<string, string> {
                ["en-US"] = "panned" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor panned the screen." });

        /// <summary>
        /// An actor has pressed the keyboard.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/pressed
        /// </summary>
        public readonly xAPI_Verb pressed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "pressed",
            names: new Dictionary<string, string> {
                ["en-US"] = "pressed" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has pressed the keyboard." });

        /// <summary>
        /// An actor has released the object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/released
        /// </summary>
        public readonly xAPI_Verb released = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "released",
            names: new Dictionary<string, string> {
                ["en-US"] = "released" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has released the object." });

        /// <summary>
        /// An actor has removed an object from the target.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/removed
        /// </summary>
        public readonly xAPI_Verb removed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "removed",
            names: new Dictionary<string, string> {
                ["en-US"] = "removed" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has removed an object from the target." });

        /// <summary>
        /// An actor rotated a lab object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/rotated
        /// </summary>
        public readonly xAPI_Verb rotated = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "rotated",
            names: new Dictionary<string, string> {
                ["en-US"] = "rotated" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor rotated a lab object." });

        /// <summary>
        /// An actor has started the object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/started
        /// </summary>
        public readonly xAPI_Verb started = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "started",
            names: new Dictionary<string, string> {
                ["en-US"] = "started" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has started the object." });

        /// <summary>
        /// An actor has terminated the operation.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/terminated
        /// </summary>
        public readonly xAPI_Verb terminated = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "terminated",
            names: new Dictionary<string, string> {
                ["en-US"] = "terminated" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has terminated the operation." });

        /// <summary>
        /// An actor unforcused the object
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/unfocussed
        /// </summary>
        public readonly xAPI_Verb unfocussed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "unfocussed",
            names: new Dictionary<string, string> {
                ["en-US"] = "unfocused" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor unforcused the object" });

        /// <summary>
        /// An actor has viewed the object details
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/viewed
        /// </summary>
        public readonly xAPI_Verb viewed = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "viewed",
            names: new Dictionary<string, string> {
                ["en-US"] = "viewed" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has viewed the object details" });

        /// <summary>
        /// An actor has visited the virtual lab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/visited
        /// </summary>
        public readonly xAPI_Verb visited = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "visited",
            names: new Dictionary<string, string> {
                ["en-US"] = "visited" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has visited the virtual lab." });

        /// <summary>
        /// An actor has watched the formation of the graph.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/watched
        /// </summary>
        public readonly xAPI_Verb watched = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "watched",
            names: new Dictionary<string, string> {
                ["en-US"] = "Watched" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has watched the formation of the graph." });

        /// <summary>
        /// An actor zoomed into some part of the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/zoomedIn
        /// </summary>
        public readonly xAPI_Verb zoomedIn = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "zoomedIn",
            names: new Dictionary<string, string> {
                ["en-US"] = "zoomed in" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor zoomed into some part of the screen." });

        /// <summary>
        /// An actor zoomed out of some part of the screen.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/verbs/zoomedOut
        /// </summary>
        public readonly xAPI_Verb zoomedOut = new xAPI_Verb(
            context: "vrRfidChamber",
            key: "zoomedOut",
            names: new Dictionary<string, string> {
                ["en-US"] = "zoomed out" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor zoomed out of some part of the screen." });

        public xAPI_Verbs_VrRfidChamber() 
            : base("vrRfidChamber") {
        }
    }
}