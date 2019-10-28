using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{

    public static bool run;

    // Start is called before the first frame update
    void Start()
    {

        run = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "sword")
        {

            run = true;
            Debug.Log(run);

            Destroy(this.gameObject);

        }

    }
}
