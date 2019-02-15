using System.Collections;
using System.Collections.Generic;
//using NUnit.Framework.Constraints;
using UnityEngine;

public class Drag : MonoBehaviour {

    private bool isRotating;
	
	private Vector3 screenPoint, offset; 
	
    private float degreesPerSec = 180f;

	public GameObject littleBalls; 
	
	//keetp track of init position 
	private Vector3 intialPosOfLittleBalls;
	public bool _colliderPressed;
	private SpriteRenderer SR; 

	private float timer = 0f; 
	
	public Color newColor; 

	void Start()
	{
		//InvokeRepeating ("ActivateLittleBalls", 1f, 2f); 
		SR = GetComponent<SpriteRenderer>(); 

	} 
//	void ActivateLittleBalls(){
//
//		littleBalls.SetActive(true); 
//	}
		
	void Update ()
	{
		//StartCoroutine(activatetheballs()); 

	}


	void OnMouseEnter()
	{
		SR.color = Color.red;
	} 

	void OnMouseOver(){
	    
	    SR.color = new Color (0, 0.4481132F, 0.4481132F, 0.5F); 
		
	    
        if (Input.GetMouseButton(1)){
	        
	        timer++;
            //float rotAmount = degreesPerSec * Time.deltaTime;
	        float rotAmount = degreesPerSec * Time.deltaTime * 2f; 
            float curRot = transform.localRotation.eulerAngles.z;
	        
            transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount++));
	     	        
        }

	    if (Input.GetMouseButtonUp(1))
	    {
		    timer = 0; 
	    }

	    if (Input.GetKeyDown(KeyCode.Z)) {

			Instantiate(this, new Vector3(0, 0, 0), Quaternion.identity);
		}

		if (Input.GetKeyDown (KeyCode.X)) {
		
			Destroy (this); 
		}

	    
	    if (Input.GetMouseButtonDown(0) && timer == 3f) 
	    {
		    Instantiate(this, transform.position * 1f, Quaternion.identity); 

	    }
			
    }

	void OnMouseExit()
	{
		
		SR.color = Color.white; 

	}
	
    void OnMouseDown()
	{
		screenPoint = Camera.main.WorldToScreenPoint(transform.position);
		offset =  transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y,screenPoint.z));
		_colliderPressed = true; 
	}

	void OnMouseDrag()
	{
		if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift)) 
			return;
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;

	}

}
