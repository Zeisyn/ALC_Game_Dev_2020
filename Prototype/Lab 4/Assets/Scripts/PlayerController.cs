﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 5.0f;
    public float xRange = 10.0f;
    public float zRange = 10.0f;
    public bool gameOver = false;
    

    // Update is called once per frame
    void Update()
    {
        // Keeps player in bounds - left side
        if (transform.position.x < -xRange) 
        { 
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        //Keeps player in bounds - right side
        if (transform.position.x > xRange) 
        {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //Keeps Objects in if they go too far upwards. 
        if (transform.position.z > zRange) 
        {
        transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        // Destroys Objects if they go too far down.
        if (transform.position.z < -zRange) 
        {
        Destroy(gameObject);
        }
        
        //Move player left /right on horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Move player forward/backwards on VerticalInput
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);

        //GameOver 
        if (transform.position.z < -10)
        {
            gameOver = true;
            Debug.Log("Game Over");
        } 
    }
    
    
    
}
