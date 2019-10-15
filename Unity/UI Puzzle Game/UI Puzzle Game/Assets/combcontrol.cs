using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class combcontrol : MonoBehaviour
{

    public static string corretcode = "094523";
    public static string Code = "";
    public static int count = 0;

    public float timer;

    public Text text;

   public AudioClip wrong;
    public AudioSource wrongp;
    public AudioClip correct;
    public AudioSource correctp;


    bool ag;
    bool ad;


    //public GameObject combbuttons;


    // Start is called before the first frame update
    void Start()
    {

        GetComponent<Text>();
        timer = 0;

        ag = false;
        ad = false;

        wrongp.clip = wrong;
        correctp.clip = correct;


    }

    // Update is called once per frame
    void Update()
    {

        if (ag)
        {

            Code = "ACCESS GRANTED";
           text.color = new Color(0, 255, 0);
            timer += Time.deltaTime;

            if(timer <= 0.1)
            {
                correctp.Play();


            }

            if(timer >= 2)
            {
                SceneManager.LoadScene(1);

            }

        }

        if(ad)
        {

            Code = "ACCESS DENIED";
           text.color = new Color(255, 0, 0);

            timer += Time.deltaTime;


            if(timer <=0.1)
            {

                wrongp.Play();

            }
       

                if (timer >= 2)
                {
                timer = 0;
                    Code = "";
                    ad = false;

                }
            

        }

        if (count == 6)
        {
            if (Code == corretcode)
            {

                
                Debug.Log("correct");
                count = 0;
                ag = true;
                ad = false;

            }
            else
            {


                ;
                Code = "";
                count = 0;
                Debug.Log("Restart");
                ad = true;


            }

        }
    }
    
        
    

    public void combpressed()
    {

        if (ad == false)
        {
            text.color = new Color(255,255,255);
            Code += gameObject.name;
            count += 1;

            Debug.Log(Code);
        }



    }
}
