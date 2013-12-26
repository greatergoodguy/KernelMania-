using UnityEngine;
using System.Collections;

public class CtrlUIDebug : ControllerBaseMB {
	
	private tk2dTextMesh text1TM;
	
	void Awake() {	
		text1TM = transform.FindChild_BB("Text 1").GetComponent_BB<tk2dTextMesh>();
		
		SetPositionToOrigin();
	}
	
	public void Button1() {
		SetText1TM("Debug Button 1");
	}
	
	public void SetText1TM(string newText) {
		text1TM.text = newText;
        text1TM.Commit();
	}
}
