using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UsingIpt : MonoBehaviour
{

    float horz;
    float vert;
    public float speed;
    public float forceamount;
    Rigidbody2D rb;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {


        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");



        // Debug.Log(horz + " " + vert);

        //transform.Translate(horz*Time.deltaTime*speed, vert*Time.deltaTime*speed, 0);

        rb.AddForce(new Vector2(horz*forceamount, vert*forceamount));

        if (Input.GetKey(KeyCode.G))
        {
            Debug.Log("g");

            if (Input.GetKey(KeyCode.H))
            {
                Debug.Log("gh");

            }

        } 

        else if (Input.GetKey(KeyCode.H))
            {
            Debug.Log("h");

        }


    }
}
