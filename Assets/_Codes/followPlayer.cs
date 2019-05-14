using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{


	public GameObject Player;
	public float movementSpeed = 4;
	private Vector3 moveDirection;
	private Vector3 thing;
	private Vector3 offset; 
	
	public bool threat;

	void Start()
	{
	}
	
	void Update()
	{
		//transform.LookAt(Player.transform);
		//thing = transform.position + offset; 
		//offset = new Vector3(Random.Range(4, 10f), Random.Range(4, 10f), 0);
		moveDirection = Vector3.Normalize(Player.transform.position - transform.position + offset); 
		transform.position += moveDirection * movementSpeed * Time.deltaTime;

		if (threat)
		{
			//fade player value
		}
		
	}

}
