using UnityEngine;
using System.Collections;

public abstract class BaseCtrl : MonoBehaviour{
		
	public void SetVisibility(bool isVisible) {
		if(isVisible) 	gameObject.SetActive(true);
		else 			gameObject.SetActive(false);
	}
	
	public bool IsVisible() {
		return gameObject.activeSelf;
	}
	
	public void SetPositionToOrigin() {
		transform.position = Vector3.zero;
	}
}
