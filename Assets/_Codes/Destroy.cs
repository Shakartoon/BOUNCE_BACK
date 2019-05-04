using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class Destroy : MonoBehaviour
{
	public bool justDestroy;
	public bool fade;
	public float timeToKill;
	public float fadeTime;
	public Color newColor; 

	private SpriteRenderer SR; 
	
	void Start ()
	{

		SR = GetComponent<SpriteRenderer>();

	}
	
	void Update () {
		
		if(justDestroy)
		{
			Destroy(gameObject, timeToKill);
		}

		if (fade)
		{
			SR.DOColor(newColor, fadeTime); 

		}
	}
}
