/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using TinCan;
using UnityEngine;
using xAPI.Registry;

namespace OmiLAXR.xAPI
{
    /// <summary>
    /// Unity component for managing xAPI Registry configuration and vocabulary definitions.
    /// Provides centralized access to xAPI Registry contexts and URI configuration for
    /// consistent xAPI statement generation across all composers, hooks, and endpoints
    /// within the OmiLAXR analytics framework, ensuring xAPI specification compliance.
    /// </summary>
    [AddComponentMenu("OmiLAXR / xAPI Registry")]
    [Description("This is an instance for managing xAPI Registry settings.")]
    public class xApiRegistry : MonoBehaviour
    {
        /// <summary>
        /// Static instance of xAPI Registry contexts containing all vocabulary definitions.
        /// Provides global access to standardized xAPI verbs, activities, extensions,
        /// and other vocabulary elements for consistent statement generation across
        /// the entire analytics pipeline and learning record creation.
        /// </summary>
        public static xAPI_Contexts definitions = new xAPI_Contexts();
        
        /// <summary>
        /// Base of the xAPI Registry IRIs, hosted on GitHub Pages.
        /// </summary>
        public const string DefaultUri = "https://omilaxr-ecosystem.github.io/xapi/definitions";

        /// <summary>
        /// Former default bases. Every registry definition lists its IRI under such a base as exactMatch.
        /// </summary>
        public static readonly string[] FormerUris = { "https://xapi.elearn.rwth-aachen.de/definitions" };

        /// <summary>
        /// Base URI for resolving xAPI identifiers and vocabulary definitions.
        /// Used as the namespace root for generating properly formatted xAPI IRIs
        /// that ensure compatibility with xAPI Registry definitions and Learning Record Store
        /// requirements for semantic interoperability and data exchange.
        /// </summary>
        public string uri = DefaultUri;

        [TCAPIVersionDropdown]
        [SerializeField, InspectorName("xAPI Version")] public string version = "1.0.3";

        /// <summary>
        /// Set once <see cref="uri"/> was checked for a former default base. Scenes and prefabs saved
        /// before 2.2.5 don't have it, so their former base is replaced once; a former base entered
        /// afterwards on purpose is kept.
        /// </summary>
        [SerializeField, HideInInspector] private bool uriMigrated;

        /// <summary>
        /// Returns <see cref="DefaultUri"/> if <paramref name="value"/> is one of the <see cref="FormerUris"/>
        /// (with or without trailing slash), otherwise <paramref name="value"/> unchanged.
        /// </summary>
        public static string ToCurrentUri(string value)
        {
            if (value == null)
                return null;
            return Array.IndexOf(FormerUris, value.TrimEnd('/')) >= 0 ? DefaultUri : value;
        }

        private void Awake() => MigrateUri();

        private void OnValidate() => MigrateUri();

        private void MigrateUri()
        {
            if (uriMigrated)
                return;
            uriMigrated = true;
            var current = ToCurrentUri(uri);
            if (current == uri)
                return;
            Debug.Log($"[OmiLAXR.xAPI] xApiRegistry.uri changed from the former registry base '{uri}' to '{current}'.", this);
            uri = current;
        }

        // Note: TinCan.TCAPIVersion configuration commented out for future use
        // May be needed for explicit xAPI version control in advanced scenarios
        //private static TinCan.TCAPIVersion version = TinCan.TCAPIVersion.latest();
    }
}