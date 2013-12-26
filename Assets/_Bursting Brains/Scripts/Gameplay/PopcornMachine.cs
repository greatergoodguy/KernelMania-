using UnityEngine;
using System.Collections;

public class PopcornMachine : MonoBehaviour {
	
	private static float TIMER_SPAWN_KERNEL = 3.0f;
	
	float timer = 0;
	
	void Update () {
		timer += Time.deltaTime;
		
		if(timer >= TIMER_SPAWN_KERNEL) {
			timer = 0;
			GameObject popcornKernelGO = FactoryOfPrefabs.CreateGOPopcornKernel();	
			popcornKernelGO.AddComponent<AITranslate>();
			popcornKernelGO.AddComponent<AIDestroy>();
			
			AddChild(popcornKernelGO);
		}	
	}
	
	void AddChild(GameObject childGO) {
		childGO.transform.parent = transform;	
	}
}
