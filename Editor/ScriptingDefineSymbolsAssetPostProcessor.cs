/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
#if UNITY_EDITOR
using System.IO;
using System.Linq;
using OmiLAXR.Editor;
using UnityEditor;
using UnityEngine;

namespace OmiLAXR.xAPI.Editor
{
    /// <summary>
    /// Unity Asset Postprocessor that automatically manages xAPI Registry scripting define symbols.
    /// Monitors file system changes to detect when the xAPI Registry folder is added or removed,
    /// automatically updating scripting defines to enable/disable xAPI-dependent code compilation.
    /// </summary>
    internal class ScriptingDefineSymbolsAssetPostProcessor : AssetPostprocessor
    {
        /// <summary>
        /// Flag to prevent recursive processing during define symbol updates.
        /// Ensures processing logic doesn't trigger additional asset processing cycles.
        /// </summary>
        private static bool _isProcessing = false;
        
        /// <summary>
        /// Flag to prevent multiple scheduled operations from being queued simultaneously.
        /// Ensures only one define symbol update operation is pending at any time.
        /// </summary>
        private static bool _scheduled = false;

        /// <summary>
        /// The scripting define symbol name used throughout the system for xAPI Registry detection.
        /// When this symbol is defined, xAPI-dependent code will be compiled and available.
        /// </summary>
        public const string XAPI_REGISTRY_EXISTS = "XAPI_REGISTRY_EXISTS";

        /// <summary>
        /// Location of the generated xAPI Registry. The define is set only while this folder exists.
        /// </summary>
        public const string XAPI_REGISTRY_FOLDER = "Assets/xAPI.Registry";

        /// <summary>
        /// Unity callback triggered after asset import/delete operations complete.
        /// Analyzes asset changes to detect xAPI Registry folder additions or removals,
        /// scheduling appropriate scripting define symbol updates when necessary.
        /// </summary>
        /// <param name="importedAssets">Array of asset paths that were imported</param>
        /// <param name="deletedAssets">Array of asset paths that were deleted</param>
        /// <param name="movedAssets">Array of asset paths that were moved</param>
        /// <param name="movedFromAssetPaths">Array of original paths for moved assets</param>
        private static void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets,
            string[] movedFromAssetPaths)
        {
            // Prevent recursive processing and duplicate operations
            if (_isProcessing || _scheduled)
                return;

            // Check current state of the define symbol
            var defineExists = DefineUtility.IsDefined(XAPI_REGISTRY_EXISTS);

            // Only react when a folder named xAPI.Registry was added, deleted or moved somewhere
            var registryTouched = importedAssets.Concat(deletedAssets).Concat(movedAssets).Concat(movedFromAssetPaths)
                .Any(path => Path.GetFileName(path) == "xAPI.Registry");
            if (!registryTouched)
                return;

            // Decide by the registry in the Assets root, like xApiRegistryFolderChecker, so that adding or
            // deleting another folder with that name (e.g. an imported sample) does not flip the define
            var registryExists = AssetDatabase.IsValidFolder(XAPI_REGISTRY_FOLDER);
            var shouldAdd = !defineExists && registryExists;
            var shouldRemove = defineExists && !registryExists;
            
            // Exit if no relevant changes detected
            if (!shouldAdd && !shouldRemove)
                return;

            // Schedule the define symbol update operation
            _scheduled = true;

            // Use delayed call to ensure all asset processing is complete
            EditorApplication.delayCall += () =>
            {
                _isProcessing = true;

                try
                {
                    if (shouldAdd)
                    {
                        // Add the define symbol when xAPI Registry is detected
                        DefineUtility.Set(XAPI_REGISTRY_EXISTS);
                        DebugLog.xAPI.Print("xAPI.Registry does exist! \"XAPI_REGISTRY_EXISTS\" was set. You can start working with xAPI.Registry.");
                    }
                    else if (shouldRemove)
                    {
                        // Remove the define symbol when xAPI Registry is deleted
                        DefineUtility.Unset(XAPI_REGISTRY_EXISTS);
                        DebugLog.xAPI.Error("xAPI.Registry folder deleted! \"XAPI_REGISTRY_EXISTS\" was removed. If you like to work with xAPI.Registry, please use xAPI4Unity to create it.");
                    }
                }
                finally
                {
                    // Reset processing flags to allow future operations
                    _isProcessing = false;
                    _scheduled = false;
                }
            };
        }
    }
}
#endif