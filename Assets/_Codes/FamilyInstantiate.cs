using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FamilyInstantiate : MonoBehaviour
{
	private float timer;
	public GameObject instantiateMe;
	private GameObject theClone;
	private bool firstInst;
	private bool secondInst; 
	
	
	void Start () {


		
	}

	private void FixedUpdate()
	{
		if (firstInst)
		{
			theClone = Instantiate(instantiateMe, instantiateMe.transform.position, Quaternion.identity);
			theClone.transform.position = new Vector3(10, 5, 0);

		}
	}

	void Update ()
	{

		timer += Time.deltaTime;

		if (timer >= 3f)
		{
			firstInst = true;

		}

	}
}
