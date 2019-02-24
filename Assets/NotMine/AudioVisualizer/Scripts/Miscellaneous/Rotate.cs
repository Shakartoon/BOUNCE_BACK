using UnityEngine;
using System.Collections;

namespace AudioVisualizer
{
	public class Rotate : MonoBehaviour {

		public float speed; //rotation speed
		public float rotDirX; 
		public float rotDirY; 
		public float rotDirZ; 

		

		// Update is called once per frame
		void FixedUpdate () 
		{
			//this.transform.RotateAround (this.transform.position, this.transform.up, speed * Time.deltaTime); // rotate around the up axis!
			transform.Rotate(new Vector3(rotDirX, rotDirY, rotDirZ) * Time.deltaTime * speed); 

		}
	}
}
