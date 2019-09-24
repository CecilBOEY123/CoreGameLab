using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dust : MonoBehaviour
{

    public GameObject de;

    bool dt;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(dt)
        {
            Instantiate(de, transform.position, Quaternion.identity);

        }
        
    }

    void OnCollisionEnter2D(Collision2D cold)
    {

        dt = true;


    }
}
