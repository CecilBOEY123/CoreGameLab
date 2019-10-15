using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1mov : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed;

    //stun variables
    public int stuncount1;
    public int stuncountapprv1;
    public float timer;
    public GameObject player2;

    bool stunbl;
    bool tim;
    public static bool player1move;

    //speed variables
    public int speedcount1;
    public int speedcountapprv1;
    public float timersec;

    bool speedbl;
    bool timsec;


    private void movement()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;

    }
    
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        speed = 2;
        player1move = true;

        tim = false;
        timer = 3;

        timsec = false;
        timersec = 3;







    }

    // Update is called once per frame
    void Update()
    {
        //stun buff
        stuncountapprv1 = LevelManager.Will.stun1 + 1;

        if (LevelManager.Will.stun1 < 1)
        {
            stunbl = false;
        }
        else
        {
            stunbl = true;
            stuncount1 = LevelManager.Will.stun1;
      
        }

        //speed buff
        speedcountapprv1 = LevelManager.Will.speed1 + 1;

        if (LevelManager.Will.speed1 < 1)
        {
            speedbl = false;
        }
        else
        {
            speedbl = true;
            speedcount1 = LevelManager.Will.speed1;

        }



        //stun activation boolean
        if (stunbl)
        {
            if (stuncount1 < stuncountapprv1)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Player2mov.player2move = false;
                    tim = true;
                    stuncount1 += 1;
                    LevelManager.Will.stun1 -= 1;

                }

                                                        
            }
            if (stuncount1 == stuncountapprv1)
            {
                stuncount1 = 0;
                stunbl = false;
            }


        }
        //timer upon stun activation boolean
        if (tim)
        {
            timer -= Time.deltaTime;
            

            if (timer < 0)
            {
                Player2mov.player2move = true;
                tim = false;
                timer = 3;
            }

        }

        //speed buff
        
        if (speedbl)
        {
            if (speedcount1 < speedcountapprv1)
            {
                if (Input.GetKeyDown(KeyCode.Q))
                {
                    speed = 4;
                    timsec = true;
                    speedcount1 += 1;
                    LevelManager.Will.speed1 -= 1;

                }


            }
            if (speedcount1 == speedcountapprv1)
            {
                speedcount1 = 0;
                speedbl = false;
            }


        }
        //timer upon speed activation boolean
        if (timsec)
        {
            timersec -= Time.deltaTime;


            if (timersec < 0)
            {
                speed = 2;
                timsec = false;
                timersec = 3;
            }

        }



        /*if (Input.GetKey(KeyCode.A))
            rb.AddForce(Vector3.left);
        if (Input.GetKey(KeyCode.D))
            rb.AddForce(Vector3.right);
        if (Input.GetKey(KeyCode.W))
            rb.AddForce(Vector3.up);
        if (Input.GetKey(KeyCode.S))
            rb.AddForce(Vector3.down);
*/
        if (player1move)
        {
            movement();
            GetComponent<SpriteRenderer>().color = new Color(255,255,255);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 239, 255);

        }




    }

    
}
