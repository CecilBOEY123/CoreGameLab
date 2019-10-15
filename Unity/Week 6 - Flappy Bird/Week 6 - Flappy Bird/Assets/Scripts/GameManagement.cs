using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour
{
    public static GameManagement Will;

   



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
    public int score;
    public void updateScore()
    {
        UIManager.Park.ShowNewScore(score);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(score == 3)
        {
            score = 4;
            updateScore();
            SceneManager.LoadScene(2);

            
        }


    }
}
