using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 8 items of the xAPI_Activities of the context tagformance as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Tagformance : xAPI_Activities {
        /// <summary>
        /// A button the actor can interact with.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/button
        /// </summary>
        public readonly xAPI_Activity button = new xAPI_Activity(
            context: "tagformance",
            key: "button",
            names: new Dictionary<string, string> {
                ["en-US"] = "button" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A button the actor can interact with." });

        /// <summary>
        /// A box which can be checked to select an already generated graph. Then it can be deleted using the cross button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/checkbox
        /// </summary>
        public readonly xAPI_Activity checkbox = new xAPI_Activity(
            context: "tagformance",
            key: "checkbox",
            names: new Dictionary<string, string> {
                ["en-US"] = "checkBox" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A box which can be checked to select an already generated graph. Then it can be deleted using the cross button." });

        /// <summary>
        /// An actor selects an option through a dropdown menu.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/dropdown
        /// </summary>
        public readonly xAPI_Activity dropdown = new xAPI_Activity(
            context: "tagformance",
            key: "dropdown",
            names: new Dictionary<string, string> {
                ["en-US"] = "dropdown" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor selects an option through a dropdown menu." });

        /// <summary>
        /// A scientific procedure, especially in a laboratory, to determine something.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/experiment
        /// </summary>
        public readonly xAPI_Activity experiment = new xAPI_Activity(
            context: "tagformance",
            key: "experiment",
            names: new Dictionary<string, string> {
                ["en-US"] = "experiment" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A scientific procedure, especially in a laboratory, to determine something." });

        /// <summary>
        /// A graph that is generated after clicking on Start Sweep button. This can be interactible.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/graph
        /// </summary>
        public readonly xAPI_Activity graph = new xAPI_Activity(
            context: "tagformance",
            key: "graph",
            names: new Dictionary<string, string> {
                ["en-US"] = "graph" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A graph that is generated after clicking on Start Sweep button. This can be interactible." });

        /// <summary>
        /// A keyboard used to input text or interact with the lab and enter values as per the actor's wish.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/keyboard
        /// </summary>
        public readonly xAPI_Activity keyboard = new xAPI_Activity(
            context: "tagformance",
            key: "keyboard",
            names: new Dictionary<string, string> {
                ["en-US"] = "keyboard" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A keyboard used to input text or interact with the lab and enter values as per the actor's wish." });

        /// <summary>
        /// A mouse used to click on buttons or drag items in the lab.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/mouse
        /// </summary>
        public readonly xAPI_Activity mouse = new xAPI_Activity(
            context: "tagformance",
            key: "mouse",
            names: new Dictionary<string, string> {
                ["en-US"] = "mouse" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A mouse used to click on buttons or drag items in the lab." });

        /// <summary>
        /// A textbox, where the actor can fill text.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/tagformance/activities/textBox
        /// </summary>
        public readonly xAPI_Activity textBox = new xAPI_Activity(
            context: "tagformance",
            key: "textBox",
            names: new Dictionary<string, string> {
                ["en-US"] = "commentBox" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A textbox, where the actor can fill text." });

        public xAPI_Activities_Tagformance() 
            : base("tagformance") {
        }
    }
}