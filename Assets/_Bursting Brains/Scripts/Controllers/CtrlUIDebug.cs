using UnityEngine;
using System.Collections;

public class CtrlUIDebug : ControllerBaseMB {
	
	CtrlUIMenuStart ctrlUIMenuStart;
	
	void Start() {
		ctrlUIMenuStart = FactoryOfControllers.GetControllerUIMenuStart();
		
		SetPositionToOrigin();
	}
	
	public void ButtonDebug1() {
		bool isVisible = ctrlUIMenuStart.IsVisible();
		ctrlUIMenuStart.SetVisibility(!isVisible);
	}
}
