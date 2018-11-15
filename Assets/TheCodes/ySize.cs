using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ySize : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

		transform.localScale += new Vector3(0.1F, 0, 0);
		
	}
}
