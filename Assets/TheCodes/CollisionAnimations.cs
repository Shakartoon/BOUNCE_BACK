using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionAnimations : MonoBehaviour {

	public SpriteRenderer _sprite1; 
	public SpriteRenderer sprite2; 


	public float _scaleVelocity; 
	public float _currentScaleAmount; 
	public Vector2 _defaultScale; 

	void Start () {

		_sprite1 = GetComponent<SpriteRenderer> (); 
		_defaultScale = transform.localScale; 
		_currentScaleAmount = 2; 

	}
	
	void FixedUpdate () {

		_scaleVelocity += (1f - _currentScaleAmount) * .1f;
		_scaleVelocity *= .5f;
		_currentScaleAmount += _scaleVelocity;
		transform.localScale = new Vector2 (_defaultScale.x * (1f / _currentScaleAmount), _defaultScale.y);
		
	}
}
