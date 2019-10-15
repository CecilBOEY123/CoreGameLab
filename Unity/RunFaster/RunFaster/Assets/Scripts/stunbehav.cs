using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stunbehav : MonoBehaviour
{
    public GameObject stunner;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("stunbuff").Length > 1)
        {

            Destroy(this.gameObject);

        }

    }

    private void OnTriggerStay2D(Collider2D col)
    {

       

        if (col.gameObject.tag == "runner")
        {
            LevelManager.Will.stun1 += 1;
            Destroy(stunner);
        }
      

    }
}
