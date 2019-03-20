using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathFollow : MonoBehaviour
{


	[SerializeField] private Transform[] target;
	[SerializeField] private float speed;
	private int current; 
	
	void Start () {
		
	}
	
	void Update () {
		//move until you reach the current object/ way point 
		if (transform.position != target[current].position)
		{
			Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
			GetComponent<Rigidbody2D>().MovePosition(pos);

		}
		//Object / way point reached, move to the next object 
		else current = (current + 1) % target.Length; 
		
	}
}
