using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wp : MonoBehaviour
{

    public AudioClip wrong;
    public AudioSource wrongp;

    // Start is called before the first frame update
    void Start()
    {
        wrongp.clip = wrong;

    }

    // Update is called once per frame
    public void wrongpass()
    {

        wrongp.Play();


    }
}
