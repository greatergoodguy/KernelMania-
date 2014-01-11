using UnityEngine;
using System.Collections;

public class GSMenuStart : GameStateBase {
	
	CtrlUIMenuStart ctrlUIMenuStart;
	
	bool isFinished = false;
	
	public GSMenuStart() {
		ctrlUIMenuStart = FactoryOfControllers.GetCtrlUIMenuStart();
	}
	
	public override void StartState() {
		base.StartState();
		
		ctrlUIMenuStart.SetVisibility(true);
		ctrlUIMenuStart.SetDelButtonPlayGame(PlayGamePressed);
	} 
	
	public override void ExitState() {
		base.StartState();
		
		ctrlUIMenuStart.SetVisibility(false);
	} 
	
	public override bool IsFinished() {
		return isFinished;
	}
	
	public override IGameState GetNextGameState() {
		return GameFlow.gsMenuSelectMode;
	}
	
	public void PlayGamePressed() {
		isFinished = true;
	}
}
