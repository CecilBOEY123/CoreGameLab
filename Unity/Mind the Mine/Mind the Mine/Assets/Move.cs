﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.U))
        {
                
            if (Input.GetKeyDown(KeyCode.P))
            {

                transform.position = new Vector3(0, 0, 0);
            }
        }

    }
}
