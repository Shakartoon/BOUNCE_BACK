using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class CharacterCustomizer_IdleLogic : State
{
	#region Private Variables
	[SerializeField] CharacterCustomizer_CategorySelectionPanel _guiPanel;
	#endregion

	#region Init
	void Awake ()
	{
		_guiPanel.OnHelmetButton += HandleHelmetButton;
		_guiPanel.OnSwordButton += HandleSwordButton;
		_guiPanel.OnShouldersButton += HandleShouldersButton;
	}
	#endregion

	#region Flow
	void OnEnable ()
	{
		_guiPanel.ChangeState (_guiPanel.name);
	}
	#endregion

	#region Event Handlers
	void HandleHelmetButton ()
	{
		ChangeState ("Helmet");
	}

	void HandleSwordButton ()
	{
		ChangeState ("Sword");
	}

	void HandleShouldersButton ()
	{
		ChangeState ("Shoulders");
	}
	#endregion
}