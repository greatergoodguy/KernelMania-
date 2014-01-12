using UnityEngine;
using System.Collections;

public class PopcornMachine : MonoBehaviour {
	
	private static readonly int LAUNCH_ANGLE_MIN_IN_DEGREES = 70;
	private static readonly int LAUNCH_ANGLE_MAX_IN_DEGREES = 150;
	
	private static readonly float LAUNCH_FORCE_MIN = 250;
	private static readonly float LAUNCH_FORCE_MAX = 500;
	
	GameObject kernelsGO;
	GameObject poppedGO;
	
	Vector3 spawnLocalPosition = new Vector3(0, 0, -1);
	
	public float angleInDegrees = 90;
	
	void Awake() {
		kernelsGO = transform.FindChild_BB("Kernels").gameObject;
		poppedGO = transform.FindChild_BB("Popped").gameObject;
	}
	
	public void SpawnKernel() {
		GameObject popcornKernelGO = FactoryOfPrefabs.CreateGOPopcornKernel();	
		
		popcornKernelGO.AddComponent<AIDestroy>();
		popcornKernelGO.transform.parent = kernelsGO.transform;	
		popcornKernelGO.transform.localPosition = spawnLocalPosition;
		
		float angleInRadians = Random.Range(LAUNCH_ANGLE_MIN_IN_DEGREES, LAUNCH_ANGLE_MAX_IN_DEGREES) * Mathf.Deg2Rad;
		float forceX = Random.Range(LAUNCH_FORCE_MIN, LAUNCH_FORCE_MAX) * Mathf.Cos(angleInRadians);
		float forceY = Random.Range(LAUNCH_FORCE_MIN, LAUNCH_FORCE_MAX) * Mathf.Sin(angleInRadians);
		
		popcornKernelGO.rigidbody.AddForce(forceX, forceY, 0);
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
