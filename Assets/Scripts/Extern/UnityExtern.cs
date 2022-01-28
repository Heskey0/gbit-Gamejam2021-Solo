using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;

public static class UnityExtern
{
    [MenuItem("CustomTool/Goto/Setup")]
    public static void GotoSetup()
    {
        EditorSceneManager.OpenScene(Application.dataPath+"/Scenes/0.Login.unity");
    }

    [MenuItem("CustonTool/Goto/Main")]
    public static void GotoMainScene()
    {
        EditorSceneManager.OpenScene(Application.dataPath+"/Scenes/2.Main.unity");
    }
}
