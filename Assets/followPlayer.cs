using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{


	public GameObject Player;
	public float movementSpeed = 4;

	public bool threat; 
	
	void Update()
	{
		transform.LookAt(Player.transform);
		transform.position += transform.forward * movementSpeed * Time.deltaTime;

		if (threat)
		{
			//fade player value
		}
		
	}

}
