using UnityEngine;
using System.Collections;

public class CtrlUIGameplay : MonoBehaviour {
	
	private static readonly string LABEL_SCORE = "Score   ";
	private static readonly string LABEL_TIMER = "Timer   ";
	
	//private static readonly float TIMER_VALUE_DEFAULT_IN_SECONDS = 180f;
	private static readonly float TIMER_VALUE_DEFAULT_IN_SECONDS = 10f;
	
	tk2dTextMesh scoreTextTM;
	int totalScore;
	
	tk2dTextMesh timerTextTM;
	float timerValueInSeconds;
	bool isTimerOn;
	
	void Awake() {
		timerTextTM = transform.FindChild_BB("Timer Text").GetComponent_BB<tk2dTextMesh>();
		timerValueInSeconds = 0;
		isTimerOn = false;
		
		scoreTextTM = transform.FindChild_BB("Score Text").GetComponent_BB<tk2dTextMesh>();
		totalScore = 0;
		
		
		TimerSet(TIMER_VALUE_DEFAULT_IN_SECONDS);
		TimerStart();
	}
	
	void Update() {
		if(isTimerOn && timerValueInSeconds >= 0) {
			timerValueInSeconds -= Time.deltaTime;
			TimerSet(timerValueInSeconds);
		}
	}
	
	public void IncreaseScore(int addedScore) {
		totalScore += addedScore;
		
		scoreTextTM.text = LABEL_SCORE + totalScore;
        scoreTextTM.Commit();
	}
	
	public void TimerSet(float timerValueInSeconds) {
		this.timerValueInSeconds = timerValueInSeconds;
		
		int remainingSeconds = (int) timerValueInSeconds;
		
		int remainingMinutes = remainingSeconds  / 60;
		remainingSeconds -= remainingMinutes * 60;
		
		int remainingMilliseconds = (int) ((timerValueInSeconds % 1)  * 100);
		
		string answer = string.Format("{0:D1}:{1:D2}:{2:D2}", 
    			remainingMinutes, 
    			remainingSeconds,
				remainingMilliseconds);
		
		timerTextTM.text = LABEL_TIMER + answer;
        timerTextTM.Commit();
	}
	
	public void TimerStart() {
		isTimerOn = true;
	}
	
	public void TimerStop() {
		isTimerOn = false;
	}
}
