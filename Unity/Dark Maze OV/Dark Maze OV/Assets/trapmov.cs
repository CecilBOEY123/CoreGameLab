using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class trapmov : MonoBehaviour
{
    bool wall;
    public float speed;
    public GameObject player;
   




    // Start is called before the first frame update
    void Start()
    {

        wall = false;


    }

    // Update is called once per frame
    void Update()
    {



        if (wall == false)
        {

            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += -transform.right * speed * Time.deltaTime;

        }

        if (transform.position.x >= 8)
        {
          
            wall = true;

        }


        if (transform.position.x <= -8)
        {
           

            wall = false;
        }

      

    }

    private void OnCollisionStay2D(Collision2D col)
    {

        if (col.gameObject == player)
        {
            player.transform.position = new Vector3(0, 0, -2);
        }

    



    }



}
