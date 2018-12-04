using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveTowards : MonoBehaviour {

	public Transform target; 
	public float speed; 
	public float ballMoveSpeed = 0.5f;
	private Vector3 ballMousePosition; 
	public GameObject ball; 


	// Use this for initialization
	void Start () {
		
	}
	
	//IEnumerator SlowDown(){} 

	void Update () {
		
		// The step size is equal to speed times frame time.

		//Here there can be different things movng toward player at short ammounts of time 
		float speed = Random.Range(0.5f, 5f); 
		float step = speed * Time.deltaTime;

		float rotateSpeed = 10f; 
		float rotateStep = rotateSpeed * Time.deltaTime;

		// Move our position a step closer to the target.

		//4.04 , 2.05 // 

		transform.position = Vector3.MoveTowards (transform.position, target.position, step);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, target.rotation, rotateStep);

		//The target direction of the object is set to the target position minus its own position. 
		//To get the position you want, subtract your position from the position of object. 
	
		//Vector3 targetDirection = target.position - transform.position; 

		//What I Assumed: 
		//Vector3 newDirection = Vector3.RotateTowards (transform.Rotate, target.rotation, ); 
		//What is real:

		//Vector3 newDirection = Vector3.RotateTowards (transform.forward, targetDirection, step, speed); 
		//transform.rotation = Quaternion.LookRotation(newDirection);

		//Debug.DrawRay(transform.position, newDirection, Color.red);

	} 

	void OnCollisionEnter2D (Collision2D col)
	{ 

		if (col.gameObject.tag == "Ball") {
			ball.transform.position = Vector2.Lerp(transform.position, ballMousePosition, ballMoveSpeed / 5f);
		}
	}
}
