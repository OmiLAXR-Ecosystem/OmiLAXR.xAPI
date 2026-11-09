/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
#if UNITY_EDITOR
using System.Collections.Generic;
using System.IO;
using OmiLAXR.Editor;
using OmiLAXR.Editor.Wizard;
using UnityEditor;
using UnityEngine;

namespace OmiLAXR.xAPI.Editor
{
    /// <summary>
    /// xAPI section of the OmiLAXR Wizard: xAPI data provider, xAPI.Registry and the define that enables the xAPI composers.
    /// </summary>
    internal sealed class xApiWizardSection : IWizardSection
    {
        public string Title => "OmiLAXR.xAPI";
        public WizardStep Step => WizardStep.Required;
        public int Order => 10;

        private static string RegistryFolder => ScriptingDefineSymbolsAssetPostProcessor.XAPI_REGISTRY_FOLDER;
        private static string RegistryDefine => ScriptingDefineSymbolsAssetPostProcessor.XAPI_REGISTRY_EXISTS;

        public IEnumerable<WizardCheck> GetChecks()
        {
            yield return new WizardCheck(
                "xAPI data provider in the open scene",
                WizardScene.Contains<xApiDataProvider>,
                "The xAPI data provider prefab contains the xAPI composers, hooks and endpoints.",
                "Add prefab", AddPrefabToScene.AddPrefab);

            yield return new WizardCheck(
                $"'{RegistryFolder}' exists",
                () => Directory.Exists(RegistryFolder),
                "The xAPI composers need the generated xAPI.Registry. Copy the bundled sample or generate it with xAPI4Unity.",
                "Copy sample", OmiLAXR_xAPI_SampleCopier.CopyXApiRegFolderFromSamples);

            yield return new WizardCheck(
                $"Scripting define '{RegistryDefine}' is set",
                () => DefineUtility.IsDefined(RegistryDefine),
                $"Without it, the xAPI composers compile out. It is set automatically once '{RegistryFolder}' exists.",
                "Check again", xApiRegistryFolderChecker.CheckOnEditorStartup);
        }

        public void OnGUI()
        {
            // Deferred, because refreshing the AssetDatabase in the middle of OnGUI breaks the IMGUI layout
            if (GUILayout.Button("Add xAPI data provider prefab to the scene"))
                EditorApplication.delayCall += AddPrefabToScene.AddPrefab;
            if (GUILayout.Button("Copy sample 'xAPI.Registry' to Assets"))
                EditorApplication.delayCall += OmiLAXR_xAPI_SampleCopier.CopyXApiRegFolderFromSamples;
            if (GUILayout.Button("Copy sample 'xapi' definitions to Assets"))
                EditorApplication.delayCall += OmiLAXR_xAPI_SampleCopier.CopyXApiDefFolderFromSamples;
            if (GUILayout.Button("Copy sample 'xapi.config.json' to Assets"))
                EditorApplication.delayCall += OmiLAXR_xAPI_SampleCopier.CopyXApiTypesFromSamples;
        }
    }
}
#endif
