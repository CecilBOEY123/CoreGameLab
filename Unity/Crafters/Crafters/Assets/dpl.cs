using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dpl : MonoBehaviour
{
   
    private int i;

    public Sprite sst1;
    public Sprite sst2;
    public Sprite sst3;





    // Start is called before the first frame update
    void Start()
    {
        i = 0;

        this.gameObject.GetComponent<SpriteRenderer>().sprite = sst1;

    }



    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {

            if (this.gameObject.GetComponent<SpriteRenderer>().sprite == sst1)
            {
                i = i + 1;

            }

            if(i == 1)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sst2;

                i = i + 1;

            }
            if(i == 2)
            {
                this.gameObject.GetComponent<SpriteRenderer>().sprite = sst3;

                i = 0;


            }


        }
    }
    
}

    

