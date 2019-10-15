using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genspawner : MonoBehaviour
{

    public GameObject generator;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(generator, new Vector3(4.5f, 8.5f, 0), Quaternion.identity);

        Instantiate(generator, new Vector3(-4.5f, -8.5f, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
