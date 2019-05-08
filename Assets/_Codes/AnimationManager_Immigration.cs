using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class AnimationManager_Immigration : MonoBehaviour
{

	public GameObject player2;
	//private Animator player2Animator; 
	
	void Start ()
	{

		//player2Animator = player2.GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update ()
	{

		player2.transform.position = Vector3.Lerp(new Vector3(24.1f, -10f, -15.8f), new Vector3(24f, -11f, 10.1f), 2f);  
	

	}
}
