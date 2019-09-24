using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class countt : MonoBehaviour
{

    public static int countvalue;
    Text count;

    // Start is called before the first frame update
    void Start()
    {


        count = GetComponent<Text>();


    }

    // Update is called once per frame
    void Update()
    {


        count.text = "Bricks Left: 30/" + countvalue;


    }
}
