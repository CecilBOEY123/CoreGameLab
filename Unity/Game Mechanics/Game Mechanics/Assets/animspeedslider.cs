using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animspeedslider : MonoBehaviour
{
    public Slider s;
    Animator anim;

    float sval;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {

        sval = s.value;
        anim.speed = sval;
        
    }

    public void animationevent()
    {

        text.text = "Will aint Plat";

    }
}
