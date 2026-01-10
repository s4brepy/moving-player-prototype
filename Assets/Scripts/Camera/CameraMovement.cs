using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform target; // The target for the camera to follow
	
	void Start() // Start is called before the first frame update
	{

    }

    
    void Update() // Update is called once per frame
	{
        

    }

    private void LateUpdate() // LateUpdate is called after all Update functions have been called
	{
		if (target == null) { return;} //If there is no target, do nothing
		Vector3 pos = transform.position;

		pos.x = target.position.x; //Follow the target's x position
		pos.y = target.position.y; //Follow the target's y position

		transform.position = pos; //Update the camera's position
	}
}