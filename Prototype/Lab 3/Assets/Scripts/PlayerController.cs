using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

public float horizontalInput;
public float verticalInput;
public float speed = 10.0f;
public float xRange = 5.0f;
public float zRange = 5.0f;
    
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

        //Keeps player in bounds - top 
        if (transform.position.z > zRange) 
        {
        transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
        }

        //Keeps player in bounds - bottom
        if (transform.position.z < -zRange) 
        {
        transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
        }
        
        //Move player left /right on horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);

        //Move player forward/backwards on VerticalInput
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
    }
}

