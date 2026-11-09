# Changelog

## [2.2.5] - 2026-11-09

### Changed
- `xApiStatement`, `xAPIv1` and the gaze composers take the time from the core `Clock`.
- `ScenarioContextHook` reads language, platform, FPS and registration through the core `ScenarioContext` instead of scene singletons.
- Raised the core dependency `com.rwth.unity.omilaxr` to 2.2.5, which provides `Clock` and `ScenarioContext`.
- Updated package version metadata.

### Fixed
- `xApiStatement.WithScore()` computes `scaled` as `raw / max`, limited to [-1, 1], instead of `min / max`.
- `xApiStatement.Clone()` also copies the ref ID, interaction type, correct responses, duration and attachments.
- `ScenarioContextHook` skips a registration that is not a valid UUID instead of failing every statement.
- `xApiHook.Registry` looks the registry up again after it was destroyed.

---

## [2.2.4] - 2026-07-03

### Fixed
- Fixed Unity Package Manager installation errors caused by the `xapi.config.json` sample being registered as a file instead of a sample directory.

---

## [2.2.3] - 2026-04-22

### Added
- Added `ExampleHigherComposer` sample under `Samples~/xApiComposers`.

### Changed
- Improved tracking-related statement performance in `xApiStatement`.
- Changed xAPI extension JSON serialization to preserve typed extension values.
- Updated package version metadata.

### Fixed
- Fixed incorrect context version handling in `ScenarioContextHook`.
- Removed a broken runtime higher-composer example and stabilized `xApiSemanticComposer`.

---

## [2.2.2] - 2025-12-09

### Added
- Added `string version` to `ToDataStandardString()`, `ToJsonString()` and `ToCsvFormat()` in `xApiStatement`.
- Added xAPI version selection to `Learning Record Store`. This selection will overwrite the default selection from `xApiRegistry`.

### Fixed
- Fixed issue that `Learning Record Store` still sends statements by default with version `2.0.0`.

## [2.2.1] - 2025-12-04

### Fixed
- Fixed an issue where changing the xAPI version had no effect and it remained at `2.0.0`. The default is now `1.0.3` and version changes are applied correctly.
- Removed various compiler warnings.

---

## [2.2.0] - 2025-10-13

### Breaking Changes
- Aktualisierung der `TinCan.dll` auf einen eigenen Fork: [TinCan.NET Fork](https://github.com/SGoerzen/TinCan.NET).
  - Unterstützung für xAPI 2.0 in Vorbereitung.
  - Hinzugefügte Unterstützung für Attachments.
  - Konsistentere URI-Verwendung.
  - Newtonsoft.Json von v8 auf v13 aktualisiert.
- Umstellung auf strikte Typen in `xAPI.Extensions`.
  - Um diese zu nutzen, kopiere `xapi.config.json` über das Menü `OmiLAXR / Samples / Copy 'xapi.config.json'` und baue die `xAPI.Registry` neu auf.
- Umbau des Statement Builders: `actor`, `Does` und `Activity` sind nun verpflichtend für gültige Statements.
- Die `xAPI Platform String` wurde überarbeitet zum Format:  
  `{UnityVersion}::{OmiLAXR.{Module}::{ComposerType}.{Composer}::{XRSDKVersion}`  
  Beispiel:  
  `UnityWindowsEditorv2022.3.62f2::OmiLAXR.xAPIv2.1.1::Other.FacialComposer::MetaXRv1.110.0`

### Added
- **Eye Tracking**:
  - Neue Ereignisse wie `actor hovered/fixated/exited/saccaded/pursued vrObject`.
  - Austauschbare Logiken für die Erkennung.
  - [Vorschauvideo](https://youtu.be/nPS3H5GoF1Q)

- **Facial Tracking**:
  - Neue Ereignisse: `actor changed face`, `actor expressed emotion`.

- **xAPI Features**:
  - Unterstützung für xAPI Attachments.
  - Vorbereitung für xAPI Version 2.0.0 (Standard bleibt 1.0.3, umschaltbar in `xAPI Registry`).
  - Viele neue Definitionen in der Registry ([siehe Diff](https://gitlab.com/learntech-rwth/xapi/-/merge_requests/54/diffs)).

- **UiComposer**:
  - Neues Ereignis: `"Pointed"` zur Interaktionserkennung.
  - Erfassung von Hover- und Druckdauer.
  - Zählung von Klicks während Hover und Gesamtanzahl an Klicks.

- **AreaComposer**:
  - Neue Ereignisse: `"actor entered/exited area/room"`.

- **StressComposer**:
  - Neue Ereignisse: `"actor stressed/relaxed/increased/decreased/updated stress"`.

- **Menu Items**:
  - `OmiLAXR / xAPI / Copy 'xapi' folder from Samples`
  - `OmiLAXR / xAPI / Copy 'xAPI.Registry' folder from Samples`
  - `OmiLAXR / xAPI / Copy 'xapi.types.json' folder from Samples`

- **Samples**:
  - Beispielkonfiguration: `xapi.types.json` (weitere Details in xAPI4Unity v2.2.1)

### Changed
- Verbesserte Benutzerführung beim Erstellen von xAPI Statements (UX des Builders optimiert).

---

## [2.1.2] - 2025-08-25

### Fixed
- `StressLevelComposer` was missing its required `xApiComposer` class.
- `WithRef()` and `WithDuration()` methods did not correctly apply reference or duration data to the resulting xAPI statement.

---

## [2.1.1] - 2025-08-17

### Added
- Handler in `InputSystemComposer` to generate xAPI-Statements for `OnReleasedAnyButton`.
- Pipeline delegates for richer events.
- License information added to each file.
- XML `<summary>` documentation added to each file, field, and function, plus additional code comments.
- All composers assigned to a composer group.

### Changed
- Platform information format updated to  
  `"OmiLAXR.{module}:{composerGroup}.{composerName}:v{version}:{Application.platform}"`.

### Fixed
- `LearningRecordStore` now works on WebGL.
- Platform version corrected.
- Improved reliability of the `actor ended game` statement.

### Deprecated
- None.

### Removed
- None.

### Security
- None.

## [2.1.0] - 2025-06-12

### Added
- **xApiStatement**
  - Added `.GetResultValue<T>(string key)`, `.GetContextValue<T>(string key)`, and `.GetExtensionValue<T>(string key)` for value access.
  - Introduced `WithValue(xAPI_Extensions extensions)` and `GetValue<T>(xAPI_Definition definition, T defaultValue = null)` to access and set values in activity, result, or context.
  - Implemented `ToCsvFormat(bool flatten)` for CSV conversion.
  - Added xAPI-compliant field methods:
    - `WithInteractionType(InteractionType)`
    - `WithCorrectResponses(params string[] | List<string>)`
    - `WithRef(Guid guid)`
    - `WithDuration(TimeSpan duration)`

- **Hooks**
  - Added support for timestamp pseudonymization and anonymization:
    - `ReferenceTimestampPseudonymizerHook`: Sets day to a reference date.
    - `TimestampPseudonymizerHook`: Applies a fixed date offset (default: 10 days).
    - `TimestampAnonymizerHook`: Applies a random date offset.
  - Platform metadata now includes composer and module info, e.g., `OmiLAXR.xAPI:TransformComposer:v2.1.0:OSXEditor`.

- **Samples**
  - Added samples under `Window / Package Manager / OmiLAXR.xAPI / Samples`:
    - xAPI definition files and registry used in this version.
    - `PositionDataCsvEndpoint` as a lightweight example using `IEndpoint`.
    - `CsvFileExampleEndpoint` using `CsvFile` helper class.

- **Other**
  - Added `LocalFileEndpoint` to Prefab.
  - Added duration information to teleport statements.

### Changed
- Statement URI resolution moved to composers via `xApiRegistry` in `DataProvider`.
- Renamed `xApiStatement.ActorRole` to `xApiStatement.Builder`.
- Statement `id` is now generated client-side.
- `StatementPrinter` is now enabled by default.
- `LearningRecordStore` and `BasicAuthCredentialsFileLoader` are now disabled by default.
- `Mouse` and `Keyboard` composers are now disabled by default.
- Improved fallback behavior for missing xAPI registry entries.

### Fixed
- **Critical**: Fixed an infinite loop when installing in large projects.
- Endpoint was incorrectly started even when `enabled = false`.
- General performance and compatibility improvements in the Unity Editor.

### Deprecated
- Removed `IStatement.SetComposer(IComposer)` method.

---

## [2.0.18] - 2025-06-06

### Changed
- Renamed `EventTrackingBehaviour` to `ObjectlessTrackingBehaviour` to avoid confusion with `TrackingBehaviourEvent`.
  - **Need for action:** If any xAPI Tracking Behaviours extend `EventTrackingBehaviour`, rename them to `ObjectlessTrackingBehaviour`.
- Made core xAPI Tracking Behaviours more extensible (`protected`, `virtual`).
- Improved Unity Package Manager compatibility for Unity ≥2020.3.15f.

---

## [2.0.13 - 2.0.17] - 2025-05-21

### Added
- `InteractableComposer`, `TeleportationComposer` and `InputSystemComposer`, moved here from `OmiLAXR.UnityXR.xAPI`.
- `HeadComposer`.
- `SessionComposer`. Sessions use the registration as session ID.
- `XAPI_REGISTRY_EXISTS` scripting define, set by `ScriptingDefineSymbolsAssetPostProcessor` and `xApiRegistryFolderChecker` when `Assets/xAPI.Registry` exists. Composers compile only with it.
- `Learning Analytics` prefab. `InteractableComposer` and `TeleportationComposer` are part of the default prefabs.

### Changed
- A composer is disabled when its tracking behaviour is disabled.
- Compatible with Unity 2020 again.
- Updated the default prefabs and component descriptions.

### Removed
- `PipelineComposer` and the pipeline tracking behaviour.

### Fixed
- `LrsCredentialsLoader` no longer starts if it is disabled.
- Compile errors around the scripting define symbols.

---

## [2.0.12] - 2024-12-02

### Added
- `LICENSE` file (AGPL-3.0).

### Removed
- Dependency on `com.unity.nuget.newtonsoft-json`.

---

## [2.0.11] - 2024-11-25

### Added
- `[Global Settings]` component added to the OmiLAXR prefab.
- Support for path-based tracking names via `obj.GetTrackingName()` when enabled in `[Global Settings]`.

### Changed
- `LocalEndpoint` now allows selection of storage location: `persistentDataPath`, `temporaryCachePath`, or a custom path.

### Fixed
- Fixed incorrect path for `example.credentials.json`.

---

## [2.0.10] - 2024-11-11

### Fixed
- Fixed compatibility errors for Unity 2021.

### Changed
- Updated version.

---

## [2.0.9] - 2024-11-11

### Added
- Heart rate is now included as a result extension for each actor pipeline using a `HeartRateProvider`.

### Deprecated
- None.

### Notes
- Need for action: Ensure you're using the latest xAPI Registry JSON files. See:  
  https://gitlab.com/learntech-rwth/xapi/-/merge_requests/43/diffs

---

## [2.0.8] - 2024-10-25

### Added
- Instructor and registration in the statement context.
- FPS in the statement context (`ScenarioContextHook`).
- `PipelineComposer`.
- Scroll and focus statements for UI elements, and `uiElementOptions` in dropdown statements.
- Descriptions for the xAPI components in the inspector.

### Removed
- `xApiStatementBuilder`.
- `Instructor`, which moved to the OmiLAXR core.

---

## [2.0.7] - 2024-10-14

### Added
- Scene name is now included in the `Context` field of xAPI statements.
- Tracking added for UI elements: `Toggle`, `Scrollbar`, `TextField`, `TextFieldTMP`.
- `"System paused Game"` and `"System resumed Game"` xAPI statements.

---

## [2.0.6] - 2024-10-09

### Added
- Context information (platform, language, team) in statements.

### Removed
- Scroll statements, because their definitions are not in the main branch of the xAPI registry yet.

---

## [2.0.5] - 2024-10-09

### Changed
- Changed the execution order of the `LearningRecordStore` endpoint.

---

## [2.0.4] - 2024-10-08

### Changed
- Updated the core dependency to 2.0.4.

---

## [2.0.3] - 2024-10-08

### Changed
- Updated the core dependency to 2.0.3.

---

## [2.0.2] - 2024-10-05

### Changed
- `LearningRecordStore` builds on the new core `BasicAuthEndpoint`.

---

## [2.0.1] - 2024-10-02

### Added
- `xApiComposer` base class with `GameObjectStateComposer`, `KeyboardComposer`, `MouseComposer`, `SystemComposer` and `UiComposer`.
- `xApiSemanticComposer` higher composer.
- `xApiHook` base class.
- Min and max values in dropdown statements.

### Removed
- `GameStatementComposer`, `MouseStatementComposer`, `SystemStatementComposer`, `UiStatementComposer`, `xApiStatementComposer` and `xApiStatementHook`, replaced by the classes above.
- `LrsConfigFileLoader`, `LocalFallback` and `TransferCode`, which moved to the OmiLAXR core.

### Fixed
- Missing activity extensions.
- Example scripts and prefabs.

---

## [2.0.0] - 2024-08-15

First release of OmiLAXR.xAPI.

### Added
- `xApiDataProvider` with the `OmiLAXR.xAPI Data Provider` prefab.
- `xApiStatement` and `xApiStatementBuilder`.
- `GameStatementComposer`, `MouseStatementComposer`, `SystemStatementComposer` and `UiStatementComposer`.
- `LearningRecordStore` endpoint with `LrsConfigFileLoader` and `LocalFallback`.
- `xApiStatementHook`.
- `Team` and `Instructor` actors.
