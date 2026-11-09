/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.
*/
#if XAPI_REGISTRY_EXISTS
using System.ComponentModel;
using OmiLAXR.Composers;
using OmiLAXR.TrackingBehaviours.Learner;
using UnityEngine;

namespace OmiLAXR.xAPI.Composers.Emotion
{
    /// <summary>
    /// xAPI composer for creating learning analytics statements from facial tracking.
    /// Produces statements for changes in facial blendshape weights and detected emotion states,
    /// including confidence metadata where available.
    /// </summary>
    [AddComponentMenu("OmiLAXR / 4) Composers / [xAPI] Facial Composer")]
    [Description(
        "Creates statements:" +
        "\n- actor changed face (activity: face) with values: weights(map<string,float>[0..1]); result includes confidence(map<string,float>[0..1])" +
        "\n- actor expressed emotion (activity: emotion) with values: emotionType(enum/string)"
    )]
    public class FacialComposer : xApiComposer<FacialTrackingBehaviour>
    {
        [Tooltip("Also send a statement for every face data update, not only for emotion changes. Produces many statements.")]
        public bool sendDataChange = false;
        
        /// <summary>
        /// Identifies the author of this composer implementation for attribution and support.
        /// </summary>
        /// <returns>Author information including name and contact details</returns>
        public override Author GetAuthor()
            => new Author("Sergej Görzen", "goerzen@cs.rwth-aachen.de");

        /// <summary>
        /// Configures xAPI statement composition for facial tracking events.
        /// Binds handlers for data updates (blendshape weights and confidences) and
        /// emotion changes (discrete emotion classification).
        /// </summary>
        /// <param name="tb">FacialTrackingBehaviour instance to bind event handlers to</param>
        protected override void Compose(FacialTrackingBehaviour tb)
        {
            // Emit a statement whenever facial blendshape data updates.
            // Includes: weights (per-feature [0..1]) and confidences (per-feature [0..1]).
            tb.OnDataUpdated.AddHandler((sender, data) =>
            {
                if (!sendDataChange)
                    return;
                var stmt = actor.Does(xapi.facialTracking.verbs.changed)
                    .Activity(xapi.facialTracking.activities.face)
                    // Attach current facial feature weights to the activity context.
                    .WithValue(xapi.facialTracking.extensions.activity.weights(data.Weights))
                    // Attach confidences to the result section for analytics reliability.
                    .WithResult(xapi.facialTracking.extensions.result.confidences(data.Confidences));
                SendStatement(tb, stmt);
            });
            // Emit a statement whenever the detected emotion state changes.
            // Includes: emotion type/category as the primary value.
            tb.OnEmotionChanged.AddHandler((sender, data) =>
            {
                var stmt = actor.Does(xapi.facialTracking.verbs.expressed)
                    .Activity(xapi.facialTracking.activities.emotion)
                    // Record the discrete emotion type provided by the tracker.
                    .WithValue(xapi.facialTracking.extensions.activity.emotionType(data.Emotion.EmotionType));
                SendStatement(tb, stmt);
            });
        }
    }
}
#endif