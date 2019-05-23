using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionDetection : MonoBehaviour
{

	public GameObject border; 
	private Animator borderAnim;
	private bool collisionYes;
	private float timer = 1f, time;
	public float minusVal = 0.3f;
	
	void Start ()
	{

		borderAnim = border.GetComponent<Animator>();
		borderAnim.enabled = false;
	}

	void Update()
	{
		

		if (collisionYes)
		{
			time += Time.deltaTime; 

			if (null != borderAnim)
			{
				borderAnim.enabled = true; 
			}
			
		else if (!collisionYes)
			{
				borderAnim.enabled = false; 

			}

		}
	}
	
	
	void OnCollisionEnter2D (Collision2D col) {

		if (col.gameObject.CompareTag("PSObject"))
		{
			collisionYes = true;
			//border.transform.localScale -= new Vector3(transform.localScale.x - minusVal, transform.localScale.y - minusVal, transform.localScale.z);

		}
	
	}

}
