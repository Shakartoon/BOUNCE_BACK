using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateOnDrag : MonoBehaviour {

	private Vector3 mousePos;
	public GameObject ball; 
	private Vector3 worldPos; 

	// Use this for initialization
	void Start () {

		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0f); 
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			//Ray ray = Camera.main.ScreenPointToRay (mousePos); 
			worldPos = Camera.main.ScreenToWorldPoint (mousePos); 

			Instantiate (ball, worldPos, Quaternion.identity); 

			RaycastHit hit; 
			worldPos = hit.point; 

		} 
		
//			if (Physics.Raycast (ray, out hit, 10))
		}


}
