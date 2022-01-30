/*
 * (Austin Buck)
 * (Assignment 2)
 * (Controls score and win/lose and ability to restart)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score;

    public static bool won = false;
    public static bool gameover = false;

    public Text textbox;
    // Start is called before the first frame update
    void Start()
    {
        gameover = false;
        won = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(!gameover)
        {
            textbox.text = "Score: " + score;
        }
        if (score >= 5)
        {
            won = true;
            gameover = true;
        }
        if (gameover)
        {
            if (won)
            {
                textbox.text = "You Won! Press R to restart";
            }
            else
            {
                textbox.text = "You Lost! Press R to restart";
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
        
    }
}
