using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Laura;

    public Text scoreText1;
    public Text scoreText2;
    public Text stunText1;
    public Text stunText2;
    public Text speedText1;
    public Text speedText2;

    private void Awake()
    {
        if (Laura == null)
        {
            Laura = this;
            DontDestroyOnLoad(this);
        }
        else if (Laura != this)
        {
            Destroy(gameObject);
        }
    }

  
    public void ShowNewStun1(int stun1)
    {
        stunText1.text = "Stuns:" + stun1;


    }
    public void ShowNewStun2(int stun2)
    {
        //stunText2.text = "Stuns:" + stun2;


    }

    public void ShowNewSpeed1(int speed1)
    {
        speedText1.text = "SpeedBuff:" + speed1;


    }

    public void ShowNewSpeed2(int speed2)
    {
        //speedText2.text = "SpeedBuff:" + speed2;


    }


}