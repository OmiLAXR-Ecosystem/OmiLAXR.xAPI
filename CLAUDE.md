# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

Working rules (versioning, CHANGELOG, `.meta` files, licenses, compatibility) are in @AGENTS.md. Follow them.

## What this is

`com.rwth.unity.omilaxr.xapi`: xAPI implementation of the OmiLAXR data side. It provides `xApiDataProvider`, xAPI composers for the core tracking behaviours, hooks, and LRS endpoints built on TinCan.

## Commands

There is no command-line build or linter: the package compiles inside a Unity project. Paths below are relative to the workspace root (`..`).

- **Develop:** open `OmiLAXR_Dev/` in Unity 6000.3.13f1. Its `Packages/manifest.json` links `com.rwth.unity.omilaxr.xapi` from disk (`file:`), so edits recompile live.
- **Tests** (`Tests/`, assembly `OmiLAXR.xAPI.Tests.Runtime`): the test asmdef is a runtime assembly, so the tests are PlayMode-only. Run them in the Unity Test Runner (PlayMode tab).
- **CLI test run.** Batch mode fails while the editor has the project open. In that case, run against an APFS copy (`cp -c -R OmiLAXR_Dev <scratch>/Dev`).

  ```bash
  /Applications/Unity/Hub/Editor/6000.3.13f1/Unity.app/Contents/MacOS/Unity -batchmode \
    -projectPath OmiLAXR_Dev -runTests -testPlatform PlayMode \
    -assemblyNames OmiLAXR.xAPI.Tests.Runtime -testResults results.xml
  # single test: replace -assemblyNames … with -testFilter OmiLAXR.xAPI.Tests.<Class>.<Method>
  ```

## Architecture

- **`xApiDataProvider`** (`Runtime/xApiDataProvider.cs`) is the core `DataProvider` for `xApiStatement`. Drop `Resources/Prefabs/OmiLAXR.xAPI` into a scene.
- **Statements** (`Runtime/Composers/xApiStatement.cs`): `xApiStatement` implements core `IStatement`. `xApiStatement.Builder` composes actor, verb, activity, context and extensions. Serialization goes through TinCan (`ToTinCanStatement`). `xAPIv1.cs` is a legacy static TinCan helper.
- **Composers** (`Runtime/Composers/<Domain>/`): `xApiComposer<TTrackingBehaviour>` turns a core tracking behaviour's events into statements, using the generated `xAPI.Registry` (`xapi.<domain>.verbs/activities/extensions`). XR adapter modules subclass core tracking behaviours, so these composers cover them without module-specific composers. Higher composers are in `Runtime/HigherComposers`.
- **Hooks** (`Runtime/Hooks/`): `xApiHook` is the base and passes foreign statements through unchanged. `ScenarioContextHook` adds language, platform, fps and registration via core `ScenarioContext`. There are also timestamp anonymizer hooks and `PpmHook`.
- **Endpoints** (`Runtime/Endpoints/`): `LearningRecordStore` sends to an xAPI LRS through `ILRSClient`. Standalone builds use `RemoteLRSClientWrapper` (TinCan); WebGL uses `WebGLLRSClientWrapper` (UnityWebRequest).
- **Registry codegen**: the generated code lives in `Assets/xAPI.Registry`. When that folder exists, `Editor/ScriptingDefineSymbolsAssetPostProcessor` sets the scripting define `XAPI_REGISTRY_EXISTS`, and removes it when the folder is deleted. Without the define, composers compile out. `OmiLAXR / Samples / Copy …` menu items copy the bundled samples into `Assets`.

**Test caveat.** The test asmdef has `defineConstraints: XAPI_REGISTRY_EXISTS`, so the xAPI tests only compile when a registry is present and the define is set. In `OmiLAXR_Dev` the define is currently not set, and the bundled `Samples~/xAPI.Registry` is older than the composers. To run the tests, regenerate the registry from the workspace `xapi/definitions` into `Assets/xAPI.Registry` and make sure `XAPI_REGISTRY_EXISTS` is defined. Base fixtures are in `Tests/Runtime/xApiTestFixture.cs`.
