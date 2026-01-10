using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// Start is called once before the first execution of Update after the MonoBehaviour is created

	public float speed = 5f;

	private Rigidbody2D rb;
	private Vector2 input;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
	}


    void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		input.x = Input.GetAxisRaw("Horizontal");
		input.y = Input.GetAxisRaw("Vertical");

		input = input.normalized;
	}

	void FixedUpdate()
	{
		rb.MovePosition(rb.position + input * speed * Time.fixedDeltaTime);
	}

}





