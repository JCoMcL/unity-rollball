using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour 
{
	private Rigidbody rb;
	public GameObject targ;
	public float finalDist = 5;
	public float lazySpeed = 2;
	public float drag = 100 / 87;

	private Vector3 oldPos;
	private Vector3 velocity = new Vector3 (0, 0, 0);

	void FixedUpdate () 
	{
		Vector3 oldPos = transform.position;
		Vector3 dist = (transform.position - targ.transform.position);
		float distTotal = Vector3.Distance (transform.position, targ.transform.position);
		Vector3 distRatio = new Vector3 (dist [0] / distTotal, dist [1] / distTotal, dist [2] / distTotal);
		Vector3 finalPos = targ.transform.position + (distRatio * finalDist);
		Vector3 lazyDist = (transform.position - finalPos);
		float lazyDistTotal = Vector3.Distance(finalPos, transform.position);
			if (distTotal < finalDist) {lazyDistTotal *= -1;}
		Vector3 force = distRatio * (lazyDistTotal / lazySpeed);
		//transform.position = Vector3.Lerp (transform.position, finalPos, lazySpeed * Time.deltaTime);
		transform.position += velocity * drag - force;
		velocity = transform.position - oldPos;
	}
}
