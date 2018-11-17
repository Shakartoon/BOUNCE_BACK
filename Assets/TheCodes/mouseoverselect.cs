using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseoverselect : MonoBehaviour {

	private Vector3 mousePosition; 
	public float moveSpeed = 0.5f;
    public bool mouseIsover = false;
    public Rigidbody2D rb2d;
    public bool isFrozen = false;
	public GameObject greenCircle;
    public DragBall ballDrag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
    }

	void OnMouseDown() { 

		Debug.Log ("Did this work?"); 
		mousePosition = Input.mousePosition;
		mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
		transform.position = Vector2.Lerp(transform.position, mousePosition, moveSpeed / 5);
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = true;

        //if (Input.GetKeyDown(KeyCode.Space) && (isFrozen == true))
        //{
        //    rb2d.simulated = true;
        //    isFrozen = false;
        //}


        //Enable the two finger thing? 

        // Find the mesh renderer "greenCricle1" and enable. DID IT BITCH 


        // if (OnMouseOver == true) {

        //Allow Double Mouse movement to happen 
        // If not, do not allow 

        // } 
    }

    void OnMouseUp () { 
		Debug.Log ("Yes it did"); 
		SpriteRenderer m = greenCircle.GetComponent<SpriteRenderer> ();
        mouseIsover = false;
		m.enabled = false; 

		// if two fingers, move 
	
	}
    void OnMouseOver()
    {

        if ((Input.GetKeyDown(KeyCode.Space) && (this.isFrozen == false) && (this.ballDrag.beingDragged == false)))
        {
            this.rb2d.constraints = RigidbodyConstraints2D.FreezePositionX | RigidbodyConstraints2D.FreezePositionY; //Makes rigidbody freeze x and y axis
            this.isFrozen = true;
        }

        else if (Input.GetKeyDown(KeyCode.Space) && (this.isFrozen == true))
        {
            this.rb2d.constraints = RigidbodyConstraints2D.None; //Remove the restraints
            this.isFrozen = false;
        }

    }
}
