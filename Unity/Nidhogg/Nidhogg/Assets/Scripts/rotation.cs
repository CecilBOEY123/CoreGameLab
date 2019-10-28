using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public GameObject sword;
    public float rotateSpeed;
    public GameObject player;
    public float speed;

    public int count;

    bool neutral;
    bool up;
    bool down;
    bool hold;
    bool thr;


    // Start is called before the first frame update
    void Start()
    {
        speed = 10;

        rotateSpeed = 5;
        neutral = true;
        up = false;
        down = false;
        hold = false;
        thr = false;
        count = 0;


    }

    // Update is called once per frame
    void Update()
    {
      
        

        Quaternion pos = transform.rotation;
        Vector3 spos = sword.transform.position;

        if(count == 0)
        {
            if (Input.GetKeyDown("w"))
            {
                pos = Quaternion.AngleAxis(30, Vector3.forward);
                hold = false;
                neutral = false;
                up = true;
                count = 1;

            }
            if (Input.GetKeyDown("s"))
            {
                pos = Quaternion.AngleAxis(-30, Vector3.forward);
                hold = false;
                neutral = false;
                down = true;
                count = -1;
            }
        } 
        if(count == 1)
        {
          
            if (Input.GetKey("w"))
            {
                pos = Quaternion.AngleAxis(80, Vector3.forward);
                neutral = false;
                up = false;
                down = false;
                hold = true;

                if (Input.GetKeyDown("f"))
                {
                    thr = true;
                }
            }
            else
            {
                pos = Quaternion.AngleAxis(30, Vector3.forward);
                hold = false;
                neutral = false;
                down = false;
                up = true;
                count = 1;
            }
            if (Input.GetKeyDown("s"))
            {
                pos = Quaternion.AngleAxis(0, Vector3.forward);
                neutral = true;
                hold = false;
                up = false;
                down = false;
                count = 0;
            }
        }
        if(count == -1)
        {
            if (Input.GetKeyDown("w"))
            {
                pos = Quaternion.AngleAxis(0, Vector3.forward);
                neutral = true;
                hold = false;
                up = false;
                down = false;
                count = 0;

            }
        }


        transform.rotation = pos;
        

        if (up)
        {
            transform.position = new Vector3(player.transform.position.x + 0.30f, player.transform.position.y + 0.5f, player.transform.position.z);
            if (thr == false)
            {
                sword.transform.position = spos;
                sword.transform.position = new Vector3(this.transform.position.x + 0.9f, this.transform.position.y + 0.2f, this.transform.position.z);
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
            }
            else
            {
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
                sword.transform.position = spos;
                spos.x += speed * Time.deltaTime;
            }
        }
        if (down)
        {
            transform.position = new Vector3(player.transform.position.x + 0.30f, player.transform.position.y - 0.25f, player.transform.position.z);
            if (thr == false)
            {
                sword.transform.position = spos;
                sword.transform.position = new Vector3(this.transform.position.x + 0.9f, this.transform.position.y - 0.2f, this.transform.position.z);
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
            }
            else
            {
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
                sword.transform.position = spos;
                spos.x += speed * Time.deltaTime;
            }
        }
        if(neutral)
        {
            pos = Quaternion.AngleAxis(0, Vector3.forward);
            transform.position = new Vector3(player.transform.position.x + 0.5f, player.transform.position.y + 0.25f, player.transform.position.z);
            if (thr == false)
            {
                sword.transform.position = spos;
                sword.transform.position = new Vector3(this.transform.position.x + 1, this.transform.position.y, this.transform.position.z);
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
            }
            else
            {
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
                sword.transform.position = spos;
                spos.x += speed * Time.deltaTime;
            }
        }
        if(hold)
        {
            pos = Quaternion.AngleAxis(80, Vector3.forward);
            transform.position = new Vector3(player.transform.position.x + 0.25f, player.transform.position.y + 0.5f, player.transform.position.z);
            if (thr == false)
            {
                sword.transform.position = spos;
                sword.transform.position = new Vector3(this.transform.position.x + 0.1f, this.transform.position.y + 0.8f, this.transform.position.z);
                sword.transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
            }
            else
            {
                sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
                sword.transform.position = spos;
                spos.x += speed * Time.deltaTime;
            }
        }
        if(thr)
        {
            sword.transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
            sword.transform.position = spos;
            spos.x += speed * Time.deltaTime;

        }

        Debug.Log(count);

    


    }
}
