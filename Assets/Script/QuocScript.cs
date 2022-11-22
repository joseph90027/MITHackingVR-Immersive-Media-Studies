using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuocScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float movementSpeed = 10;
    public GameObject quocsphere;

    private void Awake()
    {
        
    }

    void Start()
    {
        if (quocsphere == null)
            quocsphere = GameObject.FindGameObjectWithTag("quoc");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {

            quocsphere.transform.position += new Vector3(10f * movementSpeed * Time.deltaTime, 10f * movementSpeed * Time.deltaTime, 0);
            Debug.Log("Space key was pressed.");
        }

    }

    public void moveSphere()
    {
        quocsphere.transform.position += new Vector3(10f * movementSpeed * Time.deltaTime, 10f * movementSpeed * Time.deltaTime, 0);

    }

}
