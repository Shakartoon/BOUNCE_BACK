using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening; 

public class circleEffect : MonoBehaviour
{

	//How to reloop outline 
	

	public bool inner;
	public float speed; 
	//outline 
	public bool outer;
	private bool Collision; 
	public GameObject outline1, outline2, outline3;
	private SpriteRenderer outline1SR, outline2SR, outline3SR;  
	
	//inner 
	[SerializeField] public GameObject circle1, circle2, circle3;
	[SerializeField] public GameObject enemy1, enemy2; 
	
	float alpha = 1f;

	void Start()
	{
		outline1SR = outline1.GetComponent<SpriteRenderer>(); 
		outline2SR = outline2.GetComponent<SpriteRenderer>(); 
		outline3SR = outline3.GetComponent<SpriteRenderer>(); 
		
		outline1.SetActive(false);
		outline2.SetActive(false);
		outline3.SetActive(false);	
	}

	IEnumerator Wait()
	{
		yield return new WaitForSeconds(0.5f); 

	}

	private bool firstCollisionBeforeReset = false;
	
	public void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.CompareTag("SoundMakingObject"))
		{
			Collision = true;
			//Debug.Log("Hi");
			
			if (!firstCollisionBeforeReset)
				Invoke("ResetCollision", 3);
			
			firstCollisionBeforeReset = true;
		}
	}

	void ResetCollision()
	{
		Collision = false;
		
		outline1.transform.localScale = Vector3.one * .6f;
		outline2.transform.localScale = Vector3.one;
		outline1.SetActive(false);
		outline2.SetActive(false);
		outline3.SetActive(false);

		alpha = 1; 
		firstCollisionBeforeReset = false;
		
		Debug.Log(outline1.transform.localScale);
	}
	
	void Update()
	{
	//Debug.Log("In Update");
		if (outer)
		{
//			Debug.Log("Is Outer");
			if (Collision)
			{
				Debug.Log("Is Collision");
				alpha -= Time.deltaTime / 0.3f; //takes 3 seconds

//				Debug.Log(alpha);
				
			    outline1.transform.position = transform.position; 
				outline1.SetActive(true);
				outline1.transform.localScale += Vector3.one * Time.deltaTime * speed;
				outline1SR.color  = new Color(1, 1, 1, alpha);
				
				outline2.transform.position = transform.position; 
				outline2.SetActive(true);
				outline2.transform.localScale += Vector3.one * Time.deltaTime * 1.5f * speed;
				outline2SR.color  = new Color(1, 1, 1, alpha);

				outline3.transform.position = transform.position; 
				outline3.SetActive(true);
				outline3.transform.localScale += Vector3.one * Time.deltaTime * 1.2f * speed;
				outline3SR.color  = new Color(1, 1, 1, alpha);

			}
		}
		
		if (inner)
		{
			circle1.transform.position = transform.position; 

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

