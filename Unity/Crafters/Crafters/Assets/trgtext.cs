using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class trgtext : MonoBehaviour
{

    public static float countvalue;
    public Text cdt;


    // Start is called before the first frame update
    void Start()
    {

        cdt = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {


        cdt.text = "Time Left:" + Mathf.Round(countvalue);

    }
}
