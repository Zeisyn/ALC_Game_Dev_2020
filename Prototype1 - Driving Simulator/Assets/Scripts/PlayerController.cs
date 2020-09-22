using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20;
    private float turnSpeed = 50;
    
    private float horizontalInput;
    private float verticalInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //rotates vehicle left and right on horizontal input
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        //Moves Vehicle forward and back based on vertical input
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *Time.deltaTime * speed * verticalInput);
    }
}
