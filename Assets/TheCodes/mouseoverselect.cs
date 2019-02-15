using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseoverselect : MonoBehaviour {

	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;
    public bool mouseIsover = false;
	private Rigidbody2D rb2d;
	public bool isFrozen = false;
	public GameObject greenCircle;
    public DragBall ballDrag;

	private AudioSource myAS; 

	// Use this for initialization
	void Start ()
	{
		myAS = GetComponent<AudioSource>(); 
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
	    myAS.Play();
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = false;
		m.enabled = false; 

	
	}

}
