using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speedbuff : MonoBehaviour
{
    public GameObject speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay2D(Collider2D col)
    {

        if (col.gameObject.tag == "player1")
        {

            Destroy(speed);
            LevelManager.Will.speed1 += 1;



        }
        if (col.gameObject.tag == "player2")
        {

            Destroy(speed);
            LevelManager.Will.speed2 += 1;



        }

    }
}
