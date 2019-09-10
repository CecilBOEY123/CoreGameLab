using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{


    Rigidbody2D rb;
    public float forceamount;

    public GameObject[] planets = new GameObject[4];
    

    Vector3 planet_pos;
    Vector3 direction;
    float distance;








    // Start is called before the first frame update
    void Start()
    {


        rb = GetComponent<Rigidbody2D>();
        //planet_pos = planet.transform.position;

        rb.AddForce(Vector2.left * 5, ForceMode2D.Impulse);

        distance = Vector3.Distance(planets[0].transform.position, transform.position);
        planet_pos = planets[0].transform.position;



    }

    // Update is called once per frame
    void Update()
    {

        direction = planet_pos - transform.position;
        rb.AddForce(direction * forceamount);


        
        foreach (GameObject planet in planets) {
            float distcheck = Vector3.Distance(planet.transform.position, transform.position);
            if (distcheck < distance) {
                planet_pos = planet.transform.position;
                distance = distcheck;


            }


        }


    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("trigger");

        rb.AddForce(Vector2.up*forceamount);
       


    }



  
}




