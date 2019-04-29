using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pixelplacement
{
	[ExecuteInEditMode]
	public class LookAt : MonoBehaviour
	{
		#region Private Variables
		[SerializeField] Transform _target;
		[SerializeField] Vector3 _rotationOffset;
		#endregion
		
		#region Loops
		void LateUpdate ()
		{
			//don't proceed until a target has been set:
			if (_target == null) return; 
			
			transform.LookAt (_target);
			transform.Rotate (_rotationOffset);
		}
		#endregion
	}
}