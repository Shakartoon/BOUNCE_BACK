using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulsingScale : MonoBehaviour
{
	private Vector3 initialScale;
	public bool ContinuousPulse;
	public float timeToScale = 1.5f; 
	
	void Start()
	{
		initialScale = transform.localScale;
	}

	void Update()
	{
		if(ContinuousPulse)
		{
			transform.localScale =
				new Vector3(Mathf.PingPong(Time.time, timeToScale), transform.localScale.x, transform.localScale.y);
		}
	}
	
	//Not being used 
	public void PulseMe() { 
		//iTween.Stop(gameObject);
		transform.localScale = initialScale;
		Hashtable hash = new Hashtable();
		hash.Add("amount", new Vector3(Random.Range(1, 4), 2f, 0f));
		hash.Add("time", 5f);
		iTween.PunchScale(gameObject, hash);

	}

}
