using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClickScaleEffect : MonoBehaviour
{
	public GameObject object2; 
	void Start () {
		
	}

	void OnMouseDown()
	{

		transform.localScale += new Vector3(0.1F / 2f, 0, 0);
		
	} 

}
