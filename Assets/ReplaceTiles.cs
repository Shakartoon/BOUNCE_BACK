using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ReplaceTiles : MonoBehaviour
{
	[SerializeField] public GameObject objectToDestroy; 
	[SerializeField] public Transform target;
	[SerializeField] public float speed;
	[SerializeField] public float timeToStart; 
	private float time; 
	
	void Update ()
	{
		
		time += Time.deltaTime; 
		if(time > timeToStart)
		{
			transform.position = Vector3.MoveTowards(transform.position, target.position, speed);
		}
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			Destroy(objectToDestroy);
			Debug.Log("Didyou");
		}
		
	}
}
