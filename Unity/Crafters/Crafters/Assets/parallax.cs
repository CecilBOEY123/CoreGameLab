using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{

    private float length, starpos;
    public GameObject cam;
    public float prl;


    // Start is called before the first frame update
    void Start()
    {
        starpos = transform.position.y;
        length = GetComponent<SpriteRenderer>().bounds.size.y;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        float temp = (cam.transform.position.y * (1 - prl));
        float dist = (cam.transform.position.y * prl);

        transform.position = new Vector3(transform.position.x, starpos + dist, transform.position.z);

        if (temp > starpos + length) starpos += length;
        else if (temp < starpos - length) starpos -= length;


    }
}
