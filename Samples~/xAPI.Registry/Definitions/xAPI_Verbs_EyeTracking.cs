using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 3 items of the xAPI_Verbs of the context eyeTracking as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_EyeTracking : xAPI_Verbs {
        /// <summary>
        /// Within this contexed indicates the verb closed, that the actor closed one or both eyes. Depending on the duration it can be distinguished between blinking - the  involuntary act of shutting and opening the eyelid (takes from 100 ms to 400 ms). Voluntary winks take longer.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/verbs/closed
        /// </summary>
        public readonly xAPI_Verb closed = new xAPI_Verb(
            context: "eyeTracking",
            key: "closed",
            names: new Dictionary<string, string> {
                ["en-US"] = "closed",
                ["de-DE"] = "schließt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "Within this contexed indicates the verb closed, that the actor closed one or both eyes. Depending on the duration it can be distinguished between blinking - the  involuntary act of shutting and opening the eyelid (takes from 100 ms to 400 ms). Voluntary winks take longer.",
                ["de-DE"] = "In diesem Kontext meint schließen, den Schluss und die Öffnung des Augenlids. Blinzeln kann als unbewusstes Schließen ausgewertet werden und dauert von 100 bis 400ms. Bewusste Bewegungen des Augenlids, zum Beispiel um zu Winkern brauchen länger." });

        /// <summary>
        /// An actor fixated an object with her eyes. A fixation was detected, i.e., the eyes stayed in a small area between 100 and 500 milliseconds without sakkades.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/verbs/fixated
        /// </summary>
        public readonly xAPI_Verb fixated = new xAPI_Verb(
            context: "eyeTracking",
            key: "fixated",
            names: new Dictionary<string, string> {
                ["en-US"] = "fixated",
                ["de-DE"] = "fixierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor fixated an object with her eyes. A fixation was detected, i.e., the eyes stayed in a small area between 100 and 500 milliseconds without sakkades.",
                ["de-DE"] = "Eine Akteurin fixierte ein Objekt mit ihren Augen. Eine Fixation wurde erkannt, d.h. die Augen haben ohne größere Sprünge zwischen 100 und 500 Millisekunden in einem kleinen Bereich verweilt." });

        /// <summary>
        /// An actor focused an object with her eyes. The term focused describes a fixation, which is longer than a normal fixation with more than 500 milliseconds. Compare fixated
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/eyeTracking/verbs/focused
        /// </summary>
        public readonly xAPI_Verb focused = new xAPI_Verb(
            context: "eyeTracking",
            key: "focused",
            names: new Dictionary<string, string> {
                ["en-US"] = "focused",
                ["de-DE"] = "fokussierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor focused an object with her eyes. The term focused describes a fixation, which is longer than a normal fixation with more than 500 milliseconds. Compare fixated",
                ["de-DE"] = "Eine Aktuerin fokussierte ein Objekt mit ihren Augen. Die Fixation hat länger als 500 Millisekunden gedauert (Unterscheidung zur Fixation)." });

        public xAPI_Verbs_EyeTracking() 
            : base("eyeTracking") {
        }
    }
}