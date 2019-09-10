﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrusherM : MonoBehaviour
{
    public float speed;
    public GameObject player;


    // Start is called before the first frame update
    void Start()
    {
        
       



    }

    // Update is called once per frame
    void Update()
    {

        transform.position += -transform.right * Time.deltaTime * speed;
    }

    private void OnCollisionEnter2D(Collision2D collide)
    {

        player.transform.position = new Vector3(0, 0, transform.position.z);
        Debug.Log("1");


    }

}
