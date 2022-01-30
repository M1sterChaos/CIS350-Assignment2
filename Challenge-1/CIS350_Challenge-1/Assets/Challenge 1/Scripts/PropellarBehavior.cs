/*
 * (Austin Buck)
 * (Assignment 2)
 * (Makes propellar spin)
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellarBehavior : MonoBehaviour
{
    public GameObject propellar;
    public float pz;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       propellar.transform.Rotate(0f, 0f, pz, Space.World);
    }
}
