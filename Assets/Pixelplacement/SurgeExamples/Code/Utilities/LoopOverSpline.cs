using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

namespace Pixelplacement
{
	public class LoopOverSpline : MonoBehaviour
	{
		#region Private Mathods
		[SerializeField] Spline _spline;
		[SerializeField] float _duration = 7;
		#endregion

		#region Init
		void Awake ()
		{
			Tween.Spline (_spline, transform, 0, 1, true, _duration, 0, Tween.EaseLinear, Tween.LoopType.Loop);
		}
		#endregion
	}
}