using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ts1m : MonoBehaviour
{

    public GameObject p;

    // Start is called before the first frame update
    void Start()
    { 
        p = Instantiate(p, new Vector3(2, -1, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(-2, -1, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(4, -1, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(-4, -1, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(-6, -1, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(6, -1, 0), Quaternion.identity);

        
    }

// Update is called once per frame
void Update()
    {
        
    }
}
