﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D4Trigg : MonoBehaviour
{

  

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D other)
    {



        if (other.CompareTag("Player"))
        {

            SceneManager.LoadScene(2);

        }
        


       

        if (other.CompareTag("Key"))
        {

            SceneManager.LoadScene(2);


        }







    }
}
