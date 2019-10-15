using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tilemanager : MonoBehaviour
{

    public bool XorO;

    public Color red;
    public Color blue;

    public Sprite x;
    public Sprite o;

    public GameObject sprite;


    public void settile(bool _Xoro)
        {


        if (_Xoro)
        {
            GetComponent<SpriteRenderer>().color = red;
            GetComponent<SpriteRenderer>().sprite = x;
        }
        else
        {
            GetComponent<SpriteRenderer>().color = blue;
            GetComponent<SpriteRenderer>().sprite = o;
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {


    }
}
