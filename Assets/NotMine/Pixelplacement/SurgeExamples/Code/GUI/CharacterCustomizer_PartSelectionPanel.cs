using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using Pixelplacement;

public class CharacterCustomizer_PartSelectionPanel : State
{
	#region Events
	public event Action OnPreviousButton;
	public event Action OnNextButton;
	public event Action OnCloseButton;
	#endregion

	#region Private Variables
	[SerializeField] Button _previousButton;
	[SerializeField] Button _nextButton;
	[SerializeField] Button _closeButton;
	#endregion

	#region Flow
	void OnEnable ()
	{
		Tween.CanvasGroupAlpha (GetComponent<CanvasGroup> (), 0, 1, .5f, 0);
	}
	#endregion

	#region Init
	void Awake ()
	{
		_previousButton.onClick.AddListener (HandlePreviousButton);
		_nextButton.onClick.AddListener (HandleNextButton);
		_closeButton.onClick.AddListener (HandleCloseButton);
	}
	#endregion

	#region Event Handlers
	void HandlePreviousButton ()
	{
		if (OnPreviousButton != null) OnPreviousButton ();
	}

	void HandleNextButton ()
	{
		if (OnNextButton != null) OnNextButton ();
	}

	void HandleCloseButton ()
	{
		if (OnCloseButton != null) OnCloseButton ();
	}
	#endregion
}
