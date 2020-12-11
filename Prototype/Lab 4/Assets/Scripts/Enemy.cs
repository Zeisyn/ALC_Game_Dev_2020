using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public float zRange = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.back * Time.deltaTime * speed);

        // Destroys Objects if they go too far upwards. 
        if (transform.position.z > zRange) 
        {
        Destroy(gameObject);
        }

        // Destroys Objects if they go too far down.
        if (transform.position.z < -zRange) 
        {
        Destroy(gameObject);
        }
    }
}
