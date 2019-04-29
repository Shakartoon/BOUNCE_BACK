using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineBars : MonoBehaviour
{
	private GameObject collidedObject = null;
	
	private GameObject coveredObject = null;
	

	void Update()
	{
		if (collidedObject != null)
		{
			// snapping and covering
			if (Input.GetMouseButtonUp(0))
			{

				coveredObject = collidedObject;
				
				// Snap this one to the position 
				transform.position = collidedObject.transform.position;
				transform.rotation = collidedObject.transform.rotation;

				//Temporarily disable bottom game object / only 1 object running / when collision play new audio 

				foreach (Collider2D collider in collidedObject.GetComponents<Collider2D>())
				{
					collider.enabled = false;

					// THIS FOR MULTIPLE COLLIDER ON AN OBJECT: coveredObject.GetComponent<BoxCollider2D>().enabled = false;

				}
			}
		}
		
		
		if (coveredObject != null)
		{
		// move the covered object with this one
			coveredObject.transform.position = transform.position;
			coveredObject.transform.rotation = transform.rotation;
		}
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
		//ensures we only deal with two objects 
		//if it's not null means the object we're holding means it's not colliding with another one, we ignore the rest 
		if (coveredObject != null) 
			return;
		
		//literally means the object it just collided with
		collidedObject = other.gameObject;
	}

	private void OnTriggerExit2D(Collider2D other)
	{
		collidedObject = null;
	}
}
// check if object is attached, where you trigger the regular audio and instead of calling the one sound clip on the object itself also play the clip on the covered object
//coveredObject 
