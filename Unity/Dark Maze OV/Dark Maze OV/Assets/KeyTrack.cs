using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class KeyTrack : MonoBehaviour
{

    public GameObject plyr;
    public GameObject trigg;

    float posx;
    float posy;

    




    // Start is called before the first frame update
    void Start()
    {

       



    }

    // Update is called once per frame
    void Update()
    {
       
        
       

    }


    private void OnTriggerStay2D(Collider2D col)
    {


        if (col.gameObject.name == "Spirit")
        {
            transform.position = new Vector3(plyr.transform.position.x, plyr.transform.position.y, transform.position.z);
            Debug.Log("1");

            plyr.tag = "Key";

            

        }
     
      

    }
}
