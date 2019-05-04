using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine; 
	
public class BallMovementScript : MonoBehaviour
{

	//***NEEDS FIXING*** 
	
	private Vector3 offset;
	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;
	private Vector3 originalScale;
	private bool onScreen;
	private Rigidbody2D myRB;
	public float magnitude = 1000f;
	public float myDrag = 20f;

	private bool OnCollisionEnter;
	private bool OnCollisionExit;

	//For Papiros Level Only 
	public int PapirosCollisionCount;
	public GameObject Reaction;
	public GameObject ReactionSprite1; 
	public GameObject ReactionSprite12; 

	void Start()
	{
		//originalScale = new Vector3(transform.localScale.x, transform.localScale.y, transform.localScale.z);
		myRB = GetComponent<Rigidbody2D>();
		
		Reaction.SetActive(false);
	}

	void OnMouseDown()
	{
		offset = gameObject.transform.position -
		         Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		myRB.drag = myDrag; 
		//Camera.main.WorldToViewportPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));
		//Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f));

		//mousePosition = Input.mousePosition;
		//mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		//transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed / 5);

		//commented temporarily for simplicity
		//transform.rotation = Quaternion.Euler(Mathf.Sin(Time.realtimeSinceStartup) * 3f, Mathf.Sin(Time.realtimeSinceStartup) * 3f, Mathf.Sin(Time.realtimeSinceStartup) * 3f); 
		//set the drag value high / on mouse down lower it to 0 
	}

	void OnMouseDrag()
	{
		
		Vector3 newPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10.0f);
		Vector3 projectedMousePos = Camera.main.ScreenToWorldPoint(newPosition);
		//transform.position = Camera.main.ScreenToWorldPoint(newPosition) + offset;
		//move to the position with forceeeeeee
		myRB.AddForce(Vector3.Normalize(projectedMousePos - transform.position) * magnitude, ForceMode2D.Force); //reduce to direction
		//apply drag to tell it to stop 
		//drag increases faster you go //higher your force and higher drag you get equilibrium 
		
	}

	void OnMouseUp()
	{

		myRB.drag = 0; 
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		
		if (col.gameObject.CompareTag("SoundMakingObject"))
		{
			OnCollisionEnter = true; 
		}
		
		//This is for the PapirosPoem Level Only 
		if (col.gameObject.CompareTag("PapirosObject"))
		{
			Debug.Log(PapirosCollisionCount);
			PapirosCollisionCount++; 
			
			Reaction.SetActive(true);
			
		}
	
	}

	void OnCollisionExit2D()
	{
		OnCollisionExit = true; 	

	}

	void Update()
	{
		Vector3 screenPoint = Camera.main.WorldToViewportPoint(gameObject.transform.position);
		onScreen = screenPoint.z > 0 && screenPoint.x > 0 && screenPoint.x < 1 && screenPoint.y > 0 &&
		           screenPoint.y < 1;

		if (OnCollisionEnter)
		{

		}

	     //NEED TO FIX 
		// If game object is outside of camera's field of view, recenter it to the middle
		if (transform.position.y < Screen.height)
		{
			onScreen = true;
		}

		if (OnCollisionExit)
		{

		}
		
	}
}
