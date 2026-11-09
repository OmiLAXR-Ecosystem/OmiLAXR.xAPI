/*
* SPDX-License-Identifier: AGPL-3.0-or-later
* Copyright (C) 2025 Sergej Görzen <sergej.goerzen@gmail.com>
* This file is part of OmiLAXR.xAPI.
*/
#if XAPI_REGISTRY_EXISTS
using System;
using System.ComponentModel;
using OmiLAXR.Context;
using OmiLAXR.xAPI.Composers;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace OmiLAXR.xAPI.Hooks
{
    /// <summary>
    /// xAPI hook for enriching statements with comprehensive scenario and environmental context.
    /// Automatically adds system information, application metadata, performance metrics, and
    /// learning scenario context to statements, providing rich environmental data that enhances
    /// learning analytics analysis capabilities and enables cross-platform comparison studies.
    /// </summary>
    [AddComponentMenu("OmiLAXR / 5) Hooks / Scenario Context Hook (xAPI)")]
    [Description("Adds language by <ScenarioLanguage>, platform by <PlatformInformation>, fps by <FpsMonitor>, registration by <Registration> and active scene, game and game version to the context of all statements.")]
    public sealed class ScenarioContextHook : xApiHook
    {
        /// <summary>
        /// Processes xAPI statements by enriching them with comprehensive scenario context information.
        /// Queries available context providers and adds language, platform, performance, registration,
        /// and application metadata to statement context, creating rich environmental context for
        /// detailed learning analytics analysis and cross-session comparison capabilities.
        /// </summary>
        /// <param name="statement">The xApiStatement to enrich with scenario context</param>
        /// <returns>xApiStatement enriched with available scenario and environmental context data</returns>
        protected override xApiStatement AfterCompose(xApiStatement statement)
        {
            // Add language context if a language provider (by default <ScenarioLanguage>) is available
            var language = ScenarioContext.Language;
            if (language != null)
                statement.WithLanguage(language.GetLanguageCode());

            // Add platform information context if a platform provider (by default <PlatformInformation>) is available
            var platform = ScenarioContext.Platform;
            if (platform != null)
            {
                var composer = statement.GetComposer();
                // Generate platform string with xAPI specifications and composer context
                statement.WithPlatform(platform.GetPlatformString("xAPI", "2.2.5", composer));
            }

            // Add performance context (FPS) if an enabled FPS provider (by default <FpsMonitor>) is available
            var fps = ScenarioContext.Fps?.GetFps();
            if (fps.HasValue)
                statement.WithContext(xapi.systemControl.extensions.context.fps(fps.Value));

            // Add registration UUID context; registrations without a valid UUID are skipped
            var registration = ScenarioContext.Registration?.GetRegistration();
            if (registration.HasValue)
                statement.WithRegistration(registration.Value);
            
            // Add application and scene context information
            var activeScene = SceneManager.GetActiveScene();
            var sceneName = activeScene.name; // Get current Unity scene name
            
            // Add game/application identification context
            statement.WithContext(xapi.seriousGames.extensions.context.game(Application.productName));
            
            // Add learning scenario and version context for comprehensive environment tracking
            statement.WithContext(xapi.generic.extensions.context
                .learningScenario(sceneName)    // Current scene as learning scenario identifier
                .version(Application.version)); // Application version for compatibility tracking

            return statement;
        }
    }
}
#endif