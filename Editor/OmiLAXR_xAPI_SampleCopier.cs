#if UNITY_EDITOR

using System;
using System.IO;
using UnityEditor;
using UnityEngine;

namespace OmiLAXR.xAPI.Editor
{
    public class OmiLAXR_xAPI_SampleCopier
    {
    private const string PackageName = "com.rwth.unity.omilaxr.xapi";

    [MenuItem("OmiLAXR / Samples / Copy 'xapi' folder")]
    internal static void CopyXApiDefFolderFromSamples()
    {
        // Quelle: .../Samples~/xapi   -> Ziel: Assets/xapi
        CopyFromSamplesFolder("xapi", "Assets/xapi", expectFolder: true);
    }

    [MenuItem("OmiLAXR / Samples / Copy 'xAPI.Registry'")]
    internal static void CopyXApiRegFolderFromSamples()
    {
        // Quelle: .../Samples~/xAPI.Registry  -> Ziel: Assets/xAPI.Registry
        CopyFromSamplesFolder("xAPI.Registry", "Assets/xAPI.Registry", expectFolder: true);
    }

    [MenuItem("OmiLAXR / Samples / Copy 'xapi.config.json'", priority = 0)]
    internal static void CopyXApiTypesFromSamples()
    {
        // Quelle: .../Samples~/xapi.config/xapi.config.json  -> Ziel: Assets/xapi.config.json
        CopyFromSamplesFolder("xapi.config/xapi.config.json", "Assets/xapi.config.json", expectFolder: false);
    }
    
    [MenuItem("OmiLAXR / Samples / Copy 'xapi.config.json' (xAPI4Unity v2.2.1)", priority = 0)]
    private static void CopyXApiTypes221FromSamples()
    {
        // Quelle: .../Samples~/xapi.config.json  -> Ziel: Assets/xapi.config.json
        CopyFromSamplesFolder("xapi.config221.json", "Assets/xapi.config.json", expectFolder: false);
    }

    // ----------------------------------------------------------------------

    private static void CopyFromSamplesFolder(string samplesRelative, string destAssetPath, bool expectFolder)
    {
        try
        {
            var packageRoot = $"Packages/{PackageName}";
            // Bevorzugt "Samples~", fallback "~Samples"
            var candidates = new[]
            {
                PathCombine(packageRoot, "Samples~", samplesRelative),
                PathCombine(packageRoot, "~Samples", samplesRelative)
            };

            string sourcePath = null;
            foreach (var c in candidates)
            {
                if (Directory.Exists(c) || File.Exists(c))
                {
                    sourcePath = c;
                    break;
                }
            }

            if (string.IsNullOrEmpty(sourcePath))
            {
                EditorUtility.DisplayDialog(
                    "Not found",
                    $"Konnte den Sample-Pfad nicht finden:\n\n{string.Join("\n", candidates)}\n\n" +
                    $"Bitte prüfen Sie, ob das Package '{PackageName}' installiert ist und die Samples enthalten sind.",
                    "OK");
                return;
            }

            // Ziel: in absoluten Pfad auflösen
            var destAbsolute = ToAbsoluteProjectPath(destAssetPath);

            // Existenz + erwarteten Typ (Datei/Ordner) prüfen
            bool srcIsDir = Directory.Exists(sourcePath);
            if (expectFolder && !srcIsDir)
            {
                EditorUtility.DisplayDialog("Fehlender Ordner",
                    $"Erwartet wurde ein Ordner, gefunden wurde eine Datei:\n{sourcePath}", "OK");
                return;
            }
            if (!expectFolder && srcIsDir)
            {
                EditorUtility.DisplayDialog("Fehlende Datei",
                    $"Erwartet wurde eine Datei, gefunden wurde ein Ordner:\n{sourcePath}", "OK");
                return;
            }

            // Überschreiben bestätigen
            if (Directory.Exists(destAbsolute) || File.Exists(destAbsolute))
            {
                bool overwrite = EditorUtility.DisplayDialog(
                    "Ziel existiert bereits",
                    $"Das Ziel existiert bereits:\n{destAssetPath}\n\nMöchten Sie es überschreiben?",
                    "Überschreiben", "Abbrechen");

                if (!overwrite) return;

                // Vorher löschen (inkl. .meta)
                DeletePathWithMeta(destAbsolute);
            }
            else
            {
                // Ziel-Ordnerstruktur anlegen
                var parentDir = Path.GetDirectoryName(destAbsolute);
                if (!string.IsNullOrEmpty(parentDir) && !Directory.Exists(parentDir))
                    Directory.CreateDirectory(parentDir);
            }

            // Kopieren
            if (srcIsDir)
            {
                // Ganze Ordnerstruktur kopieren
                CopyDirectoryRecursive(sourcePath, destAbsolute);
            }
            else
            {
                File.Copy(sourcePath, destAbsolute, overwrite: true);
                // Für einzelne Dateien .meta neu erzeugen lassen
            }

            // AssetDatabase aktualisieren
            AssetDatabase.Refresh();
            Debug.Log($"[xAPI Samples] Kopiert: '{sourcePath}' → '{destAssetPath}'");
        }
        catch (Exception ex)
        {
            Debug.LogError($"[xAPI Samples] Fehler beim Kopieren: {ex.Message}\n{ex}");
        }
    }

    // ---- Utilities --------------------------------------------------------

    private static string ToAbsoluteProjectPath(string assetPath)
    {
        // assetPath: "Assets/..." → absoluter Systempfad
        assetPath = assetPath.Replace('\\', '/');
        if (!assetPath.StartsWith("Assets/") && assetPath != "Assets")
            throw new InvalidOperationException($"Erwarte Asset-Pfad, bekam: {assetPath}");

        var projectAssets = Application.dataPath.Replace('\\', '/'); // .../<Project>/Assets
        if (assetPath == "Assets") return projectAssets;

        var suffix = assetPath.Substring("Assets/".Length);
        return PathCombine(projectAssets, suffix);
    }

    private static string PathCombine(params string[] parts)
    {
        var p = Path.Combine(parts).Replace('\\', '/');
        return p;
    }

    private static void CopyDirectoryRecursive(string sourceDir, string destDir)
    {
        sourceDir = sourceDir.Replace('\\', '/');
        destDir   = destDir.Replace('\\', '/');

        Directory.CreateDirectory(destDir);

        foreach (var file in Directory.GetFiles(sourceDir))
        {
            var fileName = Path.GetFileName(file);
            var destFile = PathCombine(destDir, fileName);
            File.Copy(file, destFile, overwrite: true);
        }

        foreach (var dir in Directory.GetDirectories(sourceDir))
        {
            var name = Path.GetFileName(dir);
            var destSub = PathCombine(destDir, name);
            CopyDirectoryRecursive(dir, destSub);
        }
    }

    private static void DeletePathWithMeta(string absolutePath)
    {
        absolutePath = absolutePath.Replace('\\', '/');
        try
        {
            if (Directory.Exists(absolutePath))
            {
                Directory.Delete(absolutePath, recursive: true);
                var meta = absolutePath + ".meta";
                if (File.Exists(meta)) File.Delete(meta);
            }
            else if (File.Exists(absolutePath))
            {
                File.Delete(absolutePath);
                var meta = absolutePath + ".meta";
                if (File.Exists(meta)) File.Delete(meta);
            }
        }
        catch (Exception ex)
        {
            Debug.LogWarning($"[xAPI Samples] Konnte bestehenden Pfad nicht löschen: {absolutePath}\n{ex.Message}");
        }
    }
    }
}

#endif
