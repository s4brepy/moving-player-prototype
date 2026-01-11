
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	

	public float speed = 5f; //speed of the player

	private Rigidbody2D rb; //reference to the Rigidbody2D component
	public Vector2 input; //store player input

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


		float rotation = Mathf.Atan2(input.y, input.x) * Mathf.Rad2Deg; //calculate the rotation angle based on input 

        if (!(input == Vector2.zero)) // check if input is not zero to avoid unnecessary rotation
		{
			rb.SetRotation(rotation); //rotate the player based on input
		}
	
        
		
	}

	void FixedUpdate() // FixedUpdate is called at a fixed interval and is independent of frame rate
	{
		rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime); //move the player based on input
	}

}





