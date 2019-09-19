using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stbt : MonoBehaviour
{

    public GameObject bullets;
    public Transform shotLoc;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 10)*Time.deltaTime*10f);

         if (Input.GetKeyDown(KeyCode.Space))
        {

            Instantiate(bullets, shotLoc.position, shotLoc.rotation);


        }

    }
}
