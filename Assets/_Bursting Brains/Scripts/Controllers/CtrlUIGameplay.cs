using UnityEngine;
using System.Collections;

public class CtrlUIGameplay : MonoBehaviour {
	
	private static readonly string LABEL_SCORE = "Score: ";
	
	tk2dTextMesh scoreTM;
	
	int totalScore;
	
	void Awake() {
		scoreTM = transform.FindChild_BB("Score Text").GetComponent_BB<tk2dTextMesh>();
		
		totalScore = 0;
	}
	
	public void IncreaseScore(int addedScore) {
		totalScore += addedScore;
		
		scoreTM.text = LABEL_SCORE + totalScore;
        scoreTM.Commit();
	}
}
