/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
#if UNITY_EDITOR

using System.IO;
using OmiLAXR.Editor;
using UnityEditor;
using UnityEngine;

namespace OmiLAXR.xAPI.Editor
{
    /// <summary>
    /// Unity Editor utility that automatically manages xAPI Registry availability detection.
    /// Monitors the existence of the xAPI Registry folder and sets/unsets the corresponding
    /// scripting define symbol to enable conditional compilation of xAPI-dependent code.
    /// </summary>
    internal class xApiRegistryFolderChecker
    {
        /// <summary>
        /// Expected path for the xAPI Registry folder within the Unity project.
        /// Must be located at the root of the Assets folder with this exact name.
        /// </summary>
        private const string FolderPath = ScriptingDefineSymbolsAssetPostProcessor.XAPI_REGISTRY_FOLDER;
        
        /// <summary>
        /// Gets the scripting define symbol name used for conditional compilation.
        /// References the symbol from the asset postprocessor for consistency.
        /// </summary>
        private static string XAPI_REGISTRY_EXISTS => ScriptingDefineSymbolsAssetPostProcessor.XAPI_REGISTRY_EXISTS;

        /// <summary>
        /// Manual menu item for checking xAPI Registry availability on demand.
        /// Also automatically runs when Unity Editor starts up via InitializeOnLoadMethod.
        /// Provides both manual and automatic detection capabilities.
        /// </summary>
        [MenuItem("OmiLAXR / Validation / Check if xAPI Registry exists")]
        [InitializeOnLoadMethod]
        private static void CheckOnEditorStartup()
        {
            if (Directory.Exists(FolderPath))
            {
                // Enable xAPI features if folder exists and define is not set
                if (!DefineUtility.IsDefined(XAPI_REGISTRY_EXISTS))
                {
                    DefineUtility.Set(XAPI_REGISTRY_EXISTS);
                    DebugLog.xAPI.Print($"\"{XAPI_REGISTRY_EXISTS}\" defined because folder exists at: '{FolderPath}'.");
                }
            }
            else
            {
                // Handle missing xAPI Registry folder
                if (DefineUtility.IsDefined(XAPI_REGISTRY_EXISTS))
                {
                    // Remove define if folder no longer exists
                    DefineUtility.Unset(XAPI_REGISTRY_EXISTS);
                    Debug.LogWarning($"Unset \"{XAPI_REGISTRY_EXISTS}\" because folder no longer exists.");
                }
                else
                {
                    // Provide guidance for setting up xAPI Registry
                    Debug.LogWarning(
                        $"xAPI.Registry not found at '{FolderPath}'. If needed, please create it via xAPI4Unity or import from package 'Samples'. Think of to place it with the name 'xAPI.Registry' to 'Assets' root.");
                }
            }
        }
    }
}
#endif