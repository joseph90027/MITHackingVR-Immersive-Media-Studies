using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableOrEnableObject : MonoBehaviour
{
    public GameObject background;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if(background.activeInHierarchy == true)
        {
            background.SetActive(false);
        }
        else
        {
            background.SetActive(true);
        }
    }
}
