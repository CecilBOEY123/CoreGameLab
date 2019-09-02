using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwnr : MonoBehaviour
{

    public GameObject ball;
    public float timer;
    public float posx;
    public float posy;
    public GameObject spawner;


    // Start is called before the first frame update
    void Start()
    {
        timer = 0;

        //transform.position = new Vector2(0, 9);
        


    }

    // Update is called once per frame
    void Update()
    {


        timer += Time.deltaTime;

        if (timer >= 15)
        {
            transform.position = new Vector2(Random.Range(-4, 4), 8);

            posx = transform.position.x;
            posy = transform.position.y;


            Instantiate(ball, transform.position = new Vector2(posx, posy), Quaternion.identity);

          



            timer = 0;
        }



        

    }
}
