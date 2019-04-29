using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyMeets : MonoBehaviour
{

	public GameObject mom; 
	private Vector3 velocity = Vector3.zero;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{ 
			
		Vector3 dadTargetPosition = new Vector3(-1.5f, 0, 0);
		transform.position = Vector3.SmoothDamp(transform.position, dadTargetPosition, ref velocity, 2);
		
		Vector3 momTargetPosition = new Vector3(-1f, 0, 0);
		transform.position = Vector3.SmoothDamp(transform.position, momTargetPosition, ref velocity, 2);

		
		//transform.position = Vector3.Lerp(new Vector3(-34, -4, 0), new Vector3(0, 0, 0), 10f) * Time.deltaTime; 
		//mom.transform.position = Vector3.Lerp(new Vector3(34, -4, 0), new Vector3(0, 0, 0), 10f) * Time.deltaTime;
		
		//transform.position = Vector3.right * Time.deltaTime / 5f; 	
		//mom.transform.position = Vector3.left * Time.deltaTime / 5f; 
		
	}

	private void OnCollisionEnter2D(Collision2D other)
	{

		if (other.gameObject == mom)
		{
			Debug.Log("mama");
		}
	}
}
