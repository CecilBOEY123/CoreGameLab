using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tplcherspwn : MonoBehaviour
{
    public GameObject ball;
    //int ballcounter = GameObject.FindGameObjectsWithTag("ball").Length;
    //int maxball = 20;







    // Start is called before the first frame update
    void Start()
    {
        
      

    }

    // Update is called once per frame
    void Update()
    {
        

      



    }
        
    private void OnTriggerStay2D(Collider2D collision)
    {

        if (GameObject.FindGameObjectsWithTag("ball").Length < 2 )
        {

            Instantiate(ball, transform.position = new Vector3(0, 25,-2), Quaternion.identity);
            Debug.Log("1");


        }

      



    }
}
