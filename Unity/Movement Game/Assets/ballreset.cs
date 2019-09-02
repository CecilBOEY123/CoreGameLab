using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballreset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        //transform.position = new Vector2(0, 9);
        

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -9)
        {
            transform.position = new Vector2(Random.Range(8, -8), 9);
        }

        //if (transform.position.x >= 19)
        {
        //    transform.position = new Vector2(Random.Range(10, -10), 9);
        }

        //if (transform.position.x <= -19)
        {
       //     transform.position = new Vector2(Random.Range(10, -10), 9);
        }
    }

}
