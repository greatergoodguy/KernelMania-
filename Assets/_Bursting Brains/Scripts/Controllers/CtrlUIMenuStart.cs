using UnityEngine;
using System.Collections;

public class CtrlUIMenuStart : BaseCtrl {
	
	DelButton delButtonPlayGame = UtilMock.MockFunction;
	
	void Start() {
		SetVisible(false);
		SetPositionToOrigin();
	}
	
	public void SetDelButtonPlayGame(DelButton delButtonPlayGame){
		this.delButtonPlayGame = delButtonPlayGame;
	}
	
	public void ButtonPlayGame() {	delButtonPlayGame();}
	public void ButtonQuit() {		Application.Quit();}
}
