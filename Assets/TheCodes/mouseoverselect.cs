using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseoverselect : MonoBehaviour {

	
	public GameObject greenCircle;
	public float moveSpeed = 0.5f;

	private Vector3 mousePosition; 
	private Rigidbody2D rb2d;

	
	[HideInInspector] public bool mouseIsover;
	[HideInInspector] public bool isFrozen;

	void Start ()
	{
		greenCircle.SetActive(false);  

	}

	void OnMouseOver()
	{		
		greenCircle.SetActive(true);  
	}

	void OnMouseExit()
	{
		greenCircle.SetActive(false);  
	}
	
	void OnMouseDown() { 

		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed / 5);
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = true;
    }

    void OnMouseUp () { 
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = false;
		m.enabled = false; 

	
	}

}
