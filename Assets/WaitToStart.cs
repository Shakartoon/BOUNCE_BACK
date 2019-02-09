using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitToStart : MonoBehaviour
{
	private Rigidbody2D my_rb;

	void Start ()
	{

		my_rb = GetComponent<Rigidbody2D>();
		my_rb.isKinematic = true; 

	}

	IEnumerator Wait()
	{

		yield return new WaitForSeconds(1.5f);
		my_rb.isKinematic = false; 
	}

	void Update()
	{
		StartCoroutine(Wait()); 

	}

}
