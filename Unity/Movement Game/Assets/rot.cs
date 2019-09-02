using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rot : MonoBehaviour
{

    public float degrees;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        transform.Rotate(0, 0, degrees);


        //transform.rotation = Quaternion.Euler(Vector3.forward);

    }
}
