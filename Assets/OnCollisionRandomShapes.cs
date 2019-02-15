using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionRandomShapes : MonoBehaviour
{
	public tempCollision tempCollision;

	public Transform shape;

	void Start()
	{

		tempCollision.collisionOccured = false;
	}

	void CreateObject()
	{

		Transform t = Instantiate(shape);
		t.localPosition = Random.insideUnitSphere * 10f;
		t.localScale = Vector3.one * Random.Range(0.1f, 15f);
		t.localRotation = Random.rotation;

	}

	void Update() {
		
		if (tempCollision.collisionOccured)
		{
			CreateObject();

		}
	}

}
