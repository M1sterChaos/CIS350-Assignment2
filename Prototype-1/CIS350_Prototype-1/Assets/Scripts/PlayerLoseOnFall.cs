/*
 * (Austin Buck)
 * (Assignment 2)
 * (If the player falls a certain height then they lose)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLoseOnFall : MonoBehaviour
{
    public Text textbox;

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -1)
        {
            ScoreManager.gameover = true;
        }
    }
}
