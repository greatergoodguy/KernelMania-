using UnityEngine;
using System.Collections;

public class CtrlBackground : MonoBehaviour {
	
	GameObject bgGray;
	GameObject bgTheater;
	GameObject bgCathedral;
	
	GameObject activeBG;
	
	void Awake() {
		bgGray = transform.FindChild_BB("Gray").gameObject;	
		bgGray.SetActive(false);
	
		bgTheater = transform.FindChild_BB("Theater").gameObject;	
		bgTheater.SetActive(false);
		
		bgCathedral = transform.FindChild_BB("Cathedral").gameObject;	
		bgCathedral.SetActive(false);
		
		activeBG = UtilMock.GetMockGameObject();
	}
	
	void Start() {
		SetBgGray();}
	
	public void SetBgGray() {
		SetBG(bgGray);}
	
	public void SetBgTheater() {
		SetBG(bgTheater);}
	
	public void SetBgCathedral() {
		SetBG(bgCathedral);}
	
	private void SetBG(GameObject backgroundGO) {
		activeBG.SetActive(false);	
		activeBG = backgroundGO;
		activeBG.SetActive(true);
	}
}
