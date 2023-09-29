using UnityEditor;

public class BuildScripts
{
    public static void BuildWindow()
    {
        string[] scenes = new string[]{"Assets/Scenes/SampleScene.unity"};
        BuildPipeline.BuildPlayer(scenes,"../WindowBuild/test.exe",BuildTarget.StandaloneWindows,BuildOptions.None);
    }
}
