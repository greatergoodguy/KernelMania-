using UnityEngine;
using System.Collections;

public static class FactoryOfControllers {
	
	public static void ExecuteAllGetMethods() {
		GetControllerUIDebug();
		GetControllerUIMenuStart();	
		GetControllerUIMenuSelectMode();
	}
	
	static CtrlUIDebug ctrlUIDebug;
	public static CtrlUIDebug GetControllerUIDebug() {
		if(ctrlUIDebug == null)
        	ctrlUIDebug = GameObject.Find("UI Debug").GetComponent_BB<CtrlUIDebug>();
                
    	return ctrlUIDebug;
	}
	
	static CtrlUIMenuStart ctrlUIMenuStart;
	public static CtrlUIMenuStart GetControllerUIMenuStart() {
		if(ctrlUIMenuStart == null)
        	ctrlUIMenuStart = GameObject.Find("UI Menu Start").GetComponent_BB<CtrlUIMenuStart>();
                
    	return ctrlUIMenuStart;
	}
	
	static CtrlUIMenuSelectMode ctrlUIMenuSelectMode;
	public static CtrlUIMenuSelectMode GetControllerUIMenuSelectMode() {
		if(ctrlUIMenuSelectMode == null)
        	ctrlUIMenuSelectMode = GameObject.Find("UI Menu Select Mode").GetComponent_BB<CtrlUIMenuSelectMode>();
                
    	return ctrlUIMenuSelectMode;
	}
}
