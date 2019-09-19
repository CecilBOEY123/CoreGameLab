using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabM : MonoBehaviour
{

    public GameObject platformp;
    Vector3 mousePos;
    float timer;
    public float interval;



    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(platformp, new Vector2(0, 0), Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;


        if (timer >= interval)
        {
            //Vector3 pos = new Vector3(Random.Range(-8f, 8), 10f, 0);
            //Instantiate(platformp, pos, Quaternion.identity);
            //timer = 0;

            GameObject p;
            p = Instantiate(platformp, new Vector3(0, 0, 0), Quaternion.identity);
            float width = Random.Range(3, 8);
            p.transform.localScale = new Vector2(width, p.transform.localScale.y);
            p.GetComponent<plfm>().speed = Random.Range(1, 5);

        }

        //if(Input.GetButtonDown("Fire1")
       // {

       
        
        // mousePos.z = 10f;

            //var worldPos = Camera.main.ScreenToWorldPoint(mousePos);

          //  Instantiate(platformp, worldPos, Quaternion.identity);

        //}

    }
}
