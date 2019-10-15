using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunbuff : MonoBehaviour
{
    public GameObject stun;
    public GameObject speed;
    public float timecount;

    bool buffspawn;

    // Start is called before the first frame update
    void Start()
    {

        timecount = 0;

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timecount += Time.deltaTime;

        if (timecount >= 4.99999 && timecount <= 5.00001)
        {
            Instantiate(stun, new Vector3(-6.4f, -4, 0), Quaternion.identity);
            Instantiate(speed, new Vector3(6, 3.7f, 0), Quaternion.identity);
        }

        if (timecount > 10)
        {
            timecount = 0;

        }

    }
}
