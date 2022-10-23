using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OSCtoText : MonoBehaviour
{
    public Text txt;
    public float textFloat;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txt.GetComponent<UnityEngine.UI.Text>().text = textFloat.ToString();
    }
}
