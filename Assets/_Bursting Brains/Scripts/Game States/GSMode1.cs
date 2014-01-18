using UnityEngine;
using System.Collections;

public class GSMode1 : GameStateBase {
	
	private static float TIMER_SPAWN_KERNEL = 2.0f;
	
	CtrlBackground 	ctrlBackground;
	CtrlAudio 		ctrlAudio;
	CtrlGameplayPopcorn 	ctrlGameplay;
	CtrlUIGameplay 	ctrlUIGameplay;
	
	CtrlUIDebug ctrlUIDebug;
	
	float timer = 0;
	bool isFinished = false;
	
	public GSMode1() {
		ctrlBackground	= FactoryOfControllers.GetCtrlBackground();
		ctrlAudio 		= FactoryOfControllers.GetCtrlAudio();
		ctrlGameplay 	= FactoryOfControllers.GetCtrlGameplayPopcorn();
		ctrlUIGameplay 	= FactoryOfControllers.GetCtrlUIGameplay();
		
		ctrlUIDebug = FactoryOfControllers.GetCtrlUIDebug();
	}
	
	public override void StartState() {
		base.StartState();
		ctrlBackground.SetBgTheater();
		ctrlAudio.MusicPlay();
		ctrlGameplay.TurnOnAllPopcornMachines();
		
		ctrlUIGameplay.SetVisible(true);
		ctrlUIGameplay.TimerSet(Constants.DURATION_MODE_1_IN_SECONDS);
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
			
			ctrlGameplay.GetPopcornMachine1().SpawnKernel();
		}
	}
	
	public override void ExitState () {
		base.ExitState();
		ctrlGameplay.TurnOffAllPopcornMachines();
		ctrlAudio.MusicStop();
	}
	
	public override bool IsFinished() {
		return isFinished;
	}
	
	public override IGameState GetNextGameState() {
		return GameFlow.gsMode1End;
	}
	
	private void OnTimerFinish() {
		isFinished = true;
	}
}
