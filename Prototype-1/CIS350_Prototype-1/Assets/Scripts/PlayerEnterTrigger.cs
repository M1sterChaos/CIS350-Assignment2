/*
 * (Austin Buck)
 * (Assignment 2)
 * (If the player enteres the trigger then the score goes up)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerEnterTrigger : MonoBehaviour
{
    public Text textbox;

    public void Start()
    {
        textbox.text = " ";
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ScoreManager.score++;
        }

    }
}
