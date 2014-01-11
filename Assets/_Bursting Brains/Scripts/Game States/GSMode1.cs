using UnityEngine;
using System.Collections;

public class GSMode1 : GameStateBase {
	
	private static float TIMER_SPAWN_KERNEL = 2.0f;
	
	CtrlAudio ctrlAudio;
	CtrlGameplay ctrlGameplay;
	
	float timer = 0;
	
	public GSMode1() {
		ctrlAudio = FactoryOfControllers.GetCtrlAudio();
		ctrlGameplay = FactoryOfControllers.GetCtrlGameplay();
	}
	
	public override void StartState() {
		base.StartState();
		ctrlAudio.MusicPlay();
		ctrlGameplay.TurnOnAllPopcornMachines();
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
		ctrlGameplay.TurnOffAllPopcornMachines();
		ctrlAudio.MusicStop();
	}
	
	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
}
