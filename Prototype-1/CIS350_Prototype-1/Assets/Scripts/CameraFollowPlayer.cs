/*
 * (Austin Buck)
 * (Assignment 2)
 * (Make camera follow the player with an offset)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{

    public GameObject player;

    private Vector3 offset = new Vector3(0, 5, -10);

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + offset;
    }
}
