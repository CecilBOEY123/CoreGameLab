﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorekeeper : MonoBehaviour
{

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    public void InceaseScore()
    {
        score++;


    }
    public void DecreaseScore()
    {
        score--;



    }
}