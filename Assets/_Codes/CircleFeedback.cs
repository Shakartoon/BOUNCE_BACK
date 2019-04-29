using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFeedback : MonoBehaviour
{

	public GameObject player;
	public float speed = 2f; 
	private Vector3 hi;
	private Vector3 growScale; 
	
	void Start ()
	{
		hi = player.transform.localScale; 

	}
	
	void Update ()
	{
		//Cool Mouse Click Effect
		//HOWEVER, This only achieves the full scale of the ball if the ball is set to kinematic! WHY?! 
		growScale = hi; 
		transform.localScale = Vector3.Lerp(transform.localScale, growScale, 0.1f);
		
		if (transform.localScale.x >= hi.x)
		{
			transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(0.05f, 0.05f, 0), 0.5f);

		}
		

		/* THIS could be a good scene changer: 
		 * 	growScale += hi; 
		transform.localScale = Vector3.Lerp(transform.localScale, growScale, 0.5f);
		 */
		 

	}
}
