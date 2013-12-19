using UnityEngine;
using System.Collections;

public class GSMenuSelectMode : GameStateBase {

	CtrlUIMenuStart 		ctrlUIMenuStart;
	CtrlUIMenuSelectMode 	ctrlUIMenuSelectMode;
	
	CtrlUIDebug 			ctrlUIDebug;
	
	public GSMenuSelectMode() {
		ctrlUIMenuStart 		= FactoryOfControllers.GetControllerUIMenuStart();
		ctrlUIMenuSelectMode 	= FactoryOfControllers.GetControllerUIMenuSelectMode();
		
		ctrlUIDebug				= FactoryOfControllers.GetControllerUIDebug();
	}
	
	public override void StartState() {
		base.StartState();
		
		ctrlUIMenuStart.SetVisibility(false);
		ctrlUIMenuSelectMode.SetVisibility(true);
		
		ctrlUIMenuSelectMode.SetDelButtonMode1(Mode1Pressed);
		ctrlUIMenuSelectMode.SetDelButtonMode2(Mode2Pressed);
		ctrlUIMenuSelectMode.SetDelButtonMode3(Mode3Pressed);
	} 
	
	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
	
	public void Mode1Pressed() {
		ctrlUIDebug.SetVisibility(false);
	}
	
	public void Mode2Pressed() {
		ctrlUIDebug.SetVisibility(true);
	}
	public void Mode3Pressed() {
		bool isUIDebugVisible = ctrlUIDebug.IsVisible();
		ctrlUIDebug.SetVisibility(!isUIDebugVisible);
	}
}
