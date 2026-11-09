#if XAPI_REGISTRY_EXISTS

using System;
using System.ComponentModel;
using OmiLAXR.Components;
using OmiLAXR.Components.Gaze;
using OmiLAXR.Composers;
using OmiLAXR.TrackingBehaviours.Learner.Gaze;
using UnityEngine;
using OmiLAXR.Utils;

namespace OmiLAXR.xAPI.Composers.Attention
{
    /// <summary>
    /// xAPI composer for gaze-based attention on VR objects.
    /// Emits: hovered, fixated, exited, saccaded, pursued — enriched with AOI/target name,
    /// frustum/pose context, per-eye metrics, and gaze geometry.
    /// </summary>
    [AddComponentMenu("OmiLAXR / 4) Composers / [xAPI] Eye Gaze Composer")]
    [Description("Creates statements:" +
                 "\n- actor hovered vrObject with vrObjectName(String), frustum(Frustum), position(vec3), rotation(vec3), scale(vec3), eye(left|right|both), eyeDepth(m), eyeHeight(m), startGazeCoordinates(vec3), endGazeCoordinates(vec3), pupilConfidence[0..1], viewingAngle(deg), gazeIncidenceAngle(deg)" +
                 "\n- actor fixated vrObject with ref(prior hovered), duration(Duration), timestamp(DateTime), vrObjectName(String), totalFixations(Int), frustum(Frustum), position(vec3), rotation(vec3), scale(vec3), plus per-eye data as above" +
                 "\n- actor exited vrObject with ref(prior hovered), vrObjectName(String), frustum(Frustum), position(vec3), rotation(vec3), scale(vec3), plus per-eye data as above" +
                 "\n- actor saccaded vrObject with ref(prior hovered), aoiName(String), saccadeAmplitude(deg), saccadeDuration(Duration), startGazeCoordinates(vec3), endGazeCoordinates(vec3), pupilConfidence[0..1], viewingAngle(deg), gazeIncidenceAngle(deg), pupilDiameter(mm)?" +
                 "\n- actor pursued vrObject with ref(prior hovered), duration(Duration), timestamp(DateTime), vrObjectName(String), trackingError(deg), averageEyeVelocity(deg/s), pursuitOnsetLatency(ms)?, pursuitMeanConfidence[0..1]?, dropoutCount(Int)?, pursuitGain?, plus frustum/pose and per-eye data; activity targetVelocity(deg/s)?")]
    public sealed class EyeGazeComposer : xApiComposer<EyeGazeTrackingBehaviour>
    {
        /// <summary>
        /// Returns the composer group this component belongs to.
        /// </summary>
        /// <returns>The <see cref="ComposerGroup.Attention"/> group.</returns>
        public override ComposerGroup GetGroup() => ComposerGroup.Attention;

        /// <summary>
        /// Provides author metadata for this composer.
        /// </summary>
        /// <returns>Author information including name and contact.</returns>
        public override Author GetAuthor()
            => new Author("Sergej Görzen", "goerzen@cs.rwth-aachen.de");

        /// <summary>
        /// Adds per-eye data and common gaze hit metadata to the provided xAPI statement.
        /// </summary>
        /// <param name="statement">The xAPI statement to augment.</param>
        /// <param name="eyeData">The eye data captured at the event time.</param>
        /// <remarks>
        /// Includes eye side, depth/height, world-space gaze origin and hit point, pupil confidence,
        /// as well as viewing and incidence angles derived from the gaze hit.
        /// </remarks>
        private static void SetEyeData(xApiStatement statement, EyeData eyeData)
        {
            statement.WithResult(xapi.eyeTracking.extensions.result
                        .eye(eyeData.EyeSide) // left/right/both
                        .eyeDepth(eyeData.EyeDepth) // eye depth in world space
                        .eyeHeight(eyeData.EyeHeight) // eye height in world space
                        .pupilConfidence(eyeData.EyeConfidence) // confidence score from the tracker
                )
                .WithResult(xapi.attention.extensions.result
                    .startGazeCoordinates(eyeData.GazeOriginWorld) // origin of gaze ray (world)
                    .endGazeCoordinates(eyeData.GazePointWorld)// gaze hit point (world)
                    .viewingAngle(eyeData.Hit.ViewingAngleDeg) // angle between view dir and surface normal
                    .gazeIncidenceAngle(eyeData.Hit
                        .IncidenceAngleDeg)); // angle of incidence onto the target) 
        }
        
        /// <summary>
        /// Subscribes to <see cref="EyeGazeTrackingBehaviour"/> events and composes corresponding xAPI statements.
        /// </summary>
        /// <param name="tb">The tracking behaviour that raises gaze events.</param>
        /// <remarks>
        /// The method:
        /// - Stores a reference to the "entered/hovered" statement per source to link subsequent events.
        /// - Emits enriched statements for fixation, saccade, pursuit, and exit with AOI, frustum, and eye data.
        /// </remarks>
        protected override void Compose(EyeGazeTrackingBehaviour tb)
        {
            // Gaze entered/hovered AOI: start of attention on a target.
            // We store the statement reference to link subsequent events (fixation/saccade/exit).
            tb.OnGazeEntered.AddHandler((sender, eyeData) =>
            {
                var gazeHit = eyeData.Hit;
                var t = gazeHit.Source.transform; // usually camera/eye anchor transform
                var go = gazeHit.Target.gameObject;

                var stmt = actor.Does(xapi.generic.verbs.hovered)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    // Scene pose context for reproducibility and analytics
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(eyeData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale))
                    // AOI metadata (human-readable identifier)
                    .WithValue(xapi.virtualReality.extensions.activity
                        .vrObjectName(go.GetTrackingName()));

                SetEyeData(stmt, eyeData);

                // Keep reference to link later events (fixation, exit, saccade, pursuit)
                StoreStatement(sender, eyeData.Hit.Source, stmt);
                SendStatement(sender, stmt);
            });

            // Fixation on AOI: emitted after gaze dwell meets fixation criteria.
            tb.OnFixated.AddHandler((sender, eyeData, fixationData) =>
            {
                var t = fixationData.Hit.Source.transform;
                // Reference previously stored "entered/hovered" statement to keep event chain
                var go = fixationData.Hit.Target.gameObject;
                var refStmt = RestoreStatement(sender, fixationData.Hit.Source);

                // Prefer explicit end time of the fixation window for timestamp consistency
                var endTime = fixationData.EndTime!.Value;

                var stmt = actor.Does(xapi.attention.verbs.fixated)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithRef(refStmt)                       // causal link to "entered"
                    .WithDuration(fixationData.Duration)    // full fixation duration
                    .WithTimestamp(endTime)                 // end time of fixation segment
                    .WithValue(xapi.virtualReality.extensions.activity.vrObjectName(go.GetTrackingName()))
                    .WithValue(xapi.attention.extensions.activity
                        .totalFixations(fixationData.TargetFixationCounts)) // cumulative fixations on target
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(eyeData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale));

                SetEyeData(stmt, eyeData);
                SendStatement(sender, stmt);
            });

            // Gaze left AOI: end of attention on a target.
            tb.OnGazeLeft.AddHandler((sender, eyeData) =>
            {
                var t = eyeData.Hit.Source.transform;
                var go = eyeData.Hit.Target.gameObject;

                // Link to the "entered/hovered" to close the attention episode
                var refStmt = RestoreStatement(sender, eyeData.Hit.Source);

                var stmt = actor.Does(xapi.generic.verbs.exited)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithRef(refStmt)
                    .WithValue(xapi.virtualReality.extensions.activity
                        .vrObjectName(go.GetTrackingName()))
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(eyeData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale));

                SetEyeData(stmt, eyeData);
                SendStatement(sender, stmt);
            });

            // Saccade event within/onto an AOI: rapid eye movement parameters.
            tb.OnSaccaded.AddHandler((sender, eyeData, saccadeData) =>
            {
                // Maintain chain with prior "entered/hovered"
                var refStmt = RestoreStatement(sender, eyeData.Hit.Source);

                var stmt = actor.Does(xapi.eyeTracking.verbs.saccaded)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithRef(refStmt)
                    .WithExtension(xapi.attention.extensions.activity
                        .aoiName(eyeData.Hit.Target.GetTrackingName()))
                    // Saccade kinematics + per-eye angles/confidence
                    .WithResult(xapi.eyeTracking.extensions.result
                        .saccadeAmplitude(saccadeData.SaccadeAmplitudeDegrees)
                        .saccadeDuration(saccadeData.Duration)
                        .pupilConfidence(eyeData.EyeConfidence)
                    )
                    .WithResult(xapi.attention.extensions.result
                        .startGazeCoordinates(saccadeData.StartGazeCoordinates)
                        .endGazeCoordinates(saccadeData.EndGazeCoordinates)
                        .viewingAngle(eyeData.Hit.ViewingAngleDeg)
                        .gazeIncidenceAngle(eyeData.Hit.IncidenceAngleDeg));

                // Emit pupil diameter only if provided by the tracker
                if (saccadeData.PupilDiameterMillimeters.HasValue)
                {
                    stmt.WithResult(
                        xapi.eyeTracking.extensions.result.pupilDiameter(saccadeData.PupilDiameterMillimeters.Value));
                }
                
                SendStatement(sender, stmt);
            });

            // Smooth pursuit event: continuous tracking of a moving target with eye(s).
            tb.OnPursuit.AddHandler((sender, eyeData, pursuitData) =>
            {
                 // Restore reference to the prior "entered/hovered" statement for this source
                var refStmt = RestoreStatement(sender, eyeData.Hit.Source);

                var t  = eyeData.Hit.Source.transform;
                var go = eyeData.Hit.Target.gameObject;

                // Use the end-of-segment timestamp when available to anchor the event time
                var endTime = pursuitData.EndTime ?? Clock.UtcNow;

                var stmt = actor.Does(xapi.eyeTracking.verbs.pursued)
                    .Activity(xapi.virtualReality.activities.vrObject)
                    .WithRef(refStmt)
                    .WithTimestamp(endTime)
                    .WithDuration(pursuitData.Duration)
                    // AOI metadata
                    .WithValue(xapi.virtualReality.extensions.activity
                        .vrObjectName(go.GetTrackingName()))
                    // Scene/camera context (frustum + pose) for spatial reproducibility
                    .WithValue(xapi.virtualReality.extensions.result
                        .frustum(eyeData.Frustum)
                        .position(t.position)
                        .rotation(t.eulerAngles)
                        .scale(t.localScale))
                    // Pursuit quality metrics (error/velocity)
                    .WithResult(xapi.eyeTracking.extensions.result
                        .trackingError(pursuitData.TrackingErrorDeg)
                        .averageEyeVelocity(pursuitData.AvgVelocityDegPerSec));

                // Optional kinematic/quality fields (add only when present)
                if (pursuitData.TargetVelocityDegPerSec.HasValue)
                    stmt.WithValue(
                        xapi.virtualReality.extensions.activity.targetVelocity(pursuitData.TargetVelocityDegPerSec.Value));
                
                if (pursuitData.PursuitLatencyMs.HasValue)
                    stmt.WithValue(xapi.eyeTracking.extensions.result
                        .pursuitOnsetLatency(pursuitData.PursuitLatencyMs.Value));

                if (pursuitData.MeanConfidence.HasValue)
                    stmt.WithValue(xapi.eyeTracking.extensions.result
                        .pursuitMeanConfidence(pursuitData.MeanConfidence.Value));

                if (pursuitData.DropoutCount.HasValue)
                    stmt.WithValue(xapi.eyeTracking.extensions.result
                        .dropoutCount(pursuitData.DropoutCount.Value));

                if (pursuitData.Gain.HasValue)
                    stmt.WithValue(xapi.eyeTracking.extensions.result.pursuitGain(pursuitData.Gain.Value));

                // Add per-eye fields, viewing/incidence angles, etc.
                SetEyeData(stmt, eyeData);

                SendStatement(sender, stmt);
            });
        }
    }
}

#endif