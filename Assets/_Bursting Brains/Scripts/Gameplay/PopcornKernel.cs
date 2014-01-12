using UnityEngine;
using System.Collections;

public class PopcornKernel : MonoBehaviour {
	
	private static readonly int LAUNCH_ANGLE_MIN_IN_DEGREES = 20;
	private static readonly int LAUNCH_ANGLE_MAX_IN_DEGREES = 100;
	
	private static readonly float LAUNCH_FORCE_MIN = 250;
	private static readonly float LAUNCH_FORCE_MAX = 500;
	
	readonly int SCORE_AMOUNT = 1000;
	readonly bool isPlatformMobile = UtilPlatform.IsMobile();
	
	Vector3 spawnPositionOffset = new Vector3(0, 0, 1);
	
	CtrlUIDebug ctrlUIDebug;
	CtrlUIGameplay ctrlUIGameplay;
	
	void Start () {
		ctrlUIDebug = FactoryOfControllers.GetCtrlUIDebug();
		ctrlUIGameplay = FactoryOfControllers.GetCtrlUIGameplay();
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
		ctrlUIGameplay.IncreaseScore(SCORE_AMOUNT);	
		GameObject popcornPoppedGO = FactoryOfPrefabs.CreateGOPopcornPopped();
		popcornPoppedGO.transform.position = transform.position + spawnPositionOffset;
		
		float angleInRadians = Random.Range(LAUNCH_ANGLE_MIN_IN_DEGREES, LAUNCH_ANGLE_MAX_IN_DEGREES) * Mathf.Deg2Rad;
		float forceX = Random.Range(LAUNCH_FORCE_MIN, LAUNCH_FORCE_MAX) * Mathf.Cos(angleInRadians);
		float forceY = Random.Range(LAUNCH_FORCE_MIN, LAUNCH_FORCE_MAX) * Mathf.Sin(angleInRadians);
		
		popcornPoppedGO.rigidbody.AddForce(forceX, forceY, 0);Destroy(gameObject);
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
