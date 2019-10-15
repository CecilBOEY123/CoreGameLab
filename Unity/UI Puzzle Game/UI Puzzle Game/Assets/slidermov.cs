using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class slidermov : MonoBehaviour
{

    public Slider scroll;
    public GameObject screen;
    public float posy;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void screenscroll()
    {


        
         posy = scroll.value;
        transform.position = new Vector3(transform.position.x, -posy, -10);

    }
}
    