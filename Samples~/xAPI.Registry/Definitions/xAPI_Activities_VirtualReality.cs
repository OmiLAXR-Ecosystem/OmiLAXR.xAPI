using System.Collections.Generic;

namespace xAPI.Registry {
    /// <summary>
    /// Provides 8 items of the xAPI_Activities of the context virtualReality as public properties.
    /// </summary>
    public sealed class xAPI_Activities_VirtualReality : xAPI_Activities {
        /// <summary>
        /// An action the actor can trigger.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/action
        /// </summary>
        public readonly xAPI_Activity action = new xAPI_Activity(
            context: "virtualReality",
            key: "action",
            names: new Dictionary<string, string> {
                ["en-US"] = "action",
                ["de-DE"] = "Aktion" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An action the actor can trigger.",
                ["de-DE"] = "Eine Aktion, die von der Akteurin ausgelöst wird." });

        /// <summary>
        /// A controller button or gamepad button the actor can use. On–off controls that switch between different system states.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/controllerButton
        /// </summary>
        public readonly xAPI_Activity controllerButton = new xAPI_Activity(
            context: "virtualReality",
            key: "controllerButton",
            names: new Dictionary<string, string> {
                ["en-US"] = "controller button",
                ["de-DE"] = "Controller Taste" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A controller button or gamepad button the actor can use. On–off controls that switch between different system states.",
                ["de-DE"] = "Eine Taste des Controllers oder des Gamepads, die die Akteurin benutzen kann. Die Betätigung der Taste führt zu einer Änderung des Systemstatus." });

        /// <summary>
        /// An object which can be pointed and highlighted with for example a laser starting from the controller.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/pointable
        /// </summary>
        public readonly xAPI_Activity pointable = new xAPI_Activity(
            context: "virtualReality",
            key: "pointable",
            names: new Dictionary<string, string> {
                ["en-US"] = "pointable object",
                ["de-DE"] = "ein markierbares Objekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An object which can be pointed and highlighted with for example a laser starting from the controller.",
                ["de-DE"] = "Ein Objekt, welches z.B. mit einem Laser vom Controller markiert werden kann." });

        /// <summary>
        /// A highlighted area, which is a teleportation destination. So the actor or something could be teleported to the specific location.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/teleportArea
        /// </summary>
        public readonly xAPI_Activity teleportArea = new xAPI_Activity(
            context: "virtualReality",
            key: "teleportArea",
            names: new Dictionary<string, string> {
                ["en-US"] = "teleport area",
                ["de-DE"] = "Teleportbereich" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A highlighted area, which is a teleportation destination. So the actor or something could be teleported to the specific location.",
                ["de-DE"] = "Ein hervorgehobener Bereich, der ein Teleportationsziel ist. Der Agierende oder etwas anderes kann durch Interaktion an den spezifischen Ort teleportiert werden." });

        /// <summary>
        /// A fixed teleport point in VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/teleportPoint
        /// </summary>
        public readonly xAPI_Activity teleportPoint = new xAPI_Activity(
            context: "virtualReality",
            key: "teleportPoint",
            names: new Dictionary<string, string> {
                ["en-US"] = "teleport point",
                ["de-DE"] = "Teleport Punkt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A fixed teleport point in VR environment.",
                ["de-DE"] = "Ein fester Teleport Punkt in der VR Umgebung." });

        /// <summary>
        /// A VR controller touchpad the actor can use, appearance and possibilities depend on the specific conroller type.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/touchpad
        /// </summary>
        public readonly xAPI_Activity touchpad = new xAPI_Activity(
            context: "virtualReality",
            key: "touchpad",
            names: new Dictionary<string, string> {
                ["en-US"] = "controller touchpad",
                ["de-DE"] = "Controller Touchpad" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A VR controller touchpad the actor can use, appearance and possibilities depend on the specific conroller type.",
                ["de-DE"] = "Ein VR Controller Touchpad, das die Akteurin benutzen kann. Aussehen und Möglichkeiten sind abhängig davon welcher Controller genutzt wurde." });

        /// <summary>
        /// An UI element in VR the user can interact with (e.g. Panel, Button, Slider).
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/uiElement
        /// </summary>
        public readonly xAPI_Activity uiElement = new xAPI_Activity(
            context: "virtualReality",
            key: "uiElement",
            names: new Dictionary<string, string> {
                ["en-US"] = "VR user interface element",
                ["de-DE"] = "VR Benutzerflächenelement" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "An UI element in VR the user can interact with (e.g. Panel, Button, Slider).",
                ["de-DE"] = "Ein Benutzerflächenelement mit dem der Benutzer interagieren kann (z.B. Panel, Button, Slider)." });

        /// <summary>
        /// A virtual object in a VR environment.
        /// URI: https://omilaxr-ecosystem.github.io/xapi/definitions/virtualReality/activities/vrObject
        /// </summary>
        public readonly xAPI_Activity vrObject = new xAPI_Activity(
            context: "virtualReality",
            key: "vrObject",
            names: new Dictionary<string, string> {
                ["en-US"] = "VR object",
                ["de-DE"] = "VR Objekt" },
            descriptions: new Dictionary<string, string> {
                ["en-US"] = "A virtual object in a VR environment.",
                ["de-DE"] = "Ein virtuelles Objekt in einer VR Umgebung." });

        public xAPI_Activities_VirtualReality() 
            : base("virtualReality") {
        }
    }
}