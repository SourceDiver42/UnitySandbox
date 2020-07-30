using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class PlayerPrefsEditor : EditorWindow
{
    [MenuItem("Debug/PlayerPrefsEditor")]
    public static void ShowWindow(){
        GetWindow(typeof(PlayerPrefsEditor));
    }

    private void OnGUI()
    {
        
    }
}
