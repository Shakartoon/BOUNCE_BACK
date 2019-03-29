using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class LevelManager : MonoBehaviour
{
	
	public ONLYClickAndDrag _clickanddragscript; 
	public GameObject firstBar;
	public GameObject[] barArray;
	public GameObject lineParent; 

	private bool _OnMouseDown;
	private float time; 
	
	void Start ()
	{
		_clickanddragscript._OnMouseUp = false;
		lineParent.SetActive(false);
	}
	
	void Update () {

		if (firstBar.transform.position != Vector3.zero)
		{
			Debug.Log("HasChanged");

			if (_clickanddragscript._OnMouseUp)
			{
				Debug.Log("Mose"); 
				firstBar.transform.DOMove(new Vector3(0, 10.9f), 2, false); 
				GetMyChildren(); 

			}
			
			// Wait 1 second 
			// Move the bar up 
			// Add some indication juice 
			// Load all the children of red lines parent object and wait a little between each load 
		}
		
	}

	void GetMyChildren()
	{
		foreach (Transform child in lineParent.transform)
		{

			for (int i = 0; i < barArray.Length; i++)
			{
			
				lineParent.SetActive(true);

			}
			
			
		}

		
	}
	
}
