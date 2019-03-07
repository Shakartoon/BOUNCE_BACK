using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawVectors : MonoBehaviour
{

	public GameObject objectA, objectB; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnDrawGizmos() //A Reserved Function Names (Like Start and Update and Fixed Update) & Only 4 U 
	{
		//A way to help you visualize things in game 
		
		//U can draw cubes and spheres and stuff. Lines are useful. 
		//Gizmos.DrawCube(Vector3.zero, Vector3.one); // a one length cube at origin 
		Gizmos.color = Color.red; 
		Gizmos.DrawLine(this.transform.position, objectA.transform.position); //Vector3 from and two //transform.position - where you're drawing stuff from 
		Gizmos.color = Color.blue; 
		Gizmos.DrawLine(this.transform.position, objectB.transform.position);
		Gizmos.color = new Color(1f, 1f, 0); 
		Gizmos.DrawLine(objectA.transform.position , objectA.transform.position + objectA.transform.forward); //drawing a line from object's a's position to it's "forward" 
		Gizmos.color = Color.green;
		//Draw object b's facing 
		Gizmos.DrawRay(objectB.transform.position, objectB.transform.position + objectB.transform.forward); 
		
		Debug.Log(Vector3.Dot(objectA.transform.forward, objectA.transform.forward));

		Gizmos.color = new Color(0f, 0f, 0f);
		//Vector3.dot will yeild answer between -1 and 1 
		
		Vector3 dotproductvector = Vector3.up * Vector3.Dot(objectA.transform.forward, objectB.transform.forward); //0, 1, 0 
		Gizmos.DrawLine(this.transform.position, dotproductvector); 

		//Dot product of A & Bs position 
		Gizmos.color = new Color(0f, 1f, 0f); 
		Vector3 positiondotproduct = Vector3.up * Vector3.Dot(objectA.transform.position.normalized, objectB.transform.position.normalized); //0, 1, 0 
		Gizmos.DrawLine(this.transform.position, this.transform.position + positiondotproduct); 

	}
	
}
