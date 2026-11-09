using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 10 items of the xAPI_Activities of the context vrRfidChamber as public properties.
    /// </summary>
    public sealed class xAPI_Activities_VrRfidChamber : xAPI_Activities {
        /// <summary>
        /// Something an actor can press, which then triggers an action in the lab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/button
        /// </summary>
        public readonly xAPI_Activity button = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "button",
            names: new Dictionary<string, string> {
                ["en-US"] = "button" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Something an actor can press, which then triggers an action in the lab." });

        /// <summary>
        /// Some kind of written text to explain an action
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/comment
        /// </summary>
        public readonly xAPI_Activity comment = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "comment",
            names: new Dictionary<string, string> {
                ["en-US"] = "comment" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Some kind of written text to explain an action" });

        /// <summary>
        /// Represents the RFID chamber.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/device
        /// </summary>
        public readonly xAPI_Activity device = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "device",
            names: new Dictionary<string, string> {
                ["en-US"] = "device " },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents the RFID chamber." });

        /// <summary>
        /// An actor opened or closed the door
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/door
        /// </summary>
        public readonly xAPI_Activity door = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "door",
            names: new Dictionary<string, string> {
                ["en-US"] = "door" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor opened or closed the door" });

        /// <summary>
        /// Clicking an item, holding the click and moving it around the lab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/draggable
        /// </summary>
        public readonly xAPI_Activity draggable = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "draggable",
            names: new Dictionary<string, string> {
                ["en-US"] = "drag" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Clicking an item, holding the click and moving it around the lab." });

        /// <summary>
        /// A keyboard used to input text or interact with the lab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/keyboard
        /// </summary>
        public readonly xAPI_Activity keyboard = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "keyboard",
            names: new Dictionary<string, string> {
                ["en-US"] = "keyboard" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A keyboard used to input text or interact with the lab." });

        /// <summary>
        /// Some audio content to feel the rela atmosphere of the lab. This can be switched on or off
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/labAudio
        /// </summary>
        public readonly xAPI_Activity labAudio = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "labAudio",
            names: new Dictionary<string, string> {
                ["en-US"] = "lab audio" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Some audio content to feel the rela atmosphere of the lab. This can be switched on or off" });

        /// <summary>
        /// A mouse used to click on buttons or drag items in the lab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/mouse
        /// </summary>
        public readonly xAPI_Activity mouse = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "mouse",
            names: new Dictionary<string, string> {
                ["en-US"] = "mouse" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A mouse used to click on buttons or drag items in the lab." });

        /// <summary>
        /// The screen showing the virtual lab and can be clicked or touched on for interaction with the game.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/screen
        /// </summary>
        public readonly xAPI_Activity screen = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "screen",
            names: new Dictionary<string, string> {
                ["en-US"] = "screen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The screen showing the virtual lab and can be clicked or touched on for interaction with the game." });

        /// <summary>
        /// Some kind of selection is represented by this. It is given by user.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/vrRfidChamber/activities/selection
        /// </summary>
        public readonly xAPI_Activity selection = new xAPI_Activity(
            context: "vrRfidChamber",
            key: "selection",
            names: new Dictionary<string, string> {
                ["en-US"] = "Select" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Some kind of selection is represented by this. It is given by user." });

        public xAPI_Activities_VrRfidChamber() 
            : base("vrRfidChamber") {
        }
    }
}