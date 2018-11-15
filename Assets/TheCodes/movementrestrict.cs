using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementrestrict : MonoBehaviour {

	public GameObject hi; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//transform.localPosition= new Vector3(0,3,0);

		transform.Translate (Vector3.up * Time.deltaTime); 

		if (transform.position.y > 2f) {
			Debug.Log ("Code doesn't scare me"); 
			transform.Translate (Vector3.down * Time.deltaTime); 			
			//transform.position.y = new Vector3 (0, -3, 0); 
		} 

	}
}
