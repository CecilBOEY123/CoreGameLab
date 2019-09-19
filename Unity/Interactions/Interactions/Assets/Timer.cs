using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    float timer;
    bool buttondirec;
    public Text text;




    // Start is called before the first frame update
    void Start()
    {

        timer = 0;
        buttondirec = false;


    }

    // Update is called once per frame
    void Update()
    {


        if (buttondirec)
        {


            if (Input.GetKeyDown(KeyCode.H))
            {
                text.text = timer.ToString();

                timer = 0;
                buttondirec = false;

            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.G))
            {
                text.text = timer.ToString();

                timer = 0;
                buttondirec = true;

            }




        }

            timer += Time.deltaTime;

        }
        
    
}
