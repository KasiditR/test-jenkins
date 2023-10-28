using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildScripts
{
    [MenuItem("Custom Build/Build Windows Standalone")]
    public static void BuildWindowsStandalone()
    {
        // Read the JSON configuration
        string jsonConfigPath = "Assets/buildConfig.json"; // Adjust the path as needed
        string jsonContents = File.ReadAllText(jsonConfigPath);
        ConfigData config = JsonUtility.FromJson<ConfigData>(jsonContents);

        // Set the product name, company name, and version from the JSON configuration
        PlayerSettings.productName = config.productName;
        PlayerSettings.companyName = config.companyName;
        PlayerSettings.bundleVersion = config.version;

        // Use the specified output path from the JSON configuration
        string outputPath = config.outputPath;

        // Ensure the output folder exists
        System.IO.Directory.CreateDirectory(System.IO.Path.GetDirectoryName(outputPath));

        // Build the Windows standalone application using the scenes defined in the Build Settings window
        BuildPipeline.BuildPlayer(
            GetScenePathsInBuildSettings(),
            outputPath,
            BuildTarget.StandaloneWindows,
            BuildOptions.None
        );
    }

    private static string[] GetScenePathsInBuildSettings()
    {
        List<EditorBuildSettingsScene> scenes = new List<EditorBuildSettingsScene>(EditorBuildSettings.scenes);
        List<string> scenePaths = new List<string>();

        foreach (var scene in scenes)
        {
            if (scene.enabled)
            {
                scenePaths.Add(scene.path);
            }
        }

        return scenePaths.ToArray();
    }

    [System.Serializable]
    public class ConfigData
    {
        public string productName;
        public string companyName;
        public string version;
        public string outputPath;
    }
}
