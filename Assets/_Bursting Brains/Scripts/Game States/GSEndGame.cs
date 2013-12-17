using UnityEngine;
using System.Collections;

public class GSEndGame : GameStateBase {

	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return null;
	}
}
