using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bm : MonoBehaviour
{

    public GameObject bl;

    int ctr;

    // Start is called before the first frame update
    void Start()
    {

        //Instantiate(bl, new Vector3(Random.Range(-4,4), 5), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {


        ctr = GameObject.FindGameObjectsWithTag("Player").Length;

        if(ctr >= 2)
        {
            Destroy(bl);

        }



        if (bl.transform.position.y > 7.9f)
        {

           Instantiate(bl, new Vector3(Random.Range(-4, 4), 5), Quaternion.identity);

        }

        

    }
}
