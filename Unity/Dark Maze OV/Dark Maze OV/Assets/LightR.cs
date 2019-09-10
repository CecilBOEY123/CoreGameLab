using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightR : MonoBehaviour
{

    Light lg;

    // Start is called before the first frame update
    void Start()
    {

        lg = GetComponent<Light>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    
    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Trap")
        {



            lg.intensity = 2;







        }
    }

}