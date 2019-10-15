using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{

    public GameObject exit;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        

        if(timer.tmr <= 0.00000 && timer.tmr >= -1.99999)
        {

            Instantiate(exit, new Vector3(12, 9, 0), Quaternion.identity);

        }
        
    }
}
