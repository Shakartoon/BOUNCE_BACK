using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour {

	public bool isMouseDragging;

	void OnMouseDown(){
		isMouseDragging = true;
	} 

	void OnMouseUp(){
		isMouseDragging = false;
	}
}
