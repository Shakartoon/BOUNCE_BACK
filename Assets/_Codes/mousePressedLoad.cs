using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mousePressedLoad : MonoBehaviour {

	//public GameObject obj; 

	void Start () {
		
	}

	void Update () {
	} 

	void MousePressed() {
		if (Input.GetMouseButtonDown (0)) {
			Debug.Log ("HAPPENED."); 
			transform.Translate(Vector3.forward * Time.deltaTime);

		//	StartCoroutine (NewPosition());  
		} 
	}

//	public IEnumerator NewPosition () {
//
//		//Destroy (gameObject);
//		yield return new WaitForSeconds (1f);
//		Debug.Log ("THING"); 
//		//Instantiate(gameObject, new Vector3(2, 3, 0), Quaternion.identity); 
//		//yield return null;

//	}

}
