using UnityEngine;

public class PlayerShooting : MonoBehaviour
{


    
    [SerializeField] private Bullet bulletPrefab;
    public Vector2 shootDirection;
    void Start()
    {
        
        
    }

    
    void Update()
    {
        Vector2 input = new(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")); // Get player input for shooting direction

        if (input != new Vector2(0, 0)) // Check if there is any input from the player
        {
            shootDirection = input.normalized; // Update the shoot direction based on player input
        }

        // Check if the player is pressing the space key to shoot
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            
            Bullet bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // Create a new bullet instance at the player's position
            bullet.Launch(shootDirection); // Launch the bullet in the shoot direction
        }

        }
    }

