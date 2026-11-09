using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides all extensions of the context 360tours of type context as public properties.
    /// </summary>
    public sealed class xAPI_Extensions_Context_360tours : xAPI_Extensions_Context {

        public xAPI_Extensions_Context_360tours() 
            : base("360tours") {
        }

        /// <summary>
        /// Unique identifier of a 360° tour.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/context/tourId
        /// </summary>
        public xAPI_Extensions_Context_360tours tourId(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "tourId",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "tour id",
                        ["de-DE"] = "Tour-ID" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Unique identifier of a 360° tour.",
                        ["de-DE"] = "Eindeutige Kennung einer 360° Tour." }),
                 value);
            return this;
        }

        /// <summary>
        /// Unique identifier of a user account.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/extensions/context/userId
        /// </summary>
        public xAPI_Extensions_Context_360tours userId(object value) {
            Add(new xAPI_Extension(
                    context: Context,
                    extensionType: ExtensionType,
                    key: "userId",
                    names: new Dictionary<string, string> {
                        ["en-US"] = "user id",
                        ["de-DE"] = "Benutzer-ID" },
                    descriptions: new Dictionary<string, string> {
                        ["en-US"] = "Unique identifier of a user account.",
                        ["de-DE"] = "Eindeutige Kennung eines Nutzeraccounts." }),
                 value);
            return this;
        }
    }
}