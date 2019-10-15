using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class track : MonoBehaviour
{

    public GameObject cam;

    public float posy;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        posy = cam.transform.position.y;

        transform.position = new Vector3(transform.position.x, posy+1, 1);



    }
}
