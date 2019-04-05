using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{


	public GameObject Player;
	public float movementSpeed = 4;
	private Vector3 moveDirection; 
	
	
	public bool threat; 
	
	void Update()
	{
		//transform.LookAt(Player.transform);
		moveDirection = Vector3.Normalize(Player.transform.position - transform.position); 
		transform.position += moveDirection * movementSpeed * Time.deltaTime;

		if (threat)
		{
			//fade player value
		}
		
	}

}
