using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WEIRDPS : MonoBehaviour {

    private ParticleSystem[] PS;
	private float time = 15f;
	private float someDisAwayFromCam = 10f;

	void Start ()
	{
		PS = GetComponent<ParticleSystem[]>();
		
	}
	
	// Update is called once per frame
	void Update () {

		for (int i = 0; i < PS.Length; i++)
		{
			PS[i].transform.position = new Vector3(Mathf.Cos(time),Mathf.Sin(time), someDisAwayFromCam) * 2 * i;

		}


	}
}
