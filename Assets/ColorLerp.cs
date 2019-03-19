using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour {

	public Color color1 = Color.red;
	public Color color2 = Color.blue;
	public float duration = 30.0F;
	private SpriteRenderer mySR; 
	
	void Start ()
	{

		mySR = GetComponent<SpriteRenderer>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
		float t = Mathf.PingPong(Time.time, duration) / duration;
		Color newColor = Color.Lerp(color1, color2, t);
		mySR.color = newColor; 


	}
}
