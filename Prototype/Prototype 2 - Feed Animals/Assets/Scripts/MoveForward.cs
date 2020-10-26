using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    //movement speed of game object
    public float speed = 7;


    // Update is called once per frame
    void Update()
    {
        //moves the animals forward 
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
