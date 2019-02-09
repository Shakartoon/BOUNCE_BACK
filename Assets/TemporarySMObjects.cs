using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemporarySMObjects : MonoBehaviour
{
	private AudioSource AS;
	public bool CollisionHappened = false; 
	public bool _sparkleCollided;
	private Animator _anim;
	private bool allowDestroyingAssets;

	private RotateAroundButton buttonScript; 

	void Start ()
	{
		_sparkleCollided = false;
		allowDestroyingAssets = true; 
		_anim = GetComponent<Animator>(); 
		AS = GetComponent<AudioSource>();
		buttonScript.topRightQuadrant = false; 

	}

	public void DestroyImmediate(object gameObject, bool allowDestroyingAssets = false)
	{
	
	}

	
	void OnCollisionEnter2D(Collision2D collision)
	{
		if (collision.gameObject.CompareTag ("Ball")) {

			AS.Play ();
			_sparkleCollided = true; 
			_anim.SetBool("_sparkleCollided", true);
			allowDestroyingAssets = true; 
			//fuck! doesn't play because it's destroying itself 
			//Destroy(gameObject, 0.1f)
			CollisionHappened = true;

			if (buttonScript.topRightQuadrant)
			{
				AS.pitch = 0.5f; 

			}
			
		}
		
		else 
		
		{
			_anim.SetBool("_sparkleCollided", false);

		}
			
		
	}
}
