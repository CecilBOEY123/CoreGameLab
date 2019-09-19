using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Mov : MonoBehaviour
{
    List<string> letters = new List<string>();
    string[] mywords = new string[] { "up" };
    string myword;
    public Text text;
    public GameObject player;
    bool mup;




    void Start()
    {
        myword = mywords[Random.Range(0, mywords.Length - 1)];

        mup = false;

        //text.text = myword;
    }
    

    void Update()
    {
        
        if(mup == true)
        {

            player.transform.position = new Vector3(0, 0, 0);


        }
       

    }

    void onGui()
    {
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("ok");

            letters.Add(Event.current.keyCode.ToString());

            for (int i = 0; i <= letters.Count - 1; i++)
            {
                if (letters[i] == myword.Substring(i, 1))
                {
                    Debug.Log("yay you typing ");
                    //text.color = Color.green;

                    if (letters.Count == myword.Length)
                    {

                        mup = true;

                        letters.Clear();
                        //myword = mywords[Random.Range(0, mywords.Length - 1)];
                        //text.text = myword;
                        //text.color = Color.white;
                    }
                }
                else
                {
                    Debug.Log("boo you suck");
                    letters.Clear();
                    //text.color = Color.red;
                }
            }
        }
    }
}