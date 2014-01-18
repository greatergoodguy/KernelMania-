using UnityEngine;
using System.Collections;

public class GSMode3 : GameStateBase {
	
	CtrlBackground ctrlBackground;
	CtrlGameplayTrivia ctrlGameplayTrivia;
	
	public GSMode3() {
		ctrlBackground = FactoryOfControllers.GetCtrlBackground();
		ctrlGameplayTrivia = FactoryOfControllers.GetCtrlGameplayTrivia();	
	}
	
	public override void StartState () {
		base.StartState ();
		
		ctrlBackground.SetBgCathedral();
		ctrlGameplayTrivia.SetActiveTrue();
	}
	
	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
}
