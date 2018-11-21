using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickToActivateImage : MonoBehaviour {

	public GameObject barOutline;
	public SpriteRenderer barSprite; 

	void Start () {

	    barSprite = GetComponent<SpriteRenderer> (); 
		barSprite.enabled = false; 
	}
	
	// Update is called once per frame
	void OnMouseDown() { 

		barSprite.enabled = true; 

		
	}
}
