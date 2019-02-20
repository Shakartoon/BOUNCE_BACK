using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineRendererStuff : MonoBehaviour
{
	private LineRenderer myLR;
	public float widthx; 
	public float widthy;

	public Color c1 = Color.yellow;
	public Color c2 = Color.red;
	public int lengthOfLineRenderer = 20;
	
	
	void Start ()
	{

		myLR = GetComponent<LineRenderer>();
		myLR.material = new Material(Shader.Find("Sprites/Default"));
		myLR.widthMultiplier = 0.2f;
		myLR.positionCount = lengthOfLineRenderer;

		// A simple 2 color gradient with a fixed alpha of 1.0f.
		float alpha = 1.0f;
		Gradient gradient = new Gradient();
		gradient.SetKeys(
			new GradientColorKey[] { new GradientColorKey(c1, 0.0f), new GradientColorKey(c2, 1.0f) },
			new GradientAlphaKey[] { new GradientAlphaKey(alpha, 0.0f), new GradientAlphaKey(alpha, 1.0f) }
		);
		myLR.colorGradient = gradient;

		Vector3[] positions = new Vector3[3];
		positions[0] = new Vector3(-2.0f, -2.0f, 0.0f);
		positions[1] = new Vector3(0.0f, 2.0f, 0.0f);
		positions[2] = new Vector3(2.0f, -2.0f, 0.0f);
		myLR.positionCount = positions.Length;
		myLR.SetPositions(positions);

	


	}
	
	// Update is called once per frame
	void Update () {
		
		
		myLR.SetWidth(widthx++ / 5f, widthy++ / 15f);
		
		var t = Time.time;
		for (int i = 0; i < lengthOfLineRenderer; i++)
		{
			myLR.SetPosition(i, new Vector3(i * 0.1f, Mathf.Sin(i + t), 0.0f));
		}
		
		transform.Translate(2, 2, 0);
	}
}
