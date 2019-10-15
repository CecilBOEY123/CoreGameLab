using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class coinmaker : MonoBehaviour
{

    public GameObject coin_prefab;
    int coincount;
    public Slider coinslider;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
public void CreateCoin()
    {
        Instantiate(coin_prefab, new Vector2(Random.Range(-66f, 66f), 45), Quaternion.identity);
        coincount++;

      

        if(coincount > 30)
        {
            DestroyCoin();
        }

        coinslider.value = coincount;
        
    }

 public void DestroyCoin()
    {


        GameObject[] allcoins;
        allcoins = GameObject.FindGameObjectsWithTag("coin");

     

        if (allcoins.Length >= 1)
        {
            int randomcoin = Random.Range(0, allcoins.Length - 1);
            Destroy(allcoins[randomcoin]);
            coincount--;
        }
        coinslider.value = coincount;



    }

    public void SliderUpdate()
    {

        if(coinslider.value > coincount)
        {

            CreateCoin();

        }

        if (coinslider.value < coincount)
        {

            DestroyCoin();

        }
        Debug.Log(coinslider.value);


    }

}
