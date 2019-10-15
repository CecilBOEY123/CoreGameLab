using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousetrack : MonoBehaviour
{

    public float speed; 

    // Start is called before the first frame update
    void Start()
    {

       

    }

    // Update is called once per frame
    void Update()
    {



            speed = Levelmanager.Will.speed;
            var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            targetPos.z = transform.position.z;
            transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        


    }
}
