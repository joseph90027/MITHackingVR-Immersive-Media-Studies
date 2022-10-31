using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SyncScene : MonoBehaviour
{
    private void Awake()
    {
        // load some additional scenes
        SceneManager.LoadScene("FMDemo_AR", LoadSceneMode.Additive);
        SceneManager.LoadScene("FMDemo_PC", LoadSceneMode.Additive);

        /*
        // list scenes and try to print their name (if they are valid)
        for (int i = 0; i < SceneManager.sceneCountInBuildSettings; i++)
        {
            Scene scene = SceneManager.GetSceneByBuildIndex(i);
            if (scene.IsValid()) // a scene is only valid if it's loaded!
                Debug.Log($"Scene #{i}: {scene.name}");
            else
                Debug.Log($"Scene #{i} not loaded yet!");
        }

        // get a scene by name
        Debug.Log($"Scene \"Core\" has path \"{SceneManager.GetSceneByName("Core").path}\"");
        */
    }
}
