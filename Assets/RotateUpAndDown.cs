using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateUpAndDown : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.rotation = Quaternion.Euler(Mathf.Sin(Time.realtimeSinceStartup) * 3, 0, 0); 

		
	}
}
