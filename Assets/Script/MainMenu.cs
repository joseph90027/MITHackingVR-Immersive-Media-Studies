using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //public GameObject menu;
    public GameObject loadingInterface;

    List<AsyncOperation> scenesToLoad = new List<AsyncOperation>();

    private void Start()
    {
        StartGame();
    }
    public void StartGame()
    {
        ShowLoadingScreen();
        scenesToLoad.Add(SceneManager.LoadSceneAsync("FMDemo_AR"));
        scenesToLoad.Add(SceneManager.LoadSceneAsync("FMDemo_PC", LoadSceneMode.Additive));
        StartCoroutine(LoadingScreen());

    }

    public void ShowLoadingScreen()
    {
        loadingInterface.SetActive(true);
    }

    IEnumerator LoadingScreen()
    {
        float totalProgress = 0;
        for(int i = 0; i < scenesToLoad.Count; ++i)
        {
            while (!scenesToLoad[i].isDone)
            {
                totalProgress += scenesToLoad[i].progress;
                yield return null;
            }
        }

    }
}
