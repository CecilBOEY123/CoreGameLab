using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    public static float tmr;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {

        tmr = 30;

    }

    // Update is called once per frame
    void Update()
    {

        tmr -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(tmr);

       if(tmr < 0)
        {

            text.text = "ESCAPE!!!";

        }
        
    }
}
