using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiateOnDrag : MonoBehaviour {

	private Vector3 mousePos;
	public GameObject ball; 
	private Vector3 worldPos; 
	public GameObject ballClone; 
	public newSoundMakingObject newSoundMakingObjectScript; 

	private Vector3 spawnPosition; 

	// Use this for initialization
	void start () {

		mousePos = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 0f); 
	}
	
	// Update is called once per frame

	public IEnumerator instantiateTheBalls(){
	
		yield return new WaitForSeconds (1); 
	//	Destroy (objectInstance); 
	}

	void MoveByExample () {

		//THIS DOESN'T WORK: 
		iTween.MoveBy (this.gameObject, iTween.Hash ("position", new Vector3 (1, 1, 0), "time", 2f, "easetype", iTween.EaseType.easeInOutBack)); 

	}

	void OnMouseDrag() {

		spawnPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
		spawnPosition.z = 0.0f; 
		ballClone = (GameObject) Instantiate (ball, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;


	}

	void Update () {

		if (Input.GetMouseButtonDown (0)) {
			spawnPosition = Camera.main.ScreenToWorldPoint (Input.mousePosition); 
			spawnPosition.z = 0.0f; 
			ballClone = (GameObject) Instantiate (ball, spawnPosition, Quaternion.Euler(new Vector3(0, 0, 0))) as GameObject;
		
			//IF R BUTTON PRESSED, STORE AND REPEAT THE INSTANTIATE POSITION 
			// IF C BUTTON PRESSED, CLEAR IT 

		} 

		//IF MOUSE DRAGGED, CREATE A NEW BALL AT EVERY X/Y LOCATION EVERY ~0.5 SECONDS 



		if (newSoundMakingObjectScript.myCollision = true) {

			//ERROrS: It's not seeing *this* collision && destroying ENTIRE game object. 

			//StartCoroutine (instantiateTheBalls ()); 
			// DESTROY OBJECT AFTER
			//transform.position = Vector3.Lerp (startPosition, endPosition, 1f); 
		
			Destroy (ballClone, 3f); 


		}

	}


}
