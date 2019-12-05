using UnityEngine;
using System.Collections;

public class eyeCatching : MonoBehaviour {

	void Update () 
	{
		transform.position = new Vector3 (0, Mathf.Sin(Time.fixedTime) + 3, 0) / 14;
		transform.Rotate (new Vector3 (12, 30, 8) * Time.deltaTime);
	}
}
