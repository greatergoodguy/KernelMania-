using UnityEngine;
using System.Collections;

public class GSMenuSelectMode : GameStateBase {

	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
}
