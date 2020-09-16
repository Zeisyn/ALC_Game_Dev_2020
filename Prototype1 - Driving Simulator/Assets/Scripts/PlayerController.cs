using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    public float turnSpeed = 50;
    
    public float horizontalInput;
    public float verticalInput;
    
    public float jumpInput;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Turns Vehicle
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput * Time.deltaTime);
        
        //Moves Vehicle forward
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.forward *Time.deltaTime * speed * verticalInput);
        
        //Jump
        
        jumpInput = Input.GetAxis("Jump");
        transform.Translate(Vector3.up *Time.deltaTime * speed * jumpInput);
        
        
        
    }
}
