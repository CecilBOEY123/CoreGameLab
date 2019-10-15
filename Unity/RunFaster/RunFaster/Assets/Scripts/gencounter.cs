using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gencounter : MonoBehaviour
{

    public static int counter;
    public GameObject exit;

    public Text text;

    // Start is called before the first frame update
    void Start()
    {
        counter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Active Generators:" + counter;

        if(counter == 2)
        {
            Instantiate(exit, new Vector3(12, 9, 0), Quaternion.identity);
        }
        
    }
}
