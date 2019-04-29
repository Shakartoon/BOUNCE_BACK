using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class CharacterCustomizer_CategorySelectionLogic : State
{
	#region Private Variables
	[SerializeField] StateMachine _partStateMachine;
	[SerializeField] CharacterCustomizer_PartSelectionPanel _guiPanel;
	#endregion

	#region Flow
	void OnEnable ()
	{
		_guiPanel.ChangeState (_guiPanel.name);
	}
	#endregion

	#region Init
	void Awake ()
	{
		_guiPanel.OnNextButton += HandleNextButton;
		_guiPanel.OnPreviousButton += HandlePreviousButton;
		_guiPanel.OnCloseButton += HandleCloseButton;
	}
	#endregion

	#region Event Handlers
	void HandleNextButton ()
	{
		_partStateMachine.Next ();
	}

	void HandlePreviousButton ()
	{
		_partStateMachine.Previous ();
	}

	void HandleCloseButton ()
	{
		ChangeState ("Idle");
	}
	#endregion
}
