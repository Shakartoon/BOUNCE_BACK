using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clickdragobject : MonoBehaviour {

    private Vector2 mousePosition;
    public Vector2 objectPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnMouseDown()
    {
        objectPosition = mousePosition;
    }
}
