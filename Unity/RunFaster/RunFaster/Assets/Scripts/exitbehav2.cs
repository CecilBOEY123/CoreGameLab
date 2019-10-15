using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class exitbehav2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (GameObject.FindGameObjectsWithTag("exit2").Length > 1)
        {

            Destroy(this.gameObject);

        }


    }

    private void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "runner")
        {

            SceneManager.LoadScene(4);

        }

    }
}
