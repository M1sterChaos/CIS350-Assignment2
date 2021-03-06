/*
 * (Austin Buck)
 * (Assignment 2)
 * (If player hits death zone game ends)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverBehavior : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.gameover = true;
        }
    }
}
