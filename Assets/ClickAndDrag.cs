using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine; 
	
public class ClickAndDrag : MonoBehaviour
{

	private Vector3 offset;
	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;


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

	void OnMouseUp()
	{

	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			//DOShakePosition(float duration, float/Vector3 strength, int vibrato, float randomness, bool snapping, bool fadeOut)
			transform.DOShakeScale(0.5f, new Vector2(0.2f, 0.2f), 2, 1, false); 
			transform.DOMove(new Vector2(Random.Range(-0.5f, 0.5f),Random.Range(-0.5f, 0.5f)), 1);
			//transform.DOScale(float/Vector3 to, float duration); 
		}
		
	}
}
