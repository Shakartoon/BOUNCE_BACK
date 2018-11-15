using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xButtonClick : MonoBehaviour {

	public GameObject xButton; 
	public GameObject menuBox; 

	void Start () {
		
	}
	
	void OnMouseOver () {

		if (Input.GetMouseButtonDown (0)) {

			menuBox.SetActive (false); 
		
		} 
		
	}
}
