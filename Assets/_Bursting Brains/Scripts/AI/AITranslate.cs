using UnityEngine;
using System.Collections;

public class AITranslate : MonoBehaviour {
	
	private static float VELOCITY_METERS_PER_SECOND = 2.0f;
	
	void Start () {
	
	}
	
	void Update () {
		Vector3 tempPos = transform.position;
		tempPos.x += VELOCITY_METERS_PER_SECOND * Time.deltaTime;
		transform.position = tempPos;
	}
}
