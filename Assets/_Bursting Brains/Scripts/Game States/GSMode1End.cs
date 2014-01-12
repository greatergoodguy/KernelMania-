using UnityEngine;
using System.Collections;

public class GSMode1End : GameStateBase {
	
	private static readonly float STATE_DURATION_IN_SECONDS = 3.0f;
	
	CtrlUIGameplay ctrlUIGameplay;
	CtrlBackground ctrlBackground;
	
	float timer;
	bool isFinished;
	
	public GSMode1End() {
		ctrlUIGameplay = FactoryOfControllers.GetCtrlUIGameplay();
		ctrlBackground = FactoryOfControllers.GetCtrlBackground();	
	}
	
	public override void StartState () {
		base.StartState ();
		
		timer = 0;
		isFinished = false;
	}
	
	public override void Update () {
		base.Update ();
		
		timer += Time.deltaTime;
		if(timer > STATE_DURATION_IN_SECONDS) {
			isFinished = true;	
		}
	}
	
	public override void ExitState () {
		base.ExitState ();
		ctrlUIGameplay.SetVisible(false);
		ctrlBackground.SetBgGray();
	}
	
	public override bool IsFinished() {
		return isFinished;
	}
	
	public override IGameState GetNextGameState() {
		return GameFlow.gsMenuStart;
	}
}
