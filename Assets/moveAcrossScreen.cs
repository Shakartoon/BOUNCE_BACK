using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAcrossScreen : MonoBehaviour
{

	public float speed; 
	public float xtranslate; 
	public float ytranslate; 
	public float ztranslate;
	
	public float xtranslate2;
	public float ytranslate2;
	public float ztranslate2; 
	public float maxPosX; 
	public float maxPosY;

	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {

			transform.Translate(new Vector3(xtranslate, ytranslate, ztranslate) * speed * Time.deltaTime);

			if (transform.localPosition.x >= maxPosX || transform.localPosition.y > maxPosY)
			{

				transform.Translate(new Vector3(xtranslate2, ytranslate2, ztranslate2));
		    }

	}
	
}
