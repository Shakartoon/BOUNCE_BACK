using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class CameraRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	void Update ()
	{

		transform.DORotate(new Vector3(0, 0, 0), 2); 
	}
}
