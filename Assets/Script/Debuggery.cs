using UnityEngine;
using System.Collections;

public class Debuggery : MonoBehaviour 
{
	public GameObject cam;
	public GameObject sphere;
	public float speed = 30;

	void Update() 
	{	
		float tempX = sphere.transform.position [2] / (Mathf.Abs(sphere.transform.position [2]) + Mathf.Abs(sphere.transform.position [0]));
		float tempZ = -1 * sphere.transform.position [0] / (Mathf.Abs(sphere.transform.position [0]) + Mathf.Abs(sphere.transform.position [2]));
		
		float camY = cam.transform.rotation [1];
		float rotX = Mathf.Sin (tempX);
		float rotZ = Mathf.Cos (tempZ);
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");

		Vector3 value = new Vector3 (10 * tempX, 1,10 * tempZ);
		transform.position = value;
	}
}