using UnityEngine;

public class Bullet : MonoBehaviour
{
    

    
    public float speed = 12f;
    private Rigidbody2D rb; // Reference to the Rigidbody2D component


    private bool launched = false; // Flag to check if the bullet has been launched

    private void Awake() // Awake is called when the script instance is being loaded
    {


        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the bullet
    }
    public void Launch(Vector2 direction) // Launch is called to set the bullet in motion
    {
        if (launched) return; // If the bullet has already been launched, do nothing

        if (direction == Vector2.zero)
        {
            direction = Vector2.right;  // Default direction if no direction is provided
        }

        rb.linearVelocity = direction.normalized * speed; // Set the bullet's velocity in the specified direction
        launched = true; // Mark the bullet as launched


       

    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Player"))
        {
            return; // Ignore collisions with the player
        }

        // Handle collision with other objects
        
        Destroy(gameObject); // Destroy the bullet on collision with any other object
       
    }

}
