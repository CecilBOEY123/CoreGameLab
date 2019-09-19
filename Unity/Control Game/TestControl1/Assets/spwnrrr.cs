using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spwnrrr : MonoBehaviour
{

    public GameObject bombPrefab;
    public GameObject t;
  
    
    public float timer;
   
    public float poswx;
    public float poswy;




    // Start is called before the first frame update
    void Start()
    {


        timer = 0;

        


    }

    // Update is called once per frame

   

    void Update()
    {
      timer += Time.deltaTime;

        if (timer >= 6)
        {
            //transform.position = new Vector2(Random.Range(-4, 4), Random.Range(-4, 4));


            poswx = t.transform.position.x;
            poswy = t.transform.position.y;

            Instantiate(bombPrefab, transform.position = new Vector3(poswx, poswy, -1), Quaternion.identity);

            timer = 0;
        }


    }
}
