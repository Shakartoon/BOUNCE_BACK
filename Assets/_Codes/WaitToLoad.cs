using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WaitToLoad : MonoBehaviour
{
	public bool enableObject, enableRigidbody, FadeIn;
	
	public float timeToEnableGameObject, timeToEnableRigidbody, timeToFadeIn;
	public Color newColor; 
	
	private float time; 
	private Rigidbody2D myRB;
	private SpriteRenderer mySR; 
	
	void Start ()
	{
		if (enableRigidbody)
		{
			myRB.isKinematic = true;

		}

		if (FadeIn)
		{
			mySR = gameObject.GetComponent<SpriteRenderer>(); 

		}

		if (enableObject)
		{
			gameObject.SetActive(false);


		}
	}

	void FixedUpdate()
	{
		
		time = time + Time.deltaTime;
		Debug.Log(time);


		if (enableObject)
		{		
			if(time >= timeToEnableGameObject)
			{
				Debug.Log("shdwork");
				gameObject.SetActive(true);
			}
		}

		if (FadeIn)
		{
			if(time >= timeToFadeIn)
			{
				mySR.DOColor(newColor, timeToFadeIn);
			}
		}
		
		if (enableRigidbody)
		{
			if (time >= timeToEnableRigidbody)
			{
				myRB.isKinematic = false;
			}
			
		}
	}


}
