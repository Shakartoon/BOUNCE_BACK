using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScaleObjects : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		transform.localScale = new Vector3(1 * Time.time * 8, 1 * Time.time * 8 , 0);
		
	}
}
