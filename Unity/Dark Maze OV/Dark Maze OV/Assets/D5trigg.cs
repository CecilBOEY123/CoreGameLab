using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class D5trigg : MonoBehaviour
{

    public GameObject key;
    public GameObject player;
    //bool k;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D oth)
    {

       
       

       
        
            if (oth.CompareTag("Key"))

            {
                SceneManager.LoadScene(1);
            }
        






    }
    
}


