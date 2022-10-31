using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        if (SceneManager.GetActiveScene().buildIndex == 0)
            SceneManager.LoadScene(1, LoadSceneMode.Additive);
        else
            SceneManager.LoadScene(0);

    }

    // Update is called once per frame
    void Update()
    {


    }
}
