using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class movvv : MonoBehaviour
{
    public Text text;
    

    private Dictionary<string, Vector3> directions = new Dictionary<string, Vector3> {
         { "up", Vector3.up },
         { "down", Vector3.down },
         { "left", Vector3.left },
         { "right", Vector3.right }
     };

    private string input = "";

    // Update is called once per frame

    void Start()
    {
        

    }

    void Update()
    {
        if(transform.position.x > 4.5f)
        {
            transform.position = new Vector3(4.5f, transform.position.y, 0);
        }
        if (transform.position.x < -4.5f)
        {
            transform.position = new Vector3(-4.5f, transform.position.y, 0);
        }
        if (transform.position.y > 4.5f)
        {
            transform.position = new Vector3(transform.position.x, 4.5f, 0);

        }
        if (transform.position.y < -4.5f)
        {
            transform.position = new Vector3(transform.position.x, -4.5f, 0);
        }

        char letter;
        if (IsTypingLetter(out letter))
        {
            input += letter;
            if (!CheckInput())
            {
                Debug.LogWarning("Fail");
                input = letter.ToString();
                text.text = input;
                text.color = Color.red;
                CheckInput();
            }
        }
    }

    private bool CheckInput()
    {
        KeyValuePair<string, Vector3> direction;
        bool isTypingDirection = IsTypingDirection(input, out direction);
        if (isTypingDirection)
        {
            if (string.Equals(direction.Key, input))
            {
                Debug.Log("Direction correct. Moving object " + input);
                text.text = input;
                text.color = Color.green;
                transform.position += direction.Value;
                input = "";
            }
            else
            {
                Debug.Log("Go on! You are typing " + input);
                text.text = input;
                text.color = Color.white;
            }
        }
        return isTypingDirection;
    }

    private bool IsTypingLetter(out char letter)
    {
        if (Input.inputString.Length == 1)
        {
            letter = Input.inputString.ToLower()[0];
            if (letter >= 'a' && letter <= 'z')
            {
                return true;
            }
        }
        letter = '\0';
        return false;
    }

    private bool IsTypingDirection(string input, out KeyValuePair<string, Vector3> direction)
    {
        foreach (KeyValuePair<string, Vector3> dir in directions)
        {
            if (dir.Key.StartsWith(input))
            {
                direction = dir;
                return true;
            }
        }
        direction = new KeyValuePair<string, Vector3>(null, Vector3.zero);
        return false;
    }

   
}
