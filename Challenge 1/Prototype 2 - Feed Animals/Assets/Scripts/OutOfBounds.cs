﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfBounds : MonoBehaviour
{
    public float topBounds = 35.0f;
    public float lowerBounds = -15.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds) 
        {
            Debug.Log("Game Over");
            Destroy(gameObject);
            Time.timeScale = 0;
        }

        else if(transform.position.z < lowerBounds)
        {
            
            Destroy(gameObject);
            
        }

    }
}
