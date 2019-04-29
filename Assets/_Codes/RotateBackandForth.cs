using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBackandForth : MonoBehaviour
{

	public float rotationVal = 10; 
	
	void Update () {
		
		transform.localEulerAngles = new Vector3(0, 0, -Mathf.PingPong(Time.time * 50, rotationVal)); 

		
	}
}
