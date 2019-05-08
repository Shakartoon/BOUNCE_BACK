using UnityEngine;
using System.Collections;

	public class Rotate : MonoBehaviour {

		public float speed; //rotation speed
		public float rotDirX; 
		public float rotDirY; 
		public float rotDirZ;
		public bool rotateBackAndForth; 
		
		[SerializeField] protected Vector3 m_from = new Vector3(0.0F, 45.0F, 0.0F);
		[SerializeField] protected Vector3 m_to = new Vector3(0.0F, -45.0F, 0.0F);
		[SerializeField] protected float m_frequency = 1.0F;

		// Update is called once per frame
		void FixedUpdate () 
		{
			//this.transform.RotateAround (this.transform.position, this.transform.up, speed * Time.deltaTime); // rotate around the up axis!
			transform.Rotate(new Vector3(rotDirX, rotDirY, rotDirZ) * Time.deltaTime * speed); 

		}
		
		protected virtual void Update() {
			
			if(rotateBackAndForth)
			{
				Quaternion from = Quaternion.Euler(this.m_from);
				Quaternion to = Quaternion.Euler(this.m_to);

				float lerp = 0.5F * (1.0F + Mathf.Sin(Mathf.PI * Time.realtimeSinceStartup * this.m_frequency));
				transform.localRotation = Quaternion.Lerp(from, to, lerp);
			}
		}
	}



 