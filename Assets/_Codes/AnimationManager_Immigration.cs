using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager_Immigration : MonoBehaviour
{

	public GameObject player2;
	private Animator player2Animator; 
	
	void Start ()
	{

		player2Animator = player2.GetComponent<Animator>(); 
	}
	
	// Update is called once per frame
	void Update () {

		if (player2Animator.GetCurrentAnimatorStateInfo(0).IsName("Finished"))
		{
			player2Animator.enabled = false; 
		}
		
	}
}
