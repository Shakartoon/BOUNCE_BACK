using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clockwiserotation : MonoBehaviour {


	public float rotateX; 
	public float rotateY; 
	public float rotateZ; 
	public float speed = -1;


	public bool wasHit; 
	triangleTrigger triangleTriggerScript; 


	// Use this for initialization
	void Start () {
	//	wasHit == false; 
	// 	filled == true;
				
	}
	
	// Update is called once per frame

	IEnumerator RotateForSeconds() {

		float time = 1;     //How long will the object be rotated? 
		///^^^*** GOAL: TIME VARIES--ROTATE FOR THE AMOUNT OF TIME THAT AUDIO CLIP PLAYS*** 
		while(time > 0)     //While the time is more than zero...
		{
			//transform.Rotate(Vector3.up, Time.deltaTime * speed);
			transform.Rotate (rotateX, rotateY, Time.deltaTime * speed, Space.World);
			time -= Time.deltaTime;     //Decrease the time- value one unit per second.

			yield return null;     //Loop the method.
		}
		wasHit = false; 
		//Destroy(this);

	} 
		
	void Update () {

		if (wasHit) {

			StartCoroutine (RotateForSeconds()); 

		}
		//if rotates around, stop at original location for several seconds, then rotate again.
	}
}
