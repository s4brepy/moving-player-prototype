using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	

	public float speed = 5f; //speed of the player

	private Rigidbody2D rb; //reference to the Rigidbody2D component
	private Vector2 input; //store player input

	private void Awake() // Awake is called when the script instance is being loaded
	{
        rb = GetComponent<Rigidbody2D>(); //get the Rigidbody2D component
	}


    void Start() // Start is called before the first frame update
	{

	}

	
	void Update() // Update is called once per frame
	{
		input.x = Input.GetAxisRaw("Horizontal"); //get horizontal input
		input.y = Input.GetAxisRaw("Vertical"); //get vertical input

		input = input.normalized; //normalize the input vector to prevent faster diagonal movement
	}

	void FixedUpdate() // FixedUpdate is called at a fixed interval and is independent of frame rate
	{
		rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime); //move the player based on input
	}

}





