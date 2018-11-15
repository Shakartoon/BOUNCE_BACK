using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flick : MonoBehaviour {

    public SpringJoint2D spring;
    public mouseoverselect mouseOver;
    public float springOffsetx;
    public float springOffsety;
	public Rigidbody2D ballRigidBody; 


	public float nextActionTime = 1;
	public float period = 1f; 


	// Use this for initialization
	void Start () {
        spring = this.gameObject.GetComponent<SpringJoint2D>();
        spring.connectedAnchor = gameObject.transform.position;
		ballRigidBody = gameObject.GetComponent<Rigidbody2D> (); 

	//	InvokeRepeating ("GravityScale", 1.0f, .3f); 
	}
	

//	void GravityScale() {
//		ballRigidBody.gravityScale = 0; 
//	}

	void Update () {

        if (mouseOver.mouseIsover == true){
            spring.enabled = true; 
			ballRigidBody.gravityScale = 0; 
        }
        else if (mouseOver.mouseIsover == false)
        {
            spring.enabled = false;
			ballRigidBody.gravityScale = 1; 

        }
        if (spring.enabled == true)
        {
            Vector2 cursorPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            spring.connectedAnchor = cursorPosition; //+ new Vector2 (springOffsetx, springOffsety);
        }			
    }
}
