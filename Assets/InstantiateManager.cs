using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateManager : MonoBehaviour
{

	public GameObject myBall;
	private GameObject instantiatedBall; 
	RaycastHit beatHit; 
 
	void Update() {

		if (Input.GetMouseButtonDown(0))
		{
			//initializing a vector3 for the mouse position 
			Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1);
			
			//another vector3 for Camera 
			Vector3 worldPosition;
			//if ray doesn't hit anything it uses screen to world point- i don't know what the fuck that means 
			Ray ray = Camera.main.ScreenPointToRay(mousePosition);
			RaycastHit hit;
			
			if(Physics.Raycast(ray, out hit, 1000f)) {
				worldPosition = hit.point;
			}
			else
			{
				worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);
			}				
			
			//so instead of instantiating at mousePosition we instantiate at worldPosition 
			bool clickedScreen = true; 
			instantiatedBall = Instantiate(myBall, worldPosition, Quaternion.identity);

			
			
			if (Physics.Raycast(ray, out hit) && Input.GetMouseButtonDown(0))
			{
				if (hit.transform.gameObject == instantiatedBall || hit.transform.gameObject == myBall)
				//if (hit.collider.gameObject == instantiatedBall || hit.collider.gameObject == myBall || hit.collider.gameObject.name == "whiteball(Clone)")
				{
					Debug.Log("Love");
				}
			}

		}
	
	}
}
