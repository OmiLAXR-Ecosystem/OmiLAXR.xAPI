using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 13 items of the xAPI_Verbs of the context virtualReality as public properties.
    /// </summary>
    public sealed class xAPI_Verbs_VirtualReality : xAPI_Verbs {
        /// <summary>
        /// An actor has created a virtual object in the VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/created
        /// </summary>
        public readonly xAPI_Verb created = new xAPI_Verb(
            context: "virtualReality",
            key: "created",
            names: new Dictionary<string, string> {
                ["en-US"] = "created",
                ["de-DE"] = "erstellte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has created a virtual object in the VR environment.",
                ["de-DE"] = "Eine Akteurin hat ein virtuelles Objekt in der VR Umgebung erstellt." });

        /// <summary>
        /// The actor grabbed an object in a virtual reality environment. This action involves interacting with a virtual object using hand tracking, controllers, or other input methods, providing context about the actor's interactions within the VR experience.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/grabbed
        /// </summary>
        public readonly xAPI_Verb grabbed = new xAPI_Verb(
            context: "virtualReality",
            key: "grabbed",
            names: new Dictionary<string, string> {
                ["en-US"] = "grabbed",
                ["de-DE"] = "gegriffen" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The actor grabbed an object in a virtual reality environment. This action involves interacting with a virtual object using hand tracking, controllers, or other input methods, providing context about the actor's interactions within the VR experience.",
                ["de-DE"] = "Der Akteur griff ein Objekt in einer virtuellen Realität. Diese Aktion beinhaltet die Interaktion des Akteurs mit einem virtuellen Objekt mithilfe von Handtracking, Controllern oder anderen Eingabemethoden und bietet Kontext zu den Interaktionen des Akteurs innerhalb der VR-Erfahrung." });

        /// <summary>
        /// An actor interacted with the VR object in the VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/interacted
        /// </summary>
        public readonly xAPI_Verb interacted = new xAPI_Verb(
            context: "virtualReality",
            key: "interacted",
            names: new Dictionary<string, string> {
                ["en-US"] = "interacted",
                ["de-DE"] = "interagierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor interacted with the VR object in the VR environment.",
                ["de-DE"] = "Eine Akteurin interagierte einem VR Objekt in der VR Umgebung." });

        /// <summary>
        /// An actor has changed a virtual object's position in VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/moved
        /// </summary>
        public readonly xAPI_Verb moved = new xAPI_Verb(
            context: "virtualReality",
            key: "moved",
            names: new Dictionary<string, string> {
                ["en-US"] = "moved",
                ["de-DE"] = "bewegte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has changed a virtual object's position in VR environment.",
                ["de-DE"] = "Eine Akteurin hat die Position eines virtuellen Objekts verändert." });

        /// <summary>
        /// An actor has placed a virtual object in the VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/placed
        /// </summary>
        public readonly xAPI_Verb placed = new xAPI_Verb(
            context: "virtualReality",
            key: "placed",
            names: new Dictionary<string, string> {
                ["en-US"] = "placed",
                ["de-DE"] = "platzierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has placed a virtual object in the VR environment.",
                ["de-DE"] = "Eine Akteurin hat ein virtuelles Objekt in der VR Umgebung platziert." });

        /// <summary>
        /// An actor has pointed on an VR object.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/pointed
        /// </summary>
        public readonly xAPI_Verb pointed = new xAPI_Verb(
            context: "virtualReality",
            key: "pointed",
            names: new Dictionary<string, string> {
                ["en-US"] = "pointed",
                ["de-DE"] = "zeigte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has pointed on an VR object.",
                ["de-DE"] = "Eine Akteurin zeigte auf ein VR Objekt." });

        /// <summary>
        /// The actor has pressed a controller button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/pressed
        /// </summary>
        public readonly xAPI_Verb pressed = new xAPI_Verb(
            context: "virtualReality",
            key: "pressed",
            names: new Dictionary<string, string> {
                ["en-US"] = "pressed",
                ["de-DE"] = "drückte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The actor has pressed a controller button.",
                ["de-DE"] = "Eine Akteurin drückte einen Controller Taste." });

        /// <summary>
        /// The actor has released a controller button.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/released
        /// </summary>
        public readonly xAPI_Verb released = new xAPI_Verb(
            context: "virtualReality",
            key: "released",
            names: new Dictionary<string, string> {
                ["en-US"] = "released",
                ["de-DE"] = "löste" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "The actor has released a controller button.",
                ["de-DE"] = "Eine Akteurin löste einen Controller Taste." });

        /// <summary>
        /// An actor has removed a virtual object from the VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/removed
        /// </summary>
        public readonly xAPI_Verb removed = new xAPI_Verb(
            context: "virtualReality",
            key: "removed",
            names: new Dictionary<string, string> {
                ["en-US"] = "removed",
                ["de-DE"] = "entfernte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has removed a virtual object from the VR environment.",
                ["de-DE"] = "Ein Akteur hat ein virtuelles Objekt aus der VR Umgebung entfernt." });

        /// <summary>
        /// An actor has changed a virtual object's rotation in VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/rotated
        /// </summary>
        public readonly xAPI_Verb rotated = new xAPI_Verb(
            context: "virtualReality",
            key: "rotated",
            names: new Dictionary<string, string> {
                ["en-US"] = "rotated",
                ["de-DE"] = "rotierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has changed a virtual object's rotation in VR environment.",
                ["de-DE"] = "Ein Akteur hat die Rotation eines virtuellen Objekts verändert." });

        /// <summary>
        /// An actor has changed a virtual object's scale in VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/scaled
        /// </summary>
        public readonly xAPI_Verb scaled = new xAPI_Verb(
            context: "virtualReality",
            key: "scaled",
            names: new Dictionary<string, string> {
                ["en-US"] = "scaled",
                ["de-DE"] = "skalierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has changed a virtual object's scale in VR environment.",
                ["de-DE"] = "Eine Akteurin hat die Skalierung eines virtuellen Objekts verändert." });

        /// <summary>
        /// An actor has changed her own position in VR environment by teleport.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/teleported
        /// </summary>
        public readonly xAPI_Verb teleported = new xAPI_Verb(
            context: "virtualReality",
            key: "teleported",
            names: new Dictionary<string, string> {
                ["en-US"] = "teleported",
                ["de-DE"] = "teleportierte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has changed her own position in VR environment by teleport.",
                ["de-DE"] = "Eine Akteurin hat die eigene Position in der VR Umgebung durch Teleportation verändert." });

        /// <summary>
        /// An actor has touched a virtual object in VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/verbs/touched
        /// </summary>
        public readonly xAPI_Verb touched = new xAPI_Verb(
            context: "virtualReality",
            key: "touched",
            names: new Dictionary<string, string> {
                ["en-US"] = "touched",
                ["de-DE"] = "berührte" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An actor has touched a virtual object in VR environment.",
                ["de-DE"] = "Eine Akteurin hat ein virtuelles Objekt berührt." });

        public xAPI_Verbs_VirtualReality() 
            : base("virtualReality") {
        }
    }
}