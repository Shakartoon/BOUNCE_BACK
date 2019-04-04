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
	public float Rotation;

	void Start()
	{
		StartCoroutine(Wait()); //This co-routine isn't working. 
	}

	IEnumerator Wait()
	{
		Vector3 center = transform.position;
		for (int i = 0; i < numObjects; i++)
		{
			int a = i * 360 / numObjects;
			Vector3 pos = RandomCircle(center, a - transform.eulerAngles.z);
			Instantiate(prefab, pos, Quaternion.identity, transform);
			yield return new WaitForSeconds(0.2f);
		}

		yield return null;
	}
	
	Vector3 RandomCircle(Vector3 center, float a)
	{
		Vector3 pos;
		pos.x = center.x + _radius * Mathf.Sin(a * Mathf.Deg2Rad);
		pos.y = center.y + _radius * Mathf.Cos(a * Mathf.Deg2Rad);
		pos.z = center.z;
		return pos;
	}

	void Update()
	{
		transform.eulerAngles += new Vector3(0, 0, Rotation);
	}
} 