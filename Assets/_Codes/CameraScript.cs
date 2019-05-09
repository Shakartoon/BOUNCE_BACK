using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour
{
	public Color color1 = Color.red;
	public Color color2 = Color.blue;
	public float duration;  



	public Camera cam;


	void Start()
	{
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;

	}

	void FixedUpdate()
	{

		duration = Random.Range(1, 15); 
		float t = Mathf.PingPong(Time.time, duration) / duration;
		cam.backgroundColor = Color.Lerp(color1, color2, t);
	
	}
		
}
