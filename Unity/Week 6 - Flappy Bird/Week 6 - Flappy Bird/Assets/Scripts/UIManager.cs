using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIManager : MonoBehaviour
{

    public static UIManager Park;

    public Text scoretext;

    private void Awake()
    {

        if(Park == null)
        {
            Park = this;

        }
        else if(Park != this)
        {
            Destroy(gameObject);
        }
    }
    public void ShowNewScore(int score)
    {
        scoretext.text = score.ToString();


    }
}
