using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjectsFromFixedPoint : MonoBehaviour
{

	public float spawnTimer = 2;
	public float time; 
	
	public GameObject myObject;
	public GameObject object2; 
	private GameObject objectClone;
	private Vector3 frog;
	private Rigidbody rb; 
	
	void Start ()
	{

		rb = object2.GetComponent<Rigidbody>(); 
		InvokeRepeating ("SpawnObject", 3, 3);

	}


	void SpawnObject()
	{
		
		Instantiate(object2, transform.position, transform.rotation);

	}
	
	void Update ()
	{
		
		/* 
		frog += Vector3.down;
		
		Instantiate(myObject, transform.position + frog, Quaternion.identity); 
		//myObject.transform.position = Vector3.down * Time.time;
		*/
		
		/* 

		spawnTimer -= Time.deltaTime;
		time += Time.deltaTime; 
		
		if (time >= 2) {

			objectClone = Instantiate(object2, transform.position, transform.rotation);
			rb.velocity = transform.TransformDirection(Vector3.down);
			time = 0; 
		}
		*/ 
		
		//Instantiating a row - if i put in update, then instantiate SO MUCH 
		for (int i = 0; i < 10; i++)
		{
			Instantiate(myObject, new Vector3(i * 2.0F, i * 2.0F, 0), Quaternion.identity);
		}

	}
}
