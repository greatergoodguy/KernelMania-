using UnityEngine;
using System.Collections;

public class GSMode1 : GameStateBase {
	
	private static float TIMER_SPAWN_KERNEL = 2.0f;
	
	CtrlGameplay ctrlGameplay;
	
	float timer = 0;
	
	public GSMode1() {
		ctrlGameplay = FactoryOfControllers.GetControllerGameplay();
	}
	
	public override void StartState() {
		base.StartState();
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
	}
	
	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
}
