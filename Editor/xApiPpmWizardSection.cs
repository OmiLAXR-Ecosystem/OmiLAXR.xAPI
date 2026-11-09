/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
#if UNITY_EDITOR
using System.Collections.Generic;
using OmiLAXR.Editor.Wizard;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
#if XAPI_REGISTRY_EXISTS
using OmiLAXR.xAPI.Hooks;
#endif

namespace OmiLAXR.xAPI.Editor
{
    /// <summary>
    /// Peripheral physiological measures (PPM) part of the tracking step: the PPM hook adds the heart rate to xAPI statements.
    /// </summary>
    internal sealed class xApiPpmWizardSection : IWizardSection
    {
        public string Title => "PPM (xAPI)";
        public WizardStep Step => WizardStep.Tracking;
        public int Order => 10;

        public IEnumerable<WizardCheck> GetChecks()
        {
#if XAPI_REGISTRY_EXISTS
            yield return new WizardCheck(
                "PPM hook on the xAPI data provider",
                WizardScene.Contains<PpmHook>,
                "The PPM hook adds the current heart rate to every xAPI statement as a result extension.",
                "Add PPM hook", AddPpmHook,
                optional: true);
#else
            yield return new WizardCheck(
                "PPM hook on the xAPI data provider",
                () => false,
                $"The PPM hook needs the xAPI.Registry and '{ScriptingDefineSymbolsAssetPostProcessor.XAPI_REGISTRY_EXISTS}'. Set them up in 'Required' first.",
                optional: true);
#endif
        }

        public void OnGUI()
        {
#if XAPI_REGISTRY_EXISTS
            var hook = WizardScene.Find<PpmHook>();
            EditorGUILayout.LabelField(
                hook ? $"PPM hook: {hook.name}" : "Adds a 'PPM Hook' child to the xAPI data provider in the open scene.",
                EditorStyles.wordWrappedLabel);
            using (new EditorGUI.DisabledScope(hook))
            {
                // Deferred, because changing the hierarchy in the middle of OnGUI breaks the IMGUI layout
                if (GUILayout.Button("Add PPM hook to the xAPI data provider"))
                    EditorApplication.delayCall += AddPpmHook;
            }
#else
            EditorGUILayout.LabelField("Available once the xAPI.Registry is set up.", EditorStyles.wordWrappedLabel);
#endif
        }

#if XAPI_REGISTRY_EXISTS
        private static void AddPpmHook()
        {
            var provider = WizardScene.Find<xApiDataProvider>();
            if (!provider)
            {
                DebugLog.xAPI.Error("No xAPI data provider in the open scene. Add the OmiLAXR.xAPI prefab first.");
                return;
            }

            var go = new GameObject("PPM Hook");
            Undo.RegisterCreatedObjectUndo(go, "Add PPM Hook");
            go.transform.SetParent(provider.transform, false);
            go.AddComponent<PpmHook>();
            EditorSceneManager.MarkSceneDirty(go.scene);
            Selection.activeGameObject = go;
            DebugLog.xAPI.Print($"Added PPM hook to '{provider.name}'.");
        }
#endif
    }
}
#endif
