using UnityEngine;
using System.Collections;

public class PopcornMachine : MonoBehaviour {
	
	private static readonly float FORCE_LAUNCH_MIN = 150;
	private static readonly float FORCE_LAUNCH_MAX = 300;
	
	Vector3 spawnLocalPosition = new Vector3(0, 0, -1);
	
	public float angleInDegrees = 90;
	
	public void SpawnKernel() {
		GameObject popcornKernelGO = FactoryOfPrefabs.CreateGOPopcornKernel();	
		
		popcornKernelGO.AddComponent<AIDestroy>();
		popcornKernelGO.transform.parent = transform;	
		popcornKernelGO.transform.localPosition = spawnLocalPosition;
		
		float angleInRadians = angleInDegrees * Mathf.Deg2Rad;
		float forceX = FORCE_LAUNCH_MIN * Mathf.Cos(angleInRadians);
		float forceY = FORCE_LAUNCH_MIN * Mathf.Sin(angleInRadians);
		
		//popcornKernelGO.rigidbody.AddForce(forceX, forceY, 0);
	}
	
	public void TurnOff() {
		gameObject.SetActive(false);
	}
	
	public void TurnOn() {
		gameObject.SetActive(true);
	}
	
	public bool IsMachineOn() {
		return gameObject.activeSelf;
	}
}
