using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class scaleTransform : MonoBehaviour
{
	private float scale = 1; 
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		/* 
		transform.DOScale(new Vector3(-40, -40, -40), 5);
		
		if (transform.localScale.x >= -40)
		{
			//transform.DOScale(new Vector3(-0.9f, -0.9f, -0.9f), 5);

		}
		*/


		scale += Time.deltaTime * 5f; 
		transform.localScale = new Vector3(scale++, scale++, scale++);
		if (transform.localScale.x >= -15)
		{
			Debug.Log("Youre right");
			transform.localScale = new Vector3(scale--, scale--, scale--);

		}



	}
}
