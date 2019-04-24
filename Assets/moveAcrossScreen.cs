using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAcrossScreen : MonoBehaviour
{

	public bool moveAcross; 
	public float speed; 
	public float xtranslate; 
	public float ytranslate; 
	public float ztranslate;
	
	public float xtranslate2;
	public float ytranslate2;
	public float ztranslate2; 
	public float maxPosX; 
	public float maxPosY;

	public bool loop;
	public float maxPosition = 0.5f; 
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update()
	{
		if(moveAcross)
		{
			transform.Translate(new Vector3(xtranslate, ytranslate, ztranslate) * speed * Time.deltaTime);

			if (transform.localPosition.x >= maxPosX || transform.localPosition.y > maxPosY)
			{

				transform.Translate(new Vector3(xtranslate2, ytranslate2, ztranslate2));
			}
		}
		if (loop)
		{
			Vector3 startPosition = transform.position;
			transform.position = new Vector3(transform.position.x, startPosition.y + Mathf.Sin(Time.time * maxPosition), transform.position.z);
		}
	} 
}
