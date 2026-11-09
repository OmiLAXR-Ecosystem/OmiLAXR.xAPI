/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
using OmiLAXR.Composers;
using OmiLAXR.Hooks;
using OmiLAXR.xAPI.Composers;
using UnityEngine;
using xAPI.Registry;

namespace OmiLAXR.xAPI.Hooks
{
    /// <summary>
    /// Abstract base class for all xAPI-specific hooks within the OmiLAXR analytics pipeline.
    /// Provides common xAPI functionality and ensures type safety by processing only xApiStatement instances.
    /// Hooks allow post-processing modification of statements after composition but before transmission,
    /// enabling features like data anonymization, context enrichment, and statement transformation.
    /// </summary>
    [AddComponentMenu("OmiLAXR / 5) Hooks / xAPI Hook")]
    public abstract class xApiHook : Hook
    {
        /// <summary>
        /// Provides access to the xAPI Registry contexts for creating standardized xAPI extensions and modifications.
        /// Enables hooks to add or modify statement components using consistent xAPI vocabulary
        /// and extension definitions throughout the analytics pipeline.
        /// </summary>
        protected readonly xAPI_Contexts xapi = new xAPI_Contexts();

        private xApiRegistry _registry;
        public xApiRegistry Registry => _registry ? _registry : _registry = GetComponentInParent<xApiRegistry>();

        /// <summary>
        /// Processes generic IStatement instances by filtering for xAPI-specific statements.
        /// Ensures type safety by only processing xApiStatement instances and passing through
        /// incompatible statement types unchanged. Delegates actual xAPI processing to concrete implementations.
        /// </summary>
        /// <param name="statement">The statement to be processed, expected to be an xApiStatement</param>
        /// <returns>Processed statement if xAPI-compatible, otherwise the original statement unchanged</returns>
        public override IStatement AfterCompose(IStatement statement)
            => statement.GetType() != typeof(xApiStatement) ? statement : AfterCompose(statement as xApiStatement);

        /// <summary>
        /// Abstract method that concrete xAPI hook implementations must override to process xAPI statements.
        /// Defines the contract for modifying validated xApiStatement instances in hook-specific ways,
        /// such as adding context information, anonymizing data, or enriching statements with additional metadata.
        /// </summary>
        /// <param name="statement">The validated xApiStatement instance to be processed</param>
        /// <returns>Modified xApiStatement with hook-specific transformations applied</returns>
        protected abstract xApiStatement AfterCompose(xApiStatement statement);
    }
}