using UnityEngine;
using System.Collections;

/*
 *	The name of this file starts with an underscore
 *	so that it pops to the beginning of the list.
 * 	This is purely a cosmetic purpose, so whether we call it 
 *  _GSInitializeApplication, GSInitializeApplication, or 
 * 	elephant, it won't affect how the application behaves.
 */

public class GSInitializeApplication : GameStateBase {

	public override bool IsFinished() {
		return true;
	}
	
	public override IGameState GetNextGameState() {
		//return GameFlow.gsMenuStart;
		return GameFlow.gsMode1;
	}
}
