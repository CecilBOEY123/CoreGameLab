using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{

    float timer;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        transform.Translate(Vector2.up * Time.deltaTime * 30f);

        if(timer >= 0.5f)
        {

            Destroy(this.gameObject);

        }
        

    }
}
