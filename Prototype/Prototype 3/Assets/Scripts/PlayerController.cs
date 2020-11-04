using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce = 7;
    public float gravityModifier = 1;
    public bool isOnGround = true;
    
    

    void Start()
    {
        playerRb = GetComponent <Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

   
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        isOnGround = true;
    }
}
