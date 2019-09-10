using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class trapballbody : MonoBehaviour
{

    Rigidbody2D rb;
    Vector2 direction;
    public float forceamount;
    public GameObject player;
  
    





    // Start is called before the first frame update
    void Start()
    {



        




    }

    // Update is called once per frame
    void Update()
    {
        //direction = new Vector2(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f)); ;

        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up*forceamount);

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
         if(col.gameObject.name == "Spirit")
        {

            player.transform.position = new Vector3(0, 0, transform.position.z);
            Debug.Log("1");


    




        }
   

      


    }
}
