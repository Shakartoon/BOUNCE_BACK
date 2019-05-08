using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{

	public GameObject UnitManager; 
	public Vector2 location = Vector2.zero;
	public Vector2 Velocity;
	private Vector2 goalPos = Vector2.zero;
	private Vector2 currentForce; 
	
	void Start () {
		
		Velocity = new Vector2(Random.Range(0.1f, 0.1f), Random.Range(0.1f, 0.1f));
		location = new Vector2(gameObject.transform.position.x, 10);
		
	}

	Vector2 seek(Vector2 target)
	{
		return (target - location); 
	}
		
	void applyForce(Vector2 f)
	{
		Vector3 force = new Vector3(f.x, f.y, 10);
		this.GetComponent<Rigidbody2D>().AddForce(force);
		Debug.DrawRay(this.transform.position, force, Color.white);
		
	}

	void flock()
	{
		location = transform.position;
		Velocity = GetComponent<Rigidbody2D>().velocity;

		Vector2 gl;
		gl = seek(goalPos);
		currentForce = gl;
		currentForce = currentForce.normalized; 
		
		applyForce(currentForce);
	}

	void Update()
	{
		flock();
		goalPos = UnitManager.transform.position; 
	}
}
