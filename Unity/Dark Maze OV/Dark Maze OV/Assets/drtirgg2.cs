﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drtirgg2 : MonoBehaviour
{
    //bool open;
    public GameObject dr;



    // Start is called before the first frame update
    void Start()
    {

        //open = true;
        dr.transform.position = new Vector3(11.59f, 0.42f, -2);

    }

    // Update is called once per frame
    void Update()
    {




    }

    private void OnTriggerStay2D(Collider2D collision)
    {

        //open = !open;

        dr.transform.position = new Vector3(transform.position.x, 4, transform.position.z);

    }
}