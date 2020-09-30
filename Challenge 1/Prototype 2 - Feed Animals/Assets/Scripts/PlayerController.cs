﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{   
    public float horizontalInput;
    public float speed = 10;
    public float xRange = 10;
    
    public GameObject projectilePrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Moves Player Character Left and Right
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.left * Time.deltaTime * speed * horizontalInput);
        
        // Keeps player in bounds --Left side
        if (transform.position.x < -xRange) {
        transform.position = new Vector3(-10, transform.position.y, transform.position.z);}
        
        // Keeps player in bounds --Right side
        if (transform.position.x > xRange) {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);}
    }
}