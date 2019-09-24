using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class dst : MonoBehaviour
{
    private float dis;
    public GameObject border;

    private float bdis;
    private float tdis;

    public float tm;
    public float tmr;
    private float rctmr;
    public static float disct;



  
    bool coll;





    
    // Start is called before the first frame update
    void Start()
    {

        coll = false;
        tm = 10;
        



    }

    // Update is called once per frame
    void Update()
    {

        tdis = transform.position.y;
        bdis = border.transform.position.y;

        rctmr = tmr;


        if(coll)
        {

            dis = tdis - bdis;
            tmr = tm -= Time.deltaTime;
            trgtext.countvalue = tmr;

            disct = dis;


            

        }


        if (rctmr < 0)
        {

            SceneManager.LoadScene(1);

        }
       
      

    }

    void OnCollisionEnter2D(Collision2D col)
    {

        coll = true;

    }
}
