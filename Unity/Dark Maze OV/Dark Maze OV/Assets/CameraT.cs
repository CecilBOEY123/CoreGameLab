using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraT : MonoBehaviour
{

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

        if (transform.position.y <= 0.16)
        {

            transform.position = new Vector3(transform.position.x, 0.16f, transform.position.z);

        }

        if (transform.position.y >= 28)
        {

            transform.position = new Vector3(transform.position.x, 28, transform.position.z);

        }


        if (transform.position.x <= -20)
        {

            transform.position = new Vector3(-20, transform.position.y, transform.position.z);


        }

        if (transform.position.x >= 20)
        {

            transform.position = new Vector3(20, transform.position.y, transform.position.z);


        }

    }
    
}
