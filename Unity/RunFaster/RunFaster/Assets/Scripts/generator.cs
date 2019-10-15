using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generator : MonoBehaviour
{
    public float timer;

    bool genactivate;



    // Start is called before the first frame update
    void Start()
    {
        genactivate = false;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(genactivate)
        {

            timer -= Time.deltaTime;

            if(timer < 0)
            {

                gencounter.counter += 1;
                Destroy(this.gameObject);

            }
                
        }
        else
        {
            timer = 2;
        }

    }


    private void OnTriggerStay2D(Collider2D collision)
    { 

            if (collision.gameObject.tag == "runner")
            {
            Debug.Log("trigger");
                if (Input.GetKey(KeyCode.Space))
                {
                    genactivate = true;
                Debug.Log("pressed");
                }
                else
                {
                    genactivate = false;
                }

            }
    }
}
