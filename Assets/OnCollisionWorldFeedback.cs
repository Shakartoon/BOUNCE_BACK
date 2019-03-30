using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.PlayerLoop;

public class OnCollisionWorldFeedback : MonoBehaviour
{

	public GameObject largestCircle; 
	
	void Start () {
		
	}
	
	
	public Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) {
		Vector3 dir = point - pivot; // get point direction relative to pivot
		dir = Quaternion.Euler(angles) * dir; // rotate it
		point = dir + pivot; // calculate rotated point
		return point; // return it
	}

	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			
			transform.position = Quaternion.Euler(13, 06, 0) * Vector3.forward;
			//RotatePointAroundPivot(new Vector3(13, 6, 1), new Vector3(1, 1, 1), new Vector3(0, 0, 360)); 

		}
	}
}
