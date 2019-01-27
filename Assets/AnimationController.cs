using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationController : MonoBehaviour
{

	public GameObject firstCircle;
	public Transform target; 
	
	
	
	private float counter = 0f; 
	
	void Start () {
		
	}

	//NEED to find a more efficient way to do this 
	void OnCollisionEnter2D (Collision2D col)
	{

		if (col.gameObject.CompareTag("Ball"))
		{
			counter++; 

		}
		
	}
	
	void Update () {

		float speed = Random.Range(0.5f, 5f); 
		float step = speed * Time.deltaTime;

		if (counter == 1)
		{
			Debug.Log("Hello");
			firstCircle.transform.position = Vector3.MoveTowards (transform.position, target.position, step);

		}

		if (counter == 2)
		{
			Instantiate(this, new Vector3(0.79f, 0.75f, 0), Quaternion.identity); 

		}
		
		
	}

	
}
