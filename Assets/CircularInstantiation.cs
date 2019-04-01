using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircularInstantiation : MonoBehaviour
{
	//NEEDS CO-ROUTINE FIXING TO LOAD ONE AT A TIME
	int numObjects = 12;
	public GameObject prefab;
	public float _radius = 8f;
	private float timer, time; 

	void Start()
	{
		Vector3 center = transform.position;
		for (int i = 0; i < numObjects; i++)
		{
			int a = i * 30;
			Vector3 pos = RandomCircle(center, 1.0f, a);
			StartCoroutine(Wait()); //This co-routine isn't working. 
			Instantiate(prefab, pos, Quaternion.identity);
		}
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(1);
		yield return null; 
	}
	
	Vector3 RandomCircle(Vector3 center, float radius, int a)
	{
		Debug.Log(a);
		float ang = a;
		Vector3 pos;
		radius = _radius; 
		pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
		pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
		pos.z = center.z;
		return pos;
	}
} 