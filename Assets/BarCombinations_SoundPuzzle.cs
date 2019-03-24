using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class BarCombinations_SoundPuzzle : MonoBehaviour
{
	private GameObject thing; 
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		

		//transform.DOMove(Vector2 to, float duration, bool snapping)
	}

	void OnCollisionEnter2D(Collision2D col)
	{

		if (col.gameObject == thing)
		{
			{

			}
		}
	}
}
