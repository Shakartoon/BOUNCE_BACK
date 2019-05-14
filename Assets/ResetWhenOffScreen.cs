using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetWhenOffScreen : MonoBehaviour
{
	private Camera cam;

	private Vector3 defPos;
	// Use this for initialization
	void Start () {
		cam = Camera.main;
		defPos = transform.position;
	}
	
	// Update is called once per frame
	void Update ()
	{
		Vector2 pt = cam.WorldToViewportPoint(transform.position);
		if (pt.x < 0 || pt.x > 1 || pt.y < 0 || pt.y > 1)
			transform.position = defPos;
	}
}
