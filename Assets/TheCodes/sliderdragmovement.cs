using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sliderdragmovement : MonoBehaviour {

	public Vector3 screenPoint; 
	public Vector3 offset;

	public float xMaxPosition1; 
	public float xMaxPosition2; 
	//this is for changing the pitch 
	public float xPitchPosition1; 

	public float yMaxPosition1; 
	public float yMaxPosition2; 


 	public AudioClip mySound; 

	public float pitch1; 
	public float pitch2; 

	public bool isPlaying; 

	void Start () {
	}


	void Update () {

	}
		
	void OnMouseDown()

	{
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, 0, 0));
	}

	void OnMouseDrag()
	{
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, 0, 0);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;

		//this restricts X movement for the slider from two certain points 
		//can also write if position is > than x and < z then movement is true 

		if (transform.position.x >= xMaxPosition1) {
			transform.position = new Vector3 (xMaxPosition1, transform.position.y, transform.position.z); 

		} 

		if (transform.position.x <= xMaxPosition2) {
			transform.position = new Vector3 (xMaxPosition2, transform.position.y, transform.position.z); 
		} 

		//this restricts Y movement for the slier 
//		if (transform.position.x >= yMaxPosition1) {
//			transform.position = new Vector3 (transform.position.x, yMaxPosition1, transform.position.z); 
//
//		} 
//
//		if (transform.position.x <= yMaxPosition2) {
//			transform.position = new Vector3 (transform.position.x, yMaxPosition2, transform.position.z); 
//		} 

		//1.84


		// PITCH SHIFTER 

		if (transform.position.x >= xPitchPosition1 && isPlaying == true) {

		//Find the audio playing and increase the pitch 
		//Should make an easier way to do this for different sounds. 
			//audioSource.pitch -= Time.deltaTime * startingPitch / timeToDecrease;
			Debug.Log ("OK"); 
		} 


	
	}

}


