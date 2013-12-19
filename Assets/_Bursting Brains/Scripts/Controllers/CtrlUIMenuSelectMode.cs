using UnityEngine;
using System.Collections;

public class CtrlUIMenuSelectMode : ControllerBaseMB {
	
	DelButton delButtonMode1 = UtilMock.MockFunction;
	DelButton delButtonMode2 = UtilMock.MockFunction;
	DelButton delButtonMode3 = UtilMock.MockFunction;
	
	void Start () {
		SetVisibility(false);
		SetPositionToOrigin();
	}
	
	// ============ Mode 1 ============ //
	public void SetDelButtonMode1(DelButton delButtonMode1){	
		this.delButtonMode1 = delButtonMode1;
	}
	public void ButtonMode1() {	delButtonMode1();}
	
	// ============ Mode 2 ============ //
	public void SetDelButtonMode2(DelButton delButtonMode2){	
		this.delButtonMode2 = delButtonMode2;
	}
	public void ButtonMode2() {	delButtonMode2();}
	
	// ============ Mode 3 ============ //
	public void SetDelButtonMode3(DelButton delButtonMode3){	
		this.delButtonMode3 = delButtonMode3;
	}
	public void ButtonMode3() {	delButtonMode3();}
}
