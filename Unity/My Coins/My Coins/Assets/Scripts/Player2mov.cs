using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2mov : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed;

    //stun varaibles
    public int stuncount2;
    public int stuncountapprv2;
    public float timer;
    public GameObject player1;

    bool stunbl;
    bool tim;
    public static bool player2move;

    //speed variables
    public int speedcount2;
    public int speedcountapprv2;
    public float timersec;

    bool speedbl;
    bool timsec;


    private void movement()
    {
        Vector3 pos = transform.position;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            pos.x -= speed * Time.deltaTime;
        }


        transform.position = pos;
    }
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        speed = 2;
        player2move = true;

        tim = false;
        timer = 3;

        timsec = false;
        timersec = 3;

    }

    // Update is called once per frame
    void Update()
    {
        //stun budff
        stuncountapprv2 = LevelManager.Will.stun2 + 1;

        if (LevelManager.Will.stun2 < 1)
        {
            stunbl = false;
        }
        else
        {
            stunbl = true;
            stuncount2 = LevelManager.Will.stun2;

        }

        //speed buff
        speedcountapprv2 = LevelManager.Will.speed2 + 1;

        if (LevelManager.Will.speed2 < 1)
        {
            speedbl = false;
        }
        else
        {
            speedbl = true;
            speedcount2 = LevelManager.Will.speed2;

        }

        //stun activation boolean
        if (stunbl)
        {
            if (stuncount2 < stuncountapprv2)
            {
                if (Input.GetKeyDown(KeyCode.P))
                {
                    Player1mov.player1move = false;
                    tim = true;
                    stuncount2 += 1;
                    LevelManager.Will.stun2 -= 1;

                }


            }
            if (stuncount2 == stuncountapprv2)
            {
                stuncount2 = 0;
                stunbl = false;
            }


        }
        //timer upon stun activation boolean
        if (tim)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                Player1mov.player1move = true;
                tim = false;
                timer = 3;
            }

        }


        //speed buff

        if (speedbl)
        {
            if (speedcount2 < speedcountapprv2)
            {
                if (Input.GetKeyDown(KeyCode.O))
                {
                    speed = 4;
                    timsec = true;
                    speedcount2 += 1;
                    LevelManager.Will.speed2 -= 1;

                }


            }
            if (speedcount2 == speedcountapprv2)
            {
                speedcount2 = 0;
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

        if (player2move)
        {
            movement();
            GetComponent<SpriteRenderer>().color = new Color(0, 255, 0);
        }
        else
        {
            GetComponent<SpriteRenderer>().color = new Color(0, 239, 255);
        }

    }

   

}