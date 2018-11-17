using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using UnityEngine.UI;
using System;

[RequireComponent (typeof (CanvasGroup))]
public class CharacterCustomizer_CategorySelectionPanel : State
{
	#region Events
	public event Action OnHelmetButton;
	public event Action OnSwordButton;
	public event Action OnShouldersButton;
	#endregion

	#region Private Variables
	[SerializeField] Button _helmetButton;
	[SerializeField] Button _swordButton;
	[SerializeField] Button _shouldersButton;
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
		_helmetButton.onClick.AddListener (HandleHelmetButton);
		_swordButton.onClick.AddListener (HandleSwordButton);
		_shouldersButton.onClick.AddListener (HandleShouldersButton);
	}
	#endregion

	#region Event Handlers
	void HandleHelmetButton ()
	{
		if (OnHelmetButton != null) OnHelmetButton ();
	}

	void HandleSwordButton ()
	{
		if (OnSwordButton != null) OnSwordButton ();
	}

	void HandleShouldersButton ()
	{
		if (OnShouldersButton != null) OnShouldersButton ();
	}
	#endregion
}
