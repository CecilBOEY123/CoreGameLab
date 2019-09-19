using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabmg : MonoBehaviour
{

    public GameObject p;

    // Start is called before the first frame update
    void Start()
    {

        //p = Instantiate(p, new Vector3(0, -2, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(2, -2, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(-2, -2, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(4, -2, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(-4, -2, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(-6, -2, 0), Quaternion.identity);

        p = Instantiate(p, new Vector3(6, -2, 0), Quaternion.identity);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
