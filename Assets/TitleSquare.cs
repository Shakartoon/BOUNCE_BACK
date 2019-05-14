using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleSquare : MonoBehaviour
{
	private SpriteRenderer sr;
	// Use this for initialization
	void Start ()
	{
		sr = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if (sr.color == Color.black)
		{
			GetComponent<Collider2D>().enabled = false;
			sr.enabled = false;

		}
	}
}
