using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    public float forceAmount;

    bool jump;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        speed = 5;
        forceAmount = 40;

        jump = false;

    }

    // Update is called once per frame
    void Update()
    {

      

        if(jump == true)
        {

            if (Input.GetKeyDown(KeyCode.Space))
            {
                rb.AddForce(transform.up * forceAmount, ForceMode2D.Impulse);
                jump = false;
            }

        }
        else
        { }

        Vector3 pos = transform.position;

       
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if(collision.gameObject.tag == "floor")
        {

            jump = true;
            Debug.Log("trigger");

        }


    }
}
