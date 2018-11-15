using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class verticalmovement : MonoBehaviour {


	public Vector3 screenPoint; 
	public Vector3 offset;

	public float yMaxPosition1; 
	public float yMaxPosition2; 


	void Start () {
	}


	void OnMouseDown()

	{
		Debug.Log ("..."); 
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Input.mousePosition.z));
	}

	void OnMouseDrag()
	{
		Debug.Log ("....."); 

		Vector3 curScreenPoint = new Vector3 (0, Input.mousePosition.y, 0);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint (curScreenPoint) + offset;
		transform.position = curPosition;

		//this restricts X movement for the slider from two certain points 
		//can also write if position is > than x and < z then movement is true 

		if (transform.position.x >= yMaxPosition1) {
			transform.position = new Vector3 (transform.position.x, yMaxPosition1, transform.position.z); 

		} 

		if (transform.position.x <= yMaxPosition2) {
			transform.position = new Vector3 (transform.position.x, yMaxPosition2, transform.position.z); 
		} 
	} 

} 