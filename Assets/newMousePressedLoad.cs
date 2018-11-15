using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newMousePressedLoad : MonoBehaviour {

	//List<List<Vector3>> paths = new List<List<Vector3>>();

//	public Vector3[] newPosition = new Vector3[3]; 
	public Vector3 currentPos; 
	public Vector3 newPosition;  
	public float timeToMove = 1f; 
	public List<Vector3> positions;


	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("HAPPENED."); 
			StartCoroutine(NewPos()); 
		} 
	}

	public IEnumerator NewPos() {

		yield return new WaitForSeconds (1f); 

		//this is the detault position of the circle 
		currentPos = transform.position; 

//		positions = new Vector3[] {
//			new Vector3(1, 1, 1), 
//			new Vector3 (3, 3, 3), 
//			new Vector3 (5, 5, 5) 
//		}; 
		
		transform.position = Vector3.Lerp (currentPos, newPosition, 1);


		//this is the time 
		//newPosition = new Vector3 (1, 1, 0); 
		newPosition = new Vector3 (Random.Range(-8f, 8f), Random.Range(3.5f, -3.5f), 0f);

	//	positions = new Vector3 (1, 1, 1); 

	
		var t = 0f; 

		//if the time is more than one second
//		while (t > 1) { 
//		
//			t += Time.deltaTime / timeToMove; 
//			transform.position = Vector3.Lerp (currentPos, newPosition, t);
//
//		}
	}
}
