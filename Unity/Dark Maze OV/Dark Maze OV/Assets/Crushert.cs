using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crushert : MonoBehaviour
{

    public GameObject crusher;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = new Vector3(crusher.transform.position.x, crusher.transform.position.y, -3.5f);




    }
}
