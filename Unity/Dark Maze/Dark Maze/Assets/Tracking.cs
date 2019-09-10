﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tracking : MonoBehaviour
{

   public GameObject track;
    public float posx;
    public float posy;
    private Rigidbody2D rb;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();



    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(x, y);

        rb.velocity = (movement * speed);


        posx = transform.position.x;
        posy = transform.position.y;

        track.transform.position = new Vector3(posx, posy, -3);


        
    }
}