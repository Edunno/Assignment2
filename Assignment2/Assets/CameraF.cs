﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraF : MonoBehaviour
{
    public Transform playerObject;
    public float distanceFromObject = 6f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector3 lookOnObject = playerObject.position - transform.position;
        lookOnObject = playerObject.position - transform.position;
        lookOnObject.y = lookOnObject.y-5;
        transform.forward = lookOnObject.normalized;
        Vector3 playerLastPosition;
        
        playerLastPosition = playerObject.position - lookOnObject.normalized * distanceFromObject;
        transform.position = playerLastPosition; 
    }
}
