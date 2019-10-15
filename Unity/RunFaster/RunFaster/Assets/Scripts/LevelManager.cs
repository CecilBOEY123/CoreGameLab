using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Will;





    private void Awake()
    {

        if (Will == null)
        {
            Will = this;
            DontDestroyOnLoad(this);

        }
        else if (Will != this)
        {
            Destroy(gameObject);

        }
    }

  

    public int stun1;
    public int stun2;
    

    public int speed1;
    public int speed2;




    public void UpdateScore()
    {
        
        UIManager.Laura.ShowNewStun1(stun1);
        UIManager.Laura.ShowNewStun2(stun2);

        UIManager.Laura.ShowNewSpeed1(speed1);
        UIManager.Laura.ShowNewSpeed2(speed2);

    }

    void Start()
    {
       
        stun1 = 0;
        stun2 = 0;
        
        speed1 = 0;
        speed2 = 0;
       



    }

    // Update is called once per frame
    void Update()
    {

        UpdateScore();
        

    }
}
