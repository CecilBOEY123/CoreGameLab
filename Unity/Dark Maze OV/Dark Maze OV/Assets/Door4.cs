using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door4 : MonoBehaviour
{
    bool open;
    public GameObject dr;



    // Start is called before the first frame update
    void Start()
    {

        open = false;
        // dr.transform.position = new Vector3(0.01f, 5.69f, -2);

    }

    // Update is called once per frame
    void Update()   
    {
        if (open == false)
        {
            dr.transform.position = new Vector3(-19.16f, 32.257f, -2);

        }
        else
        {


            dr.transform.position = new Vector3(-12.5f, transform.position.y, transform.position.z);

        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        open = true;

        // dr.transform.position = new Vector3(4, transform.position.y, transform.position.z);

    }
}