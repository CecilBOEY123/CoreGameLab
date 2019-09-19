using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class b : MonoBehaviour
{

    public GameObject plat;
    public GameObject bll;

    int obc;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        obc =  GameObject.FindGameObjectsWithTag("Player").Length;


        if (obc >= 2)
        {
            scoret.scorevalue = 0;

        }


        if (transform.position.y < -6)
        {

            transform.position = new Vector3(0, 8, 0);


        }
        if (transform.position.x > 7)
        {

            transform.position = new Vector3(0, 8, 0);


        }
        if (transform.position.x < -7)
        {

            transform.position = new Vector3(0, 8, 0);


        }






    }

    void OnCollisionEnter2D(Collision2D col)
    {


        GetComponent<SpriteRenderer>().color = plat.GetComponent<SpriteRenderer>().color;
        scoret.scorevalue += 1;



        Debug.Log("Trigger");

    }

        



    
}
