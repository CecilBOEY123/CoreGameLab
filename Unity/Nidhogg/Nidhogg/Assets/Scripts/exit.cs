using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if(enemy.run == true)
        {

            if(collision.gameObject.tag == "Player")
            {

                SceneManager.LoadScene(1);

            }
            
        }

    }
}
