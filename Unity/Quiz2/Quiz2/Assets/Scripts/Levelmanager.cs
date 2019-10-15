using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmanager : MonoBehaviour
{

    public static Levelmanager Will;





    private void Awake()
    {

        if (Will == null)
        {
            Will = this;
            DontDestroyOnLoad(this);

        }
        else if (Will != this)
        {
            Destroy(gameObject);

        }
    }

    public float speed;

    // Start is called before the first frame update
    void Start()
    {

  
        
    }

    // Update is called once per frame
    void Update()
    {
        


    }
}
