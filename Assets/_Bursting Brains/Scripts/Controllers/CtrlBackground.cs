using UnityEngine;
using System.Collections;

public class CtrlBackground : MonoBehaviour {
	
	GameObject bgGray;
	GameObject bgTheater;
	
	GameObject activeBG;
	
	void Awake() {
		bgGray = transform.FindChild_BB("Gray").gameObject;	
		bgTheater = transform.FindChild_BB("Theater").gameObject;	
		
		bgGray.SetActive(false);
		bgTheater.SetActive(false);
		
		activeBG = UtilMock.GetMockGameObject();
	}
	
	void Start() {
		SetBgGray();
	}
	
	public void SetBgGray() {
		activeBG.SetActive(false);	
		activeBG = bgGray;
		activeBG.SetActive(true);
	}
	
	public void SetBgTheater() {
		activeBG.SetActive(false);	
		activeBG = bgTheater;
		activeBG.SetActive(true);
	}
}
