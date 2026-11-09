using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context 360tours of type activity as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Activity_360tours : xAPI_Extensions_Activity {

        public xAPI_Extensions_Activity_360tours() 
            : base("360tours") {
        }

        /// <summary>
        /// The type of interactive hotspot within a 360° tour.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/activity/hotspotType
        /// </summary>
        public xAPI_Extensions_Activity_360tours hotspotType(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "hotspotType",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "hotspot type",
                        ["de-DE"] = "Hotspot Typ" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The type of interactive hotspot within a 360° tour.",
                        ["de-DE"] = "Die Art eines interaktiven Hotspots innerhalb einer 360° Tour." }),
                 value);
            return this;
        }

        /// <summary>
        /// The number of interactive hotspots within a 360° mediapage.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/activity/numberOfHotspots
        /// </summary>
        public xAPI_Extensions_Activity_360tours numberOfHotspots(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberOfHotspots",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number of hotspots",
                        ["de-DE"] = "Hotspots Anzahl" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The number of interactive hotspots within a 360° mediapage.",
                        ["de-DE"] = "Die Anzahl der interaktiven Hotspots innerhalb einer 360° Medienseite." }),
                 value);
            return this;
        }

        /// <summary>
        /// The total number of media pages associated with a 360° tour.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/activity/numberOfMediapages
        /// </summary>
        public xAPI_Extensions_Activity_360tours numberOfMediapages(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "numberOfMediapages",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "number of mediapages",
                        ["de-DE"] = "Medienseiten Anzahl" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "The total number of media pages associated with a 360° tour.",
                        ["de-DE"] = "Die Gesamtzahl der Medienseiten, die mit einer 360° Tour verknüpft sind." }),
                 value);
            return this;
        }
    }
}