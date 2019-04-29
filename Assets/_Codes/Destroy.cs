using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

	public float timeToKill; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		Destroy(gameObject, timeToKill);		
	}
}
