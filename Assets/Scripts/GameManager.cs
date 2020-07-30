using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject loadingScreen;
    
    private void Awake()
    {
        SceneManager.LoadSceneAsync((int)SceneIndex.MAIN_MENU, LoadSceneMode.Additive);
    }
    
    public void LoadGame() {
        loadingScreen.SetActive(true);
        SceneManager.UnloadSceneAsync((int)SceneIndex.MAIN_MENU);
        SceneManager.LoadSceneAsync((int)SceneIndex.MAIN_SCENE, LoadSceneMode.Additive);
    }
}
