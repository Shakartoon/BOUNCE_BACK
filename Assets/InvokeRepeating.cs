using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{

	public Rigidbody2D objectToInstantiate;  
	
	void Start () {
		
	
		InvokeRepeating("LaunchObject", 2.0f, 2f);
		
	}
	
	void LaunchObject ()
	{
		Instantiate(objectToInstantiate, new Vector3(8.21f, 8.98f, 0), Quaternion.identity);
		Instantiate(objectToInstantiate, new Vector3 (-8.360003f, 8.98f, 0), Quaternion.identity);
		Instantiate(objectToInstantiate, new Vector3(-11.96f, 8.009999f, 0), Quaternion.identity);

		
		//Instantiate(myObjects[i], new Vector3(8.21f, Random.Range(7, 8.98f), 0), Quaternion.identity);
		//GameObject instObjects
		//Rigidbody2D instance = Instantiate(objectToInstantiate, new Vector3(8.21f, Random.Range(7, 8.98f), 0), Quaternion.identity);
		//instance.velocity = Random.insideUnitSphere * 5; 
	}
}
