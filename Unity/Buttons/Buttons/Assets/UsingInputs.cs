using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    float horz;
    float vert;

    // Start is called before the first frame update
    void Start()
    {

     

    }

    // Update is called once per frame
    void Update()
    {


        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");

        Debug.Log(horz + " " + vert);


    }
}
