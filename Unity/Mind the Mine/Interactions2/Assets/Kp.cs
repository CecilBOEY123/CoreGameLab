using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Kp : MonoBehaviour
{
    public int speed;
 

    List<string> letters = new List<string>();
    string[] mywords = new string[] { "UP" };

    List<string> lettersd = new List<string>();
    string[] mywordsd = new string[] {"DOWN" };

    List<string> lettersl = new List<string>();
    string[] mywordsl = new string[] { "LEFT" };

    List<string> lettersr = new List<string>();
    string[] mywordsr = new string[] { "RIGHT" };

    string myword;
    string mywordd;
    string mywordl;
    string mywordr;


    public Text text;
    public Text textd;
    public Text textl;
    public Text textr;

    bool mov;
    bool movd;
    bool movl;
    bool movr;

    public GameObject player;
    




    void Start()
    {

        speed = 2;


        myword = mywords[0];
        mywordd = mywordsd[0];
        mywordl = mywordsl[0];
        mywordr = mywordsr[0];

        //myword = mywords[Random.Range(0, mywords.Length - 1)];

        text.text = myword;
        textd.text = mywordd;
        textl.text = mywordl;
        textr.text = mywordr;
    }


    void Update()
    {

        if (mov == true)
        { 
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y+1 * Time.deltaTime*speed);

        }
       

        if (movd == true)
        {
            player.transform.position = new Vector2(player.transform.position.x, player.transform.position.y-1*Time.deltaTime*speed);

        }


        if (movl == true)
        {
            player.transform.position = new Vector2(player.transform.position.x - 1 * Time.deltaTime*speed, player.transform.position.y);

        }

        if (movr == true)
        {
            player.transform.position = new Vector2(player.transform.position.x + 1 * Time.deltaTime*speed, player.transform.position.y);

        }


    }

    void OnGUI()
    {
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("Current detected event: " + Event.current);
            letters.Add(Event.current.keyCode.ToString());

            for (int i = 0; i <= letters.Count - 1; i++)
            {
                if (letters[i] == myword.Substring(i, 1))
                {
                    Debug.Log("typing");
                    text.color = Color.green;
                    

                    if (letters.Count == myword.Length)
                    {
                        mov = true;

                        movd = false;
                        movr = false;
                        movl = false;

                        Debug.Log("you are moving" + myword);
                        text.fontStyle = FontStyle.Bold;
                        letters.Clear();
                        // myword = mywords[Random.Range(0, mywords.Length - 1)];
                        text.text = myword;
                        text.color = Color.white;
                    }

                }
                else
                {
                    Debug.Log("incorrect");
                    letters.Clear();
                    text.color = Color.red;
                }


            }
        }

       if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("Current detected event: " + Event.current);
            lettersd.Add(Event.current.keyCode.ToString());

            for (int u = 0; u <= lettersd.Count - 1; u++)
            {
                if (lettersd[u] == mywordd.Substring(u, 1))
                {
                    Debug.Log("typing");
                    textd.color = Color.green;
                    ;

                    if (lettersd.Count == mywordd.Length)
                    {
                        movd = true;

                        mov = false;
                        movl = false;
                        movr = false;


                        Debug.Log("you are moving" + mywordd);
                        textd.fontStyle = FontStyle.Bold;
                        lettersd.Clear();

                        textd.text = mywordd;
                        textd.color = Color.white;
                    }
                }
                else
                {
                    Debug.Log("incorrect");
                    lettersd.Clear();
                    textd.color = Color.red;
                }
            }
        }
        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("Current detected event: " + Event.current);
            lettersl.Add(Event.current.keyCode.ToString());

            for (int o = 0; o <= lettersl.Count - 1; o++)
            {
                if (lettersl[o] == mywordl.Substring(o, 1))
                {
                    Debug.Log("typing");
                    textl.color = Color.green;
                  

                    if (lettersl.Count == mywordl.Length)
                    {
                        movl = true;

                        mov = false;
                        movd = false;
                        movr = false;

                        Debug.Log("you are moving" + mywordl);
                        textl.fontStyle = FontStyle.Bold;
                        lettersl.Clear();
                        // myword = mywords[Random.Range(0, mywords.Length - 1)];
                        textl.text = mywordl;
                        textl.color = Color.white;
                    }

                }
                else
                {
                    Debug.Log("incorrect");
                    lettersl.Clear();
                    textl.color = Color.red;
                }


            }
        }

        if (Event.current.type == EventType.KeyDown && Event.current.keyCode != KeyCode.None)
        {
            Debug.Log("Current detected event: " + Event.current);
            lettersr.Add(Event.current.keyCode.ToString());

            for (int q = 0; q <= lettersr.Count - 1; q++)
            {
                if (lettersr[q] == mywordr.Substring(q, 1))
                {
                    Debug.Log("typing");
                    textr.color = Color.green;
                   

                    if (lettersr.Count == mywordr.Length)
                    {
                        movr = true;

                        movd = false;
                        movl = false;
                        mov = false;

                        Debug.Log("you are moving" + mywordr);
                        textr.fontStyle = FontStyle.Bold;
                        lettersr.Clear();
                        // myword = mywords[Random.Range(0, mywords.Length - 1)];
                        textr.text = mywordr;
                        textr.color = Color.white;
                    }

                }
                else
                {
                    Debug.Log("incorrect");
                    lettersr.Clear();
                    textr.color = Color.red;
                }


            }
        }
    }

   
}

