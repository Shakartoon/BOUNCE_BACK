using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Followcursor : MonoBehaviour {
    public Transform trianglePosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        trianglePosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
	}
}
