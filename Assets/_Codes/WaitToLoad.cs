using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WaitToLoad : MonoBehaviour
{
	
	public bool enableObject; 
	public bool enableRigidbody;
	public bool FadeIn; 
	
	public GameObject objectToEnable1, objectToEnable2;
	public float timeToEnableGameObject, timeToEnableRigidbody, timeToFadeIn;
	public Color object1FadeInColor, object2FadeInColor; 
	
	private float time; 
	private Rigidbody2D my_rb;
	private SpriteRenderer object1SR, object2SR; 
	
	void Start ()
	{
		if (enableRigidbody)
		{
			my_rb = GetComponent<Rigidbody2D>();
			my_rb.isKinematic = true; 
		}

		if (FadeIn)
		{
			object1SR = objectToEnable1.GetComponent<SpriteRenderer>(); 
			object2SR = objectToEnable2.GetComponent<SpriteRenderer>(); 
		}

		if (enableObject)
		{
			objectToEnable1.SetActive(false);
			objectToEnable2.SetActive(false);

		}
	}

	void Update()
	{
		time += Time.deltaTime;

		if (enableObject)
		{		
			if(time >= timeToEnableGameObject)
			{
				objectToEnable1.SetActive(true);
				objectToEnable2.SetActive(true);
			}
		}

		if (FadeIn)
		{
			if(time >= timeToFadeIn)
			{
				object1SR.DOColor(object1FadeInColor, timeToFadeIn);
				object2SR.DOColor(object2FadeInColor, timeToFadeIn);
			}

		}
		
		if (enableRigidbody)
		{
			if (time >= timeToEnableRigidbody)
			{
				my_rb.isKinematic = false; 
			}
			
		}
	}


}
