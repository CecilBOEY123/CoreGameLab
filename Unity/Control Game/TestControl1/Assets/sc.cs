using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sc : MonoBehaviour
{

    //public Sprite bomb;
    //public Sprite explo;
    public GameObject player;
    //public GameObject bx;
 

    //public float timer;


  


    // Start is called before the first frame update
    void Start ()

    {


       // this.gameObject.GetComponent<SpriteRenderer>().sprite = bomb;
        //timer = 0;
    }

    // Update is called once per frame
    void Update()
    {

       // timer += Time.deltaTime;

      

       // if (timer >= 0)
       // {

           // if (this.gameObject.GetComponent<SpriteRenderer>().sprite == bomb)
          //  {

                //this.gameObject.GetComponent<SpriteRenderer>().sprite = explo;
              //  this.gameObject.tag = "explosion";

               // timer = 0;
           // }

           // if (timer >= 6)
            //{
              //  bx.transform.position = new Vector3(10, 0, 0);
               

                //timer = 0;
   
            //}



           



       // }
       

    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log("trigger");

       // if(bx.tag == "explosion")
        //{


            Destroy(player);

       // }
        

    }
    
        




    

}
