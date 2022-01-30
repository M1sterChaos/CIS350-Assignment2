/*
 * (Austin Buck)
 * (Assignment 2)
 * (Adds score when player collides with trigger)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager.score++;
        }
    }
}
