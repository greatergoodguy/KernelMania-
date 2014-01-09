using UnityEngine;
using System.Collections;

public class PopcornKernel : MonoBehaviour {
	
	readonly bool isPlatformMobile = UtilPlatform.IsMobile();
	
	CtrlUIDebug ctrlUIDebug;
	CtrlUIGameplay ctrlUIGameplay;
	
	void Start () {
		ctrlUIDebug = FactoryOfControllers.GetControllerUIDebug();
		ctrlUIGameplay = FactoryOfControllers.GetControllerUIGameplay();
	}
	
	void Update() {
		if(isPlatformMobile) {
			RaycastHit hit = new RaycastHit();

        	for(int i=0; i<Input.touchCount; i++) {
            	if(Input.GetTouch(i).phase.Equals(TouchPhase.Began)) {		
					Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(i).position);
					
					if(Physics.Raycast(ray, out hit)) {
						if(hit.collider.gameObject == gameObject) { 
                			ctrlUIDebug.SetText1TM("PopcornKernel: OnTouchDown");
							OnClickDown();
						}
              		}
		        }
			}	
		}
	}
	
	void OnClickDown() {
		ctrlUIGameplay.IncreaseScore(30);	
	}
	
	//=====================================
	// Unity Callback Methods
	//=====================================
	
	// We use the preprocessor here instead of the UtilPlatform
	// class because Unity will complain about the inclusion of the 
	// OnMouse_ callback methods
	void OnMouseDown() {
		ctrlUIDebug.SetText1TM("PopcornKernel: OnMouseDown");
		OnClickDown();
	}
	
	void OnMouseUpAsButton() {
		ctrlUIDebug.SetText1TM("PopcornKernel: OnMouseUpAsButton");
	}
}
