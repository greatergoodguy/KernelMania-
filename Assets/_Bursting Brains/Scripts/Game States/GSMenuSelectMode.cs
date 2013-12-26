using UnityEngine;
using System.Collections;

public class GSMenuSelectMode : GameStateBase {

	CtrlUIMenuSelectMode 	ctrlUIMenuSelectMode;
	
	bool isFinished				= false;
	IGameState nextGameState 	= GameFlow.gsMock;
	
	public GSMenuSelectMode() {
		ctrlUIMenuSelectMode 	= FactoryOfControllers.GetControllerUIMenuSelectMode();
	}
	
	public override void StartState() {
		base.StartState();
		
		ctrlUIMenuSelectMode.SetVisibility(true);
		
		ctrlUIMenuSelectMode.SetDelButtonMode1(Mode1Pressed);
		ctrlUIMenuSelectMode.SetDelButtonMode2(Mode2Pressed);
		ctrlUIMenuSelectMode.SetDelButtonMode3(Mode3Pressed);
		
		isFinished = false;
		nextGameState = GameFlow.gsMock;
	} 
	
	public override void ExitState () {
		base.ExitState ();
		
		ctrlUIMenuSelectMode.SetVisibility(false);
	}
	
	public override bool IsFinished() {
		return isFinished;
	}
	
	public override IGameState GetNextGameState() {
		return nextGameState;
	}
	
	public void Mode1Pressed() {
		isFinished = true;
		nextGameState = GameFlow.gsMode1;
	}
	
	public void Mode2Pressed() {
		isFinished = true;
		nextGameState = GameFlow.gsMode2;
	}
	public void Mode3Pressed() {
		isFinished = true;
		nextGameState = GameFlow.gsMode3;
	}
}
