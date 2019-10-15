using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slider1 : MonoBehaviour
{

    public Slider choosespeed;
    public Text text;
    public int speedset = 0;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        

        


    }

  

    public void slidervalue()
    {


        Levelmanager.Will.speed = choosespeed.value;
        text.text = "speed:" + Mathf.Round(choosespeed.value);



    }

     
}
