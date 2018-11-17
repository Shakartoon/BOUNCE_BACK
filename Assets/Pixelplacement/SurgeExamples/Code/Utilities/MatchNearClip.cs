using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Pixelplacement
{
	[ExecuteInEditMode]
	public class MatchNearClip : MonoBehaviour
	{
		#region Private Variables
		[SerializeField] Camera _camera;
		[SerializeField] float _offset = .01f;
		#endregion

		#region Init
		void LateUpdate ()
		{
			//don't proceed until a camera has been set:
			if (_camera == null) return; 

			GetComponent<Canvas> ().planeDistance = _camera.nearClipPlane + _offset;
		}
		#endregion
	}
}