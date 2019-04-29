using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionColorAndDestroy : MonoBehaviour
{


	[SerializeField] Color originalColor = Color.white;
	[SerializeField] Color newColor = Color.blue;
	[SerializeField] private bool destroyOnCollision; 
	[SerializeField] float timeToDestroy; 
	[SerializeField] float colorLerpDuration; 

	private SpriteRenderer mySR; 
	
	void Start ()
	{
		mySR = GetComponent<SpriteRenderer>();
		mySR.color = originalColor; 

	}

	void OnCollisionEnter2D(Collision2D col)
	{
	
		float t = Mathf.PingPong(Time.time, colorLerpDuration) / colorLerpDuration;
		Color newColor = Color.Lerp(originalColor, this.newColor, t);

		if (col.gameObject.CompareTag("Ball"))
		{			
			if(destroyOnCollision)
			{
				Destroy(gameObject, timeToDestroy);
			}

			else
			{
				mySR.color = newColor; 

			}
		}
		
	}
	
	void OnCollisionExit2D(Collision2D me)
	{

		if (me.gameObject.CompareTag("Ball"))
		{
			mySR.color = originalColor; 
			float t = Mathf.PingPong(Time.time, colorLerpDuration) / colorLerpDuration;
			Color OG = Color.Lerp(this.newColor, originalColor, t);
			mySR.color = OG; 

		}
		
	}
	
}
