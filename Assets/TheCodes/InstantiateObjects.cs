using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateObjects : MonoBehaviour {

	public GameObject circlePrefab;  
	public GameObject[] respawns;

	// Use this for initialization
	void Start () {

	//	if (respawns == null)
	//		respawns = GameObject.FindGameObjectsWithTag ("Respawn"); 
			
	}
	
	// Update is called once per frame
	void Update () {


	} 

	void OnMouseOver () { 

		if (Input.GetMouseButtonDown (0)) {

			respawns = GameObject.FindGameObjectsWithTag ("CircleRespawn"); 
		
			foreach (GameObject respawn in respawns) { 
				
				Instantiate (circlePrefab, respawn.transform.position, respawn.transform.rotation); 

			} 
				
		} 

		if (Input.GetMouseButtonDown (0)) {

			respawns = GameObject.FindGameObjectsWithTag ("BlockRespawn"); 

			foreach (GameObject respawn in respawns) { 

				Instantiate (circlePrefab, respawn.transform.position, respawn.transform.rotation); 

			} 

		} 
	}

	
}
