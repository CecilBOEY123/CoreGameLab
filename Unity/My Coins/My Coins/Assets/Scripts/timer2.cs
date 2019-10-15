using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer2 : MonoBehaviour
{
    public static float tmr;
    public Text text;


    // Start is called before the first frame update
    void Start()
    {

        tmr = 60;

    }

    // Update is called once per frame
    void Update()
    {

        tmr -= Time.deltaTime;
        text.text = "Time Left:" + Mathf.Round(tmr);

        if (tmr < 0)
        {

            text.text = "GAME OVER";

        }

    }
}
