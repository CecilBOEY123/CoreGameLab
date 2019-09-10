using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
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
        if(open == false)
        {
            dr.transform.position = new Vector3(0.01f, 5.69f, -2);

        }
        else
        {


            dr.transform.position = new Vector3(4, transform.position.y, transform.position.z);

        }

    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        open = true;

       // dr.transform.position = new Vector3(4, transform.position.y, transform.position.z);

    }
}
