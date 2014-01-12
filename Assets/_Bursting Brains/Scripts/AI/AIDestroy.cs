using UnityEngine;
using System.Collections;

public class AIDestroy : MonoBehaviour {

	private static float TIMER_DESTROY = 7.0f;
	
	float timer = 0;
	
	void Update () {
		timer += Time.deltaTime;
		
		if(timer >= TIMER_DESTROY) {
			Destroy(gameObject);	
		}
	}
}
