using UnityEngine;
using System.Collections;

public static class FactoryOfControllers {
	
	static CtrlUIDebug ctrlUIDebug;
	public static CtrlUIDebug GetCtrlUIDebug() {
		if(ctrlUIDebug == null)
        	ctrlUIDebug = GameObject.Find("UI Debug").GetComponent_BB<CtrlUIDebug>();
                
    	return ctrlUIDebug;
	}
	
	static CtrlUIMenuStart ctrlUIMenuStart;
	public static CtrlUIMenuStart GetCtrlUIMenuStart() {
		if(ctrlUIMenuStart == null)
        	ctrlUIMenuStart = GameObject.Find("UI Menu Start").GetComponent_BB<CtrlUIMenuStart>();
                
    	return ctrlUIMenuStart;
	}
	
	static CtrlUIMenuSelectMode ctrlUIMenuSelectMode;
	public static CtrlUIMenuSelectMode GetCtrlUIMenuSelectMode() {
		if(ctrlUIMenuSelectMode == null)
        	ctrlUIMenuSelectMode = GameObject.Find("UI Menu Select Mode").GetComponent_BB<CtrlUIMenuSelectMode>();
                
    	return ctrlUIMenuSelectMode;
	}
	
	static CtrlGameplay ctrlGameplay;
	public static CtrlGameplay GetCtrlGameplay() {
		if(ctrlGameplay == null)
        	ctrlGameplay = GameObject.Find("Gameplay").GetComponent_BB<CtrlGameplay>();
                
    	return ctrlGameplay;
	}
	
	
	static CtrlUIGameplay ctrlUIGameplay;
	public static CtrlUIGameplay GetCtrlUIGameplay() {
		if(ctrlUIGameplay == null)
        	ctrlUIGameplay = GameObject.Find("UI Gameplay").GetComponent_BB<CtrlUIGameplay>();
                
    	return ctrlUIGameplay;
	}
	
	
	static CtrlAudio ctrlAudio;
	public static CtrlAudio GetCtrlAudio() {
		if(ctrlAudio == null)
        	ctrlAudio = GameObject.Find("Audio").GetComponent_BB<CtrlAudio>();
                
    	return ctrlAudio;
	}
}
