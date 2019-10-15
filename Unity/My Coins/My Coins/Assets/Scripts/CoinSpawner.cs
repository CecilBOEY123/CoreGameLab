using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{

    
    public GameObject coins;

    // Start is called before the first frame update
    void Start()
    {


       
        for (int i = -12; i < 13; i++)
        {
            for (int j = 0; j < 9; j++)

            {
                Instantiate(coins, new Vector3(i, j,0), Quaternion.identity);
                
            }


        }


    }

    // Update is called once per frame
    void Update()
    {

 

       

    }
  

}
