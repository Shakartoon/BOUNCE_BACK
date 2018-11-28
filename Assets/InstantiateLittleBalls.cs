using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateLittleBalls : MonoBehaviour {

	public GameObject littleBalls; 
	private Vector3 initialPosOfLittleBalls;

	public Transform[] ballTransform; 
	public Vector3[] defaultPositions; 


	void Start () {
		
	//	initialPosOfLittleBalls = transform.position;
		littleBalls.SetActive(false); //InvokeRepeating ("ActivateLittleBalls", 1f, 2f); 
		StartCoroutine(activatetheballs());

		defaultPositions = new Vector3[ballTransform.Length]; //every array has a length variable 

		//if you do 5 in upper it will do 5 times 
		for (int i = 0; i < ballTransform.Length; i++)
		{
			//the default position of the balls (first, second, third, etc.) is equal to the transform 
			defaultPositions[i] = ballTransform[i].position; 
		}
		

	}
	
	IEnumerator activatetheballs()
	{
	
		yield return new WaitForSeconds(1f);
		for (int i = 0; i < defaultPositions.Length; i++)
		{
			//ballTransform = defaultPositions[i];
			ballTransform[i].position = defaultPositions[i];
		}
		//littleBalls.transform.position = initialPosOfLittleBalls; // we reset its position to initial position // also reset speed 
		littleBalls.SetActive(true); 
		yield return new WaitForSeconds(1f); 
		littleBalls.SetActive(false); 	
		StartCoroutine(activatetheballs());

	}
	
	
	void Update () {
		
		//StartCoroutine(activatetheballs()); 
	
	}
}
