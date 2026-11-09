#if XAPI_REGISTRY_EXISTS

using System;
using System.ComponentModel;
using OmiLAXR.Components;
using OmiLAXR.Composers;
using OmiLAXR.TrackingBehaviours.Learner.Gaze;
using UnityEngine;
using OmiLAXR.Utils;

namespace OmiLAXR.xAPI.Composers.Attention
{
    /// <summary>
    /// xAPI composer for camera-based gaze tracking.
    /// Emits statements for gaze enter (gazed), fixation (fixated), and gaze leave (averted)
    /// with spatial context, target metadata, and gaze geometry.
    /// </summary>
    [AddComponentMenu("OmiLAXR / 4) Composers / [xAPI] Camera Gaze Composer")]
    [Description("Creates statements:" +
                 "\n- actor gazed vrObject with vrObjectName(String), frustum(Frustum), position(vec3), rotation(vec3), scale(vec3), startGazeCoordinates(vec3), endGazeCoordinates(vec3), viewingAngle(deg), gazeIncidenceAngle(deg)" +
                 "\n- actor fixated vrObject with ref(prior gazed), duration(Duration), timestamp(DateTime), aoiName(String), totalFixations(Int), frustum(Frustum), startGazeCoordinates(vec3), endGazeCoordinates(vec3), fixationStart(DateTime), fixationEnd(DateTime), viewingAngle(deg), gazeIncidenceAngle(deg)" +
                 "\n- actor averted vrObject with ref(prior gazed), vrObjectName(String), frustum(Frustum), position(vec3), rotation(vec3), scale(vec3), startGazeCoordinates(vec3), endGazeCoordinates(vec3), viewingAngle(deg), gazeIncidenceAngle(deg)")]
    public sealed class CameraGazeComposer : xApiComposer<CameraGazeTrackingBehaviour>
    {
        /// <summary>
        /// Categorizes this composer under attention analytics.
        /// </summary>
        public override ComposerGroup GetGroup() => ComposerGroup.Attention;

        /// <summary>
        /// Author info for attribution/support.
        /// </summary>
        public override Author GetAuthor()
            => new Author("Sergej Görzen", "goerzen@cs.rwth-aachen.de");
        
        /// <summary>
        /// Binds xAPI statement generation to gaze tracking events: gazed, fixated, averted.
        /// </summary>
        protected override void Compose(CameraGazeTrackingBehaviour tb)
        {
            // Gaze entered a VR object.
            tb.OnGazeEntered.AddHandler((sender, cameraData) =>
            {
                var gazeHit = cameraData.Hit;
                var t = gazeHit.Source.transform;
                var go = gazeHit.Target.gameObject;
                var stmt = actor.Does(xapi.attention.verbs.gazed)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(cameraData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale))
                    .WithValue(xapi.virtualReality.extensions.activity
                        .vrObjectName(go.GetTrackingName()))
                    .WithResult(xapi.attention.extensions.result
                        .startGazeCoordinates(cameraData.GazeOriginWorld) // origin of gaze ray (world)
                        .endGazeCoordinates(cameraData.GazePointWorld)) // gaze hit point (world)
                    .WithResult(xapi.attention.extensions.result
                        .viewingAngle(cameraData.Hit.ViewingAngleDeg)
                        .gazeIncidenceAngle(cameraData.Hit.IncidenceAngleDeg));
                // Store to reference from fixation/averted.
                StoreStatement(sender, cameraData.Hit.Source, stmt);
                SendStatement(sender, stmt);
            });
            // Sustained fixation on the current VR object.
            tb.OnFixated.AddHandler((sender, cameraData, fixationData) =>
            {
                var t = fixationData.Hit.Source.transform;
                // get reference id from enter statement
                var go = fixationData.Hit.Target.gameObject;
                var refStmt = RestoreStatement(sender, fixationData.Hit.Source);
                // temp end time
                var endTime = fixationData.EndTime!.Value;
                // create fixation statement
                var stmt = actor.Does(xapi.attention.verbs.fixated)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithRef(refStmt)
                    .WithDuration(fixationData.Duration)
                    .WithTimestamp(endTime)
                    .WithValue(xapi.attention.extensions.activity
                        .aoiName(go.GetTrackingName())
                        .totalFixations(fixationData.TargetFixationCounts))
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(cameraData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale))
                    .WithResult(xapi.attention.extensions.result
                        .startGazeCoordinates(cameraData.GazeOriginWorld) // origin of gaze ray (world)
                        .endGazeCoordinates(cameraData.GazePointWorld)) // gaze hit point (world)
                    .WithResult(xapi.attention.extensions.result
                        .fixationStart(fixationData.StartTime!.Value)
                        .fixationEnd(endTime)
                        .viewingAngle(cameraData.Hit.ViewingAngleDeg)
                        .gazeIncidenceAngle(cameraData.Hit.IncidenceAngleDeg));
                SendStatement(sender, stmt);
            });
            // Gaze left the VR object.
            tb.OnGazeLeft.AddHandler((sender, cameraData) =>
            {
                var t = cameraData.Hit.Source.transform;
                var go = cameraData.Hit.Target.gameObject;
                // get reference id from enter statement
                var refStmt = RestoreStatement(sender, cameraData.Hit.Source);
                // temp end time
                var endTime = Clock.Now;
                var stmt = actor.Does(xapi.attention.verbs.averted)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(cameraData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale))
                    .WithValue(xapi.virtualReality.extensions.activity
                        .vrObjectName(go.GetTrackingName()))
                    .WithResult(xapi.attention.extensions.result
                        .startGazeCoordinates(cameraData.GazeOriginWorld) // origin of gaze ray (world)
                        .endGazeCoordinates(cameraData.GazePointWorld)) // gaze hit point (world)
                    .WithResult(xapi.attention.extensions.result
                        .viewingAngle(cameraData.Hit.ViewingAngleDeg)
                        .gazeIncidenceAngle(cameraData.Hit.IncidenceAngleDeg))
                    .WithRef(refStmt);
                SendStatement(sender, stmt);
            });
        }

    }
}

#endif