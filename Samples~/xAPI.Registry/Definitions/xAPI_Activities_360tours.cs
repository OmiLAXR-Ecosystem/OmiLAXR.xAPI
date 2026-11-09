using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 4 items of the xAPI_Activities of the context 360tours as public properties.
    /// </summary>
    public sealed class xAPI_Activities_360tours : xAPI_Activities {
        /// <summary>
        /// Interactive area within a 360° mediapage that triggers an action or displays additional information.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/activities/hotspot
        /// </summary>
        public readonly xAPI_Activity hotspot = new xAPI_Activity(
            context: "360tours",
            key: "hotspot",
            names: new Dictionary<string, string> {
                ["en-US"] = "hotspot",
                ["de-DE"] = "Hotspot" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Interactive area within a 360° mediapage that triggers an action or displays additional information.",
                ["de-DE"] = "Interaktiver Bereich innerhalb einer 360° Medienseite, der eine Aktion auslöst oder zusätzliche Informationen anzeigt." });

        /// <summary>
        /// A page displaying a single 360° image or video, allowing users to explore the content interactively.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/activities/mediapage
        /// </summary>
        public readonly xAPI_Activity mediapage = new xAPI_Activity(
            context: "360tours",
            key: "mediapage",
            names: new Dictionary<string, string> {
                ["en-US"] = "media page",
                ["de-DE"] = "Medienseite" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A page displaying a single 360° image or video, allowing users to explore the content interactively.",
                ["de-DE"] = "Eine Seite, die ein einzelnes 360° Bild oder Video anzeigt und es Benutzern ermöglicht, den Inhalt interaktiv zu erkunden." });

        /// <summary>
        /// An interactive tour comprised of 360° images and videos. A tour may also include media pages and hotspots.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/activities/tour
        /// </summary>
        public readonly xAPI_Activity tour = new xAPI_Activity(
            context: "360tours",
            key: "tour",
            names: new Dictionary<string, string> {
                ["en-US"] = "360° virtual tour",
                ["de-DE"] = "360° Virtuelle Tour" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An interactive tour comprised of 360° images and videos. A tour may also include media pages and hotspots.",
                ["de-DE"] = "Eine interaktive Tour bestehend aus 360° Bildern und Videos. Eine Tour kann zusätzlich Medienseiten und Hotspots enthalten." });

        /// <summary>
        /// A personal account for accessing a 360° tours platform.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/360tours/activities/userAccount
        /// </summary>
        public readonly xAPI_Activity userAccount = new xAPI_Activity(
            context: "360tours",
            key: "userAccount",
            names: new Dictionary<string, string> {
                ["en-US"] = "user account",
                ["de-DE"] = "Nutzeraccount" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A personal account for accessing a 360° tours platform.",
                ["de-DE"] = "Ein persönliches Profil für den Zugriff auf eine 360° Touren Plattform." });

        public xAPI_Activities_360tours() 
            : base("360tours") {
        }
    }
}