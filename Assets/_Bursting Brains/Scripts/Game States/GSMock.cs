using UnityEngine;
using System.Collections;

public class GSMock : GameStateBase {

	public override bool IsFinished() {
		return false;
	}
	
	public override IGameState GetNextGameState() {
		return GameFlow.gsMock;
	}
}
