using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{

    public GameObject trk;
   

    private float posx;
    private float posy;

 

    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()
    {

       

        



        // camera tracking
        posx = transform.position.x;
        posy = transform.position.y;

        trk.transform.position = new Vector3(0, posy, -1);

        if (trk.transform.position.y <= -0.4f)
        {
            trk.transform.position = new Vector3(trk.transform.position.x, -0.4f, -1);

        }
        if (trk.transform.position.x <= 0)
        {
            trk.transform.position = new Vector3(0, trk.transform.position.y, -1);

        }
        if (trk.transform.position.x >= 0)
        {
            trk.transform.position = new Vector3(0, trk.transform.position.y, -1);

        }


        // player transformation

        if (transform.position.x <= -6.5f)
        {
            transform.position = new Vector3(-6.5f, posy, 0);

        }
        if (transform.position.x >= 6.5f)
        {
           transform.position = new Vector3(6.5f, posy, 0);

        }
        if (transform.position.y <= -4.5f)
        {
            transform.position = new Vector3(posx, -4.5f, 0);

        }


        if (Input.GetKeyDown(KeyCode.W))
        {

            transform.position += Vector3.up;

        }
        if (Input.GetKeyDown(KeyCode.A))
        {

            transform.position += Vector3.left;

        }
        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.position += Vector3.right;

        }
        if (Input.GetKeyDown(KeyCode.S))
        {

            transform.position += Vector3.down;

        }

    }
}
