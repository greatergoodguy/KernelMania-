using UnityEngine;
using System.Collections;

public class GSMode1 : GameStateBase {
	
	private static float TIMER_SPAWN_KERNEL = 2.0f;
	
	CtrlBackground 	ctrlBackground;
	CtrlAudio 		ctrlAudio;
	CtrlGameplay 	ctrlGameplay;
	CtrlUIGameplay 	ctrlUIGameplay;
	
	CtrlUIDebug ctrlUIDebug;
	
	float timer = 0;
	bool isFinished = false;
	
	public GSMode1() {
		ctrlBackground	= FactoryOfControllers.GetCtrlBackground();
		ctrlAudio 		= FactoryOfControllers.GetCtrlAudio();
		ctrlGameplay 	= FactoryOfControllers.GetCtrlGameplay();
		ctrlUIGameplay 	= FactoryOfControllers.GetCtrlUIGameplay();
		
		ctrlUIDebug = FactoryOfControllers.GetCtrlUIDebug();
	}
	
	public override void StartState() {
		base.StartState();
		ctrlBackground.SetBgTheater();
		ctrlAudio.MusicPlay();
		ctrlGameplay.TurnOnAllPopcornMachines();
		
		ctrlUIGameplay.SetVisible(true);
		ctrlUIGameplay.TimerSet();
		ctrlUIGameplay.TimerStart();
		ctrlUIGameplay.SetDelOnTimerFinish(OnTimerFinish);
		
		timer = 0;
		isFinished = false;
	}
	
	public override void Update () {
		base.Update();
		timer += Time.deltaTime;
		
		if(timer >= TIMER_SPAWN_KERNEL) {
			timer = 0;
			
			ctrlGameplay.popcornMachine1.SpawnKernel();
		}
	}
	
	public override void ExitState () {
		base.ExitState();
		ctrlBackground.SetBgGray();
		ctrlGameplay.TurnOffAllPopcornMachines();
		ctrlAudio.MusicStop();
		
		ctrlUIGameplay.SetVisible(false);
	}
	
	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
	
	private void OnTimerFinish() {
		isFinished = true;
	}
}
