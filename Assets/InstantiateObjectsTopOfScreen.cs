using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjectsTopOfScreen : MonoBehaviour {

	public GameObject objectToInstantiate;
	private GameObject newObject; 
	
	

	void Update()
	{
	
		//newObject = Instantiate(objectToInstantiate, new Vector3(Random.Range(-17f, 17f), Random.Range(11f, 20f), Random.Range(0, -5)), Quaternion.identity);
		newObject = Instantiate(objectToInstantiate, new Vector3(-10f, 17f, 0f), Quaternion.identity);
		newObject.transform.Translate(0, 0, 1);
	
	
		if (newObject.transform.position.y < -5f || objectToInstantiate.transform.position.y < -5f)
		{
			
			Destroy(newObject);
			Destroy(objectToInstantiate);

		}

	}
	
	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("Ball"))
		{
			Debug.Log(">");
			Destroy(newObject);
		}
		
	}

}
