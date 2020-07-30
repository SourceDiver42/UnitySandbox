using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class Jupiter : EditorWindow
{
    bool disableFog = false;
    float time = 0.0f;

    [MenuItem("Debug/Jupiter")]
    public static void ShowWindow(){
        GetWindow(typeof(Jupiter));
    }

    private void OnGUI()
    {
        disableFog = EditorGUILayout.Toggle("Disable Fog", disableFog);
        time = EditorGUILayout.Slider(time, 00.00f, 23.59f);
    }
}
