using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scalingAnimations : MonoBehaviour
{
	public newSoundMakingObject newSoundMakingObjectScript;	
	private Vector2 defaultScaleBallToScale; //def scale maybe too big
	float scaleVelocity;
	float currentScaleAmount;
	
	void Start () {
		defaultScaleBallToScale = transform.localScale; 
		currentScaleAmount = 0.1f;

		
	}
	
	// Update is called once per frame
	void Update() {
		
		
		//WHAT THE FUCKKK. IT"S NOT UNDERSTANDING THE COLLISION, COLLIDING ALL THE TIME. 
		if (newSoundMakingObjectScript.myCollision = true)
		{
			Debug.Log("This is working");
			//yield return new WaitForSeconds(1); 
			scaleVelocity = 8f; //how does it know that this is velocity? 
			currentScaleAmount += scaleVelocity;
			//transform.localScale = new Vector2(currentScaleAmount * 5, currentScaleAmount * 5); 
			transform.localScale = new Vector2(defaultScaleBallToScale.x * (1f * currentScaleAmount),
				defaultScaleBallToScale.y * (1f * currentScaleAmount));

//			scaleVelocity = scaleVelocity + (1f - currentScaleAmount) * .2f;
//			scaleVelocity = scaleVelocity * .92f;
//			currentScaleAmount = currentScaleAmount + scaleVelocity;
//			transform.localScale = new Vector2 (defaultScaleBallToScale.x * (1f / currentScaleAmount), defaultScaleBallToScale.y * currentScaleAmount);

		}

	}
		
}
