using UnityEngine;
using System.Collections;

public class GSMode2 : GameStateBase {

	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
}
