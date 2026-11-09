using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 2 items of the xAPI_Activities of the context media as public properties.
    /// </summary>
    public sealed class xAPI_Activities_Media : xAPI_Activities {
        /// <summary>
        /// An audio, played by an audio player.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/activities/audio
        /// </summary>
        public readonly xAPI_Activity audio = new xAPI_Activity(
            context: "media",
            key: "audio",
            names: new Dictionary<string, string> {
                ["en-US"] = "Audio",
                ["de-DE"] = "Audio" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An audio, played by an audio player.",
                ["de-DE"] = "Eine Tonaufzeichnung, welche von einem geeigneten Wiedergabegerät abgespielt wird." });

        /// <summary>
        /// A video, played by a video player.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/media/activities/video
        /// </summary>
        public readonly xAPI_Activity video = new xAPI_Activity(
            context: "media",
            key: "video",
            names: new Dictionary<string, string> {
                ["en-US"] = "Video",
                ["de-DE"] = "Video" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A video, played by a video player.",
                ["de-DE"] = "Ein Video, welches von einem geeigneten Wiedergabegerät abgespielt wird." });

        public xAPI_Activities_Media() 
            : base("media") {
        }
    }
}