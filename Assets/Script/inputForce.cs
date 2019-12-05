using UnityEngine;
using System.Collections;

public class inputForce : MonoBehaviour 
{	
	private Rigidbody rb;
	public GameObject cam;

	public float speed = 120;

	void Start() 
	{
		rb = GetComponent<Rigidbody>();
	}

	void FixedUpdate() 
	{
		rb.maxAngularVelocity = speed;
		float camY = cam.transform.rotation [1];
		//float rotZ = Mathf.Sin (camY);
		//float rotX = Mathf.Cos (camY);
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 positionDif = transform.position - cam.transform.position;
		float tempX = positionDif [2] / (Mathf.Abs(positionDif [2]) + Mathf.Abs(positionDif [0]));
		float tempZ = positionDif [0] / (Mathf.Abs(positionDif [0]) + Mathf.Abs(positionDif [2]));

		Vector3 H_movement = new Vector3 (moveHorizontal * tempZ, 0.0f, moveHorizontal * tempX) * -1;
		Vector3 V_movement = new Vector3 (moveVertical * tempX, 0.0f, -1 * moveVertical * tempZ);
//		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddTorque(H_movement * speed);
		rb.AddTorque(V_movement * speed);
//		rb.AddForce(movement * speed);
	}
}
