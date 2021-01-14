using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public GameObject powerupIndicator;
    private GameObject focalPoint;
    private Rigidbody playerRb;
<<<<<<< Updated upstream
    public float speed = 4.0f;
    public bool gameOver = false;
    
    
=======
    
    private float powerupStrength = 15.0f;
    public bool hasPowerup;
    public float speed = 2.0f;

>>>>>>> Stashed changes
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>(); 
        focalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * speed * forwardInput);
        powerupIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);
    
    if (transform.position.y < -10)
        {
            gameOver = true;
            Debug.Log("Game Over");
        } 
    }

    //When PowerUp is collected, set haspowerup to true
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Powerup")) 
        {
            hasPowerup = true;
            powerupIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCountdownRoutine());
        }
    }
    
    //when Powerup is collected, set a timer for 7 seconds.
    IEnumerator PowerupCountdownRoutine() 
    {
        yield return new WaitForSeconds(7);
        hasPowerup = false;
        powerupIndicator.gameObject.SetActive(false);
    }

    //When hasPowerUp is active, send enemys back with more strength
    private void OnCollisionEnter(Collision collision) 
    {
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup) 
        {
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayFromPlayer = (collision.gameObject.transform.position - transform.position);

            Debug.Log("Player collided with " + collision.gameObject + " with powerup set to " + hasPowerup);
            enemyRb.AddForce(awayFromPlayer * powerupStrength, ForceMode.Impulse);
        }
    }
    
}
