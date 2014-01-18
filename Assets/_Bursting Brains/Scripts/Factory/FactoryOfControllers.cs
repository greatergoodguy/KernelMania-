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
	
	static CtrlGameplayPopcorn ctrlGameplayPopcorn;
	public static CtrlGameplayPopcorn GetCtrlGameplayPopcorn() {
		if(ctrlGameplayPopcorn == null)
        	ctrlGameplayPopcorn = GameObject.Find("Gameplay Popcorn").GetComponent_BB<CtrlGameplayPopcorn>();
                
    	return ctrlGameplayPopcorn;
	}
	
	static CtrlGameplayTrivia ctrlGameplayTrivia;
	public static CtrlGameplayTrivia GetCtrlGameplayTrivia() {
		if(ctrlGameplayTrivia == null)
        	ctrlGameplayTrivia = GameObject.Find("Gameplay Trivia").GetComponent_BB<CtrlGameplayTrivia>();
                
    	return ctrlGameplayTrivia;
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
	
	static CtrlBackground ctrlBackground;
	public static CtrlBackground GetCtrlBackground() {
		if(ctrlBackground == null)
        	ctrlBackground = GameObject.Find("Background").GetComponent_BB<CtrlBackground>();
                
    	return ctrlBackground;
	}
}
