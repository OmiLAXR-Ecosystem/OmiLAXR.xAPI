/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
using System.Collections.Generic;
using System.ComponentModel;
using OmiLAXR.Composers;
using OmiLAXR.Endpoints;
using TinCan;
using UnityEngine;

namespace OmiLAXR.xAPI.Endpoints
{
    /// <summary>
    /// Unity component for sending xAPI statements to a Learning Record Store (LRS) endpoint.
    /// Provides asynchronous batch transmission of learning analytics data with platform-specific
    /// optimizations for WebGL and desktop builds, including automatic retry mechanisms and error handling.
    /// </summary>
    [AddComponentMenu("OmiLAXR / 6) Endpoints / Learning Record Store (LRS for xAPI)")]
    [Description("Sends all received statements to a Learning Record Store asynchronously.")]
    public class LearningRecordStore : BasicAuthEndpoint
    {
        [TCAPIVersionDropdown]
        [SerializeField, Header("This version will overwrite the version of [xApiRegistry]."), InspectorName("xAPI Version")] public string version = "1.0.3";
        
        /// <summary>
        /// Platform-specific LRS client implementation for handling HTTP communication.
        /// Uses WebGL-compatible wrapper for browser builds and standard RemoteLRS for desktop.
        /// </summary>
        private ILRSClient _lrsClient;

        /// <summary>
        /// Maximum number of statements to send in a single batch to the LRS.
        /// Optimizes network efficiency while preventing oversized HTTP requests that might fail.
        /// </summary>
        protected override int MaxBatchSize => 20;
        
        #if UNITY_WEBGL && UNITY_EDITOR
        /// <summary>
        /// Editor validation method that warns developers about WebGL CORS requirements.
        /// WebGL builds have additional security constraints that may require LRS configuration changes.
        /// </summary>
        private void OnValidate()
        {
            Debug.LogWarning($"{nameof(LearningRecordStore)} is in use, but WebGL builds require a CORS-enabled LRS endpoint or a proxy to work correctly.");
        }
        #endif
        
        /// <summary>
        /// Static utility method for transferring statements to an LRS with individual result tracking.
        /// Provides synchronous statement transmission with detailed success/failure reporting
        /// for each statement in the batch, useful for debugging and monitoring.
        /// </summary>
        /// <param name="lrs">The LRS interface to send statements through</param>
        /// <param name="statements">Collection of TinCan Statement objects to transmit</param>
        /// <returns>Dictionary mapping each statement to its transmission success status</returns>
        public static Dictionary<Statement, bool> TransferStatements(ILRS lrs, IEnumerable<Statement> statements)
        {
            var resultTransferStatements = new Dictionary<Statement, bool>();
            foreach (var statement in statements)
            {
                // Transfer each statement individually and record the result
                var response = lrs.SaveStatement(statement);
                // Map statement to its transmission success status
                resultTransferStatements.Add(statement, response.success);
            }

            return resultTransferStatements;
        }

        /// <summary>
        /// Initializes the LRS client connection and begins the statement sending process.
        /// Selects appropriate client implementation based on the target platform and
        /// configures authentication using the provided credentials.
        /// </summary>
        /// <param name="resetQueue">Whether to clear any previously queued statements before starting</param>
        public override void StartSending(bool resetQueue = false)
        {
            var credentials = Credentials;

            #if UNITY_WEBGL
            // Use WebGL-compatible wrapper for browser builds
            _lrsClient = new WebGLLRSClientWrapper(credentials.endpoint, credentials.username, credentials.password, this);
            #else
            // Use standard RemoteLRS for desktop/mobile builds
            var remoteLrs = new RemoteLRS(credentials.endpoint, TCAPIVersion.GetSupported()[version], credentials.username, credentials.password);
            _lrsClient = new RemoteLRSClientWrapper(remoteLrs);
            #endif
            
            base.StartSending(resetQueue);
        }

        /// <summary>
        /// Handles the transmission of a batch of statements to the LRS.
        /// Manages platform-specific sending logic and error handling, including
        /// automatic retry mechanisms for failed transmissions on non-WebGL platforms.
        /// </summary>
        /// <param name="batch">List of IStatement instances to send as a batch</param>
        /// <returns>TransferCode indicating the overall result of the batch transmission</returns>
        protected override TransferCode HandleSending(List<IStatement> batch)
        {
            if (batch.Count == 0)
                return TransferCode.NoStatements;

            // Initialize transmission state variables
            var isSending = true;
            var success = false;

            // Start asynchronous statement transmission
            _lrsClient.SendStatements(batch, result =>
            {
                success = result;
                isSending = false;
            });

            #if UNITY_WEBGL
            // WebGL builds handle results asynchronously through coroutines
            return TransferCode.Success;
            #else
            // Desktop builds wait for completion and handle failures synchronously
            while (isSending)
            {
                System.Threading.Thread.Sleep(10); // Polling wait
            }

            if (!success)
            {
                // Handle transmission failure by re-queuing statements and triggering error events
                foreach (var statement in batch)
                {
                    TriggerFailedStatement(statement);
                    QueuedStatements.Enqueue(statement); // Retry mechanism
                }
                TriggerFailedBatch(batch);
                return TransferCode.Error;
            }

            // Trigger success events for each transmitted statement
            foreach (var statement in batch)
                TriggerSentStatement(statement);

            return TransferCode.Success;
            #endif
        }

        /// <summary>
        /// Handles individual statement sending requests.
        /// This LRS implementation only supports batch sending for efficiency,
        /// so individual statement requests are rejected with an error message.
        /// </summary>
        /// <param name="stmt">The individual statement that was requested to be sent</param>
        /// <returns>TransferCode.Error as single statement sending is not supported</returns>
        protected override TransferCode HandleSending(IStatement stmt)
        {
            DebugLog.xAPI.Error("Single statement sending is not supported. Use batch sending.");
            return TransferCode.Error;
        }
    }
}