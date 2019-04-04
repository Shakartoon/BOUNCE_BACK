using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class circleEffect : MonoBehaviour
{

	//How to reloop outline 
	
	
	[SerializeField] float expandTime;
	[SerializeField] private GameObject loadMe;
	private GameObject instantedThing;
	private bool isDestroyed;
	private bool instantied;
	public bool inner; 

	//outline 
	public bool outer;
	private bool Collision; 
	public GameObject outline1, outline2, outline3;

	void Start()
	{
		outline1.SetActive(false);
		outline2.SetActive(false);
		outline3.SetActive(false);
		
	}
	
	void InstantiateMe()
	{
		
		Instantiate(loadMe, Vector3.zero, transform.rotation);
		
	}

	public void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("SoundMakingObject"))
		{
			Collision = true;
			Debug.Log("Hi"); 
		}
	}

	void Update()
	{

		if (outer)
		{
			if (Collision)
			{
				outline1.SetActive(true);
				outline1.transform.DOScale(3f, 3f);
				Destroy(outline1, 2);
			}
			
		}
		
		if (inner)
		{
			float scale = 1f;
			//transform.localScale = new Vector3(scale, scale, 0) * Time.time * expandTime;


			if (instantied == false)
			{
				InstantiateMe();
				instantied = true;
			}
		}

	}
} 


/*
 
 
if (loadMe != null)
{
	Instantiate(loadMe, Vector3.zero, transform.rotation);

}

else
{
 
	 if (Instantiated)
{
	Instantiate(loadMe, Vector3.zero, transform.rotation);
	Instantiated = false;
}

if (instantedThing != null)
{
	return; 
}


//loadMe.transform.localScale = new Vector3(scale, scale, 0f);
//instantedThing.transform.localScale = new Vector3(scale, scale, 0) * Time.time * expandTime;

if (transform.localScale.x > 11f)
{
	Destroy(gameObject);

	if (isDestroyed)
	{
		loadMe.transform.localScale = new Vector3(scale, scale, -1f);
		instantedThing = Instantiate(loadMe, transform.position, transform.rotation);
		instantedThing.transform.localScale = new Vector3(scale, scale, 0) * Time.time * expandTime;

	}
	
	if (instantedThing != null)
	{
	
	}

} */ 

