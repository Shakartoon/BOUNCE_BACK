using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramovecoroutine : MonoBehaviour {

	public float speed = 1f; 
	public Vector3 currentPosition; 
	public Vector3 newPosition; 

	void Start () {

		//currentPosition = transform.position; 
		
	}

	public IEnumerator moveUp(){
		yield return new WaitForSeconds (30f); 
		//newPosition = transform.localPosition.y; 
	//	Camera.mainCamera.transform.position = Vector3.up * speed * Time.deltaTime;
		transform.position = Vector3.Lerp (transform.position, new Vector3(0,11,0), 0.2f);

	}

	void Update () {
		StartCoroutine (moveUp ()); 
	}
}
