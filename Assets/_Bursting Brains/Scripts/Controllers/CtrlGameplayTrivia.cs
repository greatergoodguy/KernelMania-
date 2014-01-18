using UnityEngine;
using System.Collections;

public class CtrlGameplayTrivia : Ctrl_Base {
	
	tk2dTextMesh tmQuestion;
	bool isActive;
	
	void Awake() {
		tmQuestion = transform.FindChild_BB("1 Question").GetComponent_BB<tk2dTextMesh>();
		isActive = false;
	}
	
	void Start() {
		SetActiveFalse();	
	}
	
	public void SetQuestion(string text) {
		tmQuestion.text = text;
		tmQuestion.Commit();
	}
	
	public void SetActiveTrue() {
		isActive = true;
		tmQuestion.gameObject.SetActive(true);
	}
	
	public void SetActiveFalse() {
		isActive = false;
		tmQuestion.gameObject.SetActive(false);
	}
	
	public bool IsActive() {
		return isActive;
	}
}
