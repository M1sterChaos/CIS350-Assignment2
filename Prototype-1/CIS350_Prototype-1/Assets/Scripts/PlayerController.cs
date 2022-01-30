/*
 * (Austin Buck)
 * (Assignment 2)
 * (Controls the player by getting the horizontal and vertical
 *  axis)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;

    public float turnSpeed;

    public float horizontalInput;
    public float forwardInput;

    [SerializeField]
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * forwardInput * Time.deltaTime * speed);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * horizontalInput);
    }
}
