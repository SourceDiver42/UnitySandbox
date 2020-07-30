using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor.SceneManagement;
using UnityEditor;


public class AdditiveSceneLoader : EditorWindow
{
    
    public Object SceneToLoad;

    [MenuItem("Tools/AdditiveSceneLoader")]
    public static void ShowWindow(){
        GetWindow(typeof(AdditiveSceneLoader));
    }

    private void OnGUI()
    {
        GUILayout.Label("Load Scene additively");
        SceneToLoad = (SceneAsset)EditorGUILayout.ObjectField("Scene:", SceneToLoad, typeof(SceneAsset), false) ?? null;

        if (GUILayout.Button("Load")) {
            
            EditorSceneManager.OpenScene("Assets/Scenes/" + SceneToLoad.name.ToString() + ".unity", OpenSceneMode.Additive);
                        
        }

        if (GUILayout.Button("Unload")) {

            EditorSceneManager.CloseScene(EditorSceneManager.GetSceneByName(SceneToLoad.name), true);
            
        }
    }
}
