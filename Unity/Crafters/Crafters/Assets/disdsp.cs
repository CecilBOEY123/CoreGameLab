using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class disdsp : MonoBehaviour
{

    public Text displaydis;


    // Start is called before the first frame update
    void Start()
    {

        displaydis = GetComponent<Text>();

    }





    // Update is called once per frame
    void Update()
    {

        displaydis.text = "YOUR HEIGHT:" + dst.disct; 



    }
}
