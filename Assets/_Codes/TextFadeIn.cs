using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextFadeIn : MonoBehaviour
{
	private TextMeshPro text;
	byte decrementValue = 255; 
	
	void Start () {
		
		//text = GetComponent<TextMeshPro>();
		GetComponent<TextMeshPro>().enableWordWrapping = true;
		text.fontSize = 40.5f;

	}
	
	void Update ()
	{

		//decrementValue -= 1; 
		//text.color = new Color32(255, 255, 255, decrementValue);

	}
}
