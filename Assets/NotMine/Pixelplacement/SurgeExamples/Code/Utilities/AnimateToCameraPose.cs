using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

namespace Pixelplacement
{
	public class AnimateToCameraPose : MonoBehaviour
	{
		#region Private Variables
		[SerializeField] Transform _camera;
		[SerializeField] float _transitionDuration = 2;
		#endregion
		
		#region Flow
		void OnEnable ()
		{
			Tween.Position (Camera.main.transform, _camera.position, _transitionDuration, 0, Tween.EaseInOut);
			Tween.Rotation (Camera.main.transform, _camera.rotation, _transitionDuration, 0, Tween.EaseInOut);
		}
		#endregion
	}
}