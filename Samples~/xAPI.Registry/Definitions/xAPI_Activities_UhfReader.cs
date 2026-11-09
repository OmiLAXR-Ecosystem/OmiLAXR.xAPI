using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 7 items of the xAPI_Activities of the context uhfReader as public properties.
    /// </summary>
    public sealed class xAPI_Activities_UhfReader : xAPI_Activities {
        /// <summary>
        /// A field which can be click to fire an action. For example the 'start button'.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/button
        /// </summary>
        public readonly xAPI_Activity button = new xAPI_Activity(
            context: "uhfReader",
            key: "button",
            names: new Dictionary<string, string> {
                ["en-US"] = "button" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A field which can be click to fire an action. For example the 'start button'." });

        /// <summary>
        /// A box which can be checked or unchecked. For example in this case Read TID should be selected.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/checkbox
        /// </summary>
        public readonly xAPI_Activity checkbox = new xAPI_Activity(
            context: "uhfReader",
            key: "checkbox",
            names: new Dictionary<string, string> {
                ["en-US"] = "checkbox" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A box which can be checked or unchecked. For example in this case Read TID should be selected." });

        /// <summary>
        /// A progress to identify 
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/identification
        /// </summary>
        public readonly xAPI_Activity identification = new xAPI_Activity(
            context: "uhfReader",
            key: "identification",
            names: new Dictionary<string, string> {
                ["en-US"] = "identification" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A progress to identify " });

        /// <summary>
        /// A mouse used to click on buttons in the software.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/mouse
        /// </summary>
        public readonly xAPI_Activity mouse = new xAPI_Activity(
            context: "uhfReader",
            key: "mouse",
            names: new Dictionary<string, string> {
                ["en-US"] = "mouse" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A mouse used to click on buttons in the software." });

        /// <summary>
        /// A image of the reader is generated which is interactible. The reading head is selected in the image.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/readerImage
        /// </summary>
        public readonly xAPI_Activity readerImage = new xAPI_Activity(
            context: "uhfReader",
            key: "readerImage",
            names: new Dictionary<string, string> {
                ["en-US"] = "reader image" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A image of the reader is generated which is interactible. The reading head is selected in the image." });

        /// <summary>
        /// Represent the RFID tag. You can drag it as per your requirements
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/rfidTag
        /// </summary>
        public readonly xAPI_Activity rfidTag = new xAPI_Activity(
            context: "uhfReader",
            key: "rfidTag",
            names: new Dictionary<string, string> {
                ["en-US"] = "rfidTag" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represent the RFID tag. You can drag it as per your requirements" });

        /// <summary>
        /// Represents the transpnder to the physical reader.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/uhfReader/activities/transponder
        /// </summary>
        public readonly xAPI_Activity transponder = new xAPI_Activity(
            context: "uhfReader",
            key: "transponder",
            names: new Dictionary<string, string> {
                ["en-US"] = "transponder" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Represents the transpnder to the physical reader." });

        public xAPI_Activities_UhfReader() 
            : base("uhfReader") {
        }
    }
}