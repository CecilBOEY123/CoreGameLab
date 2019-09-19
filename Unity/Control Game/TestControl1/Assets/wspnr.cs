using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wspnr : MonoBehaviour
{
    public GameObject wsss;
    public GameObject track;


    public float timer;

    public float posx;
    public float posy;

   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= 5)
        {
            transform.position = new Vector2(Random.Range(-4.5f, 4.5f), Random.Range(-4.5f, 4.5f));


            posx = transform.position.x;
            posy = transform.position.y;

            Instantiate(wsss, transform.position = new Vector3(posx, posy, 0), Quaternion.identity);

            track.transform.position = new Vector3(posx, posy, 0);

            timer = 0;
        }

    }
}
