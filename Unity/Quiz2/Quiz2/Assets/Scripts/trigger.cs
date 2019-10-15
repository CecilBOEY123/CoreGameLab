using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class trigger : MonoBehaviour
{
    public float timer;
    public Text text;
    public float dis;
    public float timekeeper;

    public GameObject sq1;
    public GameObject sq2;

    bool timeractivate;

    // Start is called before the first frame update
    void Start()
    {
        timeractivate = false;

    }

    // Update is called once per frame
    void Update()
    {

        dis = Vector2.Distance(sq1.transform.position, sq2.transform.position);
        

        if (dis < 2)
        {

            timeractivate = true;

            

        }

        if(dis < 2 && timeractivate)
        {

            timekeeper -= Time.deltaTime;
            text.text = "TIME LEFT:" + Mathf.Round(timekeeper);

            if (timekeeper < 0)
            {

                SceneManager.LoadScene(2);


            }

        }
        else
        {
           
        }

        if(timeractivate == false)
        {
            timer = 4;
            timekeeper = timer;
            text.text = "RUN!!!";
          
        }

    }

        
}
