using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour

{   
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 35.0f;
    
    public GameObject projectilePrefab;
    

    // Update is called once per frame
    void Update()
    {
        // Moves Player Character Left and Right using Input values
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        
        // Keeps player in bounds --Left side
        if (transform.position.x < -xRange) 
        {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        
        // Keeps player in bounds --Right side
        if (transform.position.x > xRange) 
        {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
        
        
        
        //Launch Projectile from player on Keypress
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
        
    }
}
