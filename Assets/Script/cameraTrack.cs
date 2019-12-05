using UnityEngine;
using System.Collections;

public class cameraTrack : MonoBehaviour {

	public GameObject sphere;

	void LateUpdate ()
	{	
		float xDif = (transform.position [0] - sphere.transform.position [0]);
		float yDif = (transform.position [1] - sphere.transform.position [1]);
		float zDif = (transform.position [2] - sphere.transform.position [2]);

		float hDist = Mathf.Sqrt (Mathf.Pow(xDif , 2) + Mathf.Pow(zDif , 2));

		float lookX = (-180 / Mathf.PI) * Mathf.Atan(hDist / yDif);
		float lookY = (180 / Mathf.PI) * Mathf.Atan(xDif / zDif);

		Vector3 lookDir = new Vector3 (lookX + (Mathf.Sign(yDif) * 90), lookY + (90 * Mathf.Sign(zDif) ) + 90, 0);
		transform.rotation = Quaternion.Euler(lookDir);
	}
}