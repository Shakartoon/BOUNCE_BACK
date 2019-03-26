using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine; 
	
public class ClickAndDrag : MonoBehaviour
{

	//***NEEDS FIXING*** 
	
	private Vector3 offset;
	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;
	private Vector3 originalScale;
	private bool onScreen; 

	void Start()
	{
		originalScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		
	}

	void OnMouseDown()
	{

		offset = gameObject.transform.position -
		         Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		
		
		//Camera.main.WorldToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		//Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed / 5);
		
		transform.rotation = Quaternion.Euler(Mathf.Sin(Time.realtimeSinceStartup) * 3f, Mathf.Sin(Time.realtimeSinceStartup) * 3f, Mathf.Sin(Time.realtimeSinceStartup) * 3f); 

	}

	void OnMouseDrag()
	{
		
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;

		
	}


	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			//DOShakePosition(float duration, float/Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut)
			transform.DOShakeScale(0.3f, new Vector2(0.1f, 0.1f), 2, 1, false); 
			//transform.DOMove(new Vector2(0.1f, 0.1f), 1);
			//transform.DOScale(float/Vector3 to, float duration); 
		}
	}

	void OnCollisionExit2D()
	{
		transform.localScale = originalScale; 
		
	}

	void Update()
	{
		Vector3 screenPoint = Camera.main.WorldToViewportPoint(gameObject.transform.position);
		onScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 && screenPoint.y < 1;
		
		//NEED TO FIX 
		// If game object is outside of camera's field of view, recenter it to the middle
		if (transform.position.y < Screen.height)
		{
			onScreen = true; 
		}
	
	}
}
