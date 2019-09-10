using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform player;



    // Start is called before the first frame update
    void Start()
    {
       
        

}

// Update is called once per frame
void FixedUpdate()
    {


    transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);

        if (transform.position.y >= 16)
        {

            transform.position = new Vector3(player.position.x, 16, transform.position.z);


        }



    }
}
