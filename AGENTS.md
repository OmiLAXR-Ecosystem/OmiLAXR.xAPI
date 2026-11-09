# AGENTS.md

How to work in `com.rwth.unity.omilaxr.xapi`. Architecture and commands are in `CLAUDE.md`. Workspace-wide context is in `../CLAUDE.md`.

## Repository and releases

- This folder is its own git repo inside the `omilaxr-ecosystem` workspace. Run git commands here.
- Work for a release goes on a branch `vX.Y.Z`, which is merged into `main` when done.
- Commit messages: `type(scope): summary`, where type is `feat`, `fix`, `refactor`, `test` or `docs`. Do not commit unrelated working-tree changes that you did not make.
- Pushing a tag `vX.Y.Z` runs `.github/workflows/publish.yml`, which does `npm publish` to npmjs. Only tag when the version files below agree.

## CHANGELOG

- Every user-visible change gets a line in `CHANGELOG.md` in the same change or commit. Do not leave it for later.
- Newest version on top. Heading format in this file: `## [X.Y.Z] - YYYY-MM-DD`. Versions are separated by a `---` line. Keep the file's existing style.
- Add entries under the topmost version if it is not released yet (no `vX.Y.Z` tag). Otherwise start a new version and do the version bump below.
- Group entries under `### Added`, `### Changed`, `### Fixed` (and `### Removed`/`### Deprecated` when needed). Write one line per change, in English, and name types and members in backticks.
- Mark breaking changes explicitly with **Breaking:** and say what users must change.
- Changes that only touch tests or CI need no entry. Refactors need one if they add public API, such as new interfaces or overloads.

## Version bump

- SemVer: patch for fixes, minor for new backward-compatible API, major for breaking changes.
- Update every place that holds the version, in one commit:
  - `package.json`
  - `CITATION.cff` (`version`, `date-released`, both blocks)
  - `CHANGELOG.md`
  - `Runtime/Hooks/ScenarioContextHook.cs`: the module version in `GetPlatformString("xAPI", "X.Y.Z", …)`
  - `Tests/Runtime/ComposerAndHook_Tests.cs`: the tests that expect that platform string
- The release date in `CITATION.cff` and the CHANGELOG heading is the day of the release. Update it when tagging.

## Core dependency

- `package.json` pins the core (`com.rwth.unity.omilaxr`). Do not raise it on routine version bumps.
- Raise it when this package starts using core API that is newer than the pin, or when the core had an important or breaking change. Also update README lines that mention the core version.

## Unity package rules

- Every new file and folder needs a committed `.meta`. Let Unity create it (open `OmiLAXR_Dev`), or copy a neighbor's `.meta` with a fresh random 32-hex `guid`. Never delete or regenerate existing `.meta` files: prefabs, scenes and asmdefs reference their GUIDs. Folders ending in `~` (`Samples~`) have no `.meta`.
- The minimum Unity version is `2020.3` (`package.json` `unity`), but development happens on Unity 6. Put version-specific APIs behind `#if UNITY_2023_1_OR_NEWER` (or similar).
- Serialized field names are part of the scene and prefab format. Rename them only with `[FormerlySerializedAs]`.
- New components get `[AddComponentMenu("OmiLAXR / …")]`. Copy the path from a component of the same kind.
- License: AGPL-3.0-or-later. Source files start with the SPDX header (copy from a neighbor).
- Add or adjust tests in `Tests/` with every behaviour change. Name test files `<Subject>_Tests.cs`, name methods `Subject_Does_Something`, and use `// Arrange / Act / Assert` comments.

## xAPI-specific rules

- `xAPI.Registry` is generated code. Never edit it by hand. To change verbs, activities or extensions, edit the JSON in the workspace `xapi/definitions/<domain>/`. Then regenerate with xAPI4Unity (`xAPI4Unity / Update xAPI.Registry (JSON => C#)`).
- When composers start using new registry entries, refresh `Samples~/xapi`, `Samples~/xapi.config` and `Samples~/xAPI.Registry` together, so the shipped samples compile with the composers.
- Composer code that touches `xAPI.Registry` stays inside `#if XAPI_REGISTRY_EXISTS`.
- `Plugins/TinCan.dll` is a binary build of the workspace `TinCan.NET/` fork. Change the fork and rebuild it; never patch the DLL.
- If you change the CSV or JSONL output, update the format docs in `Docs/`.
