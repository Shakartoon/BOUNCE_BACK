using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class LevelManager : MonoBehaviour
{
	
	public ONLYClickAndDrag _clickanddragscript;
	public GameObject player; 
	public GameObject firstBar;
	public GameObject lineParent; 
	public GameObject[] allMyChildren = new GameObject[20];
	public GameObject[] sideDiamonds = new GameObject[4]; 
	private float delayTime = 0.3f;
	private Vector3 moveTo; 
		
	private bool _OnMouseDown;
	private float time; 
	
	void Start ()
	{
		_clickanddragscript._OnMouseUp = false;
		player.SetActive(false);
		lineParent.SetActive(false);
		allMyChildren[20].SetActive(false);
		sideDiamonds[4].SetActive(false);
		moveTo = new Vector3(0, 10.9f); 

	}

	IEnumerator PreDelay()
	{
		yield return new WaitForSeconds(3f);
		yield return null; 
	}
	
	IEnumerator NewGetMyChildren()
	{

		for (int i = 0; i < allMyChildren.Length; i++)
		{
			yield return new WaitForSeconds(delayTime);
			lineParent.SetActive(true);
			allMyChildren[i].SetActive(true);
		}
	}

	IEnumerator GetDiamonds()
	{
		for (int i = 0; i < sideDiamonds.Length; i++)
		{
			yield return new WaitForSeconds(0.1f);
			sideDiamonds[i].SetActive(true);
		}  
		
	}

	void Update () {
		
		// Wait 1 second 
		// Move the bar up 
		// Add some indication juice 
		// Load all the children of red lines parent object and wait a little between each load 

		if (firstBar.transform.position != Vector3.zero)
		{
			Debug.Log("HasChanged");

			if (_clickanddragscript._OnMouseUp)
			{
				Debug.Log("Mose"); 
				firstBar.transform.DOMove(new Vector3(0, 8.6f), 2, false);
				
				if (firstBar.transform.position.y >= 8.5f)
				{
					StartCoroutine(NewGetMyChildren()); 
					StartCoroutine(GetDiamonds()); 
					player.SetActive(true);
				}		
			}			
		}
	}
	
}
