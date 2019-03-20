using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{


	public Transform target; 
	
	Vector3 tempVec3;

	void LateUpdate() {
		
		tempVec3.x = target.position.x;
		tempVec3.y = transform.position.y;
		tempVec3.z = transform.position.z;
		transform.position = tempVec3;
	}

}
