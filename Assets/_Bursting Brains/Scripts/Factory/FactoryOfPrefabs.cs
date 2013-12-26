using UnityEngine;
using System.Collections;

public static class FactoryOfPrefabs {
	
	static GameObject popcornKernelGO;
	public static GameObject CreateGOPopcornKernel() {
		if(popcornKernelGO == null) {
			popcornKernelGO = Resources.Load("Popcorn Kernel") as GameObject;
			Assert_BB.AssertNotNull(popcornKernelGO);        
		}
                
		Transform popcornKernelT = MonoBehaviour.Instantiate(popcornKernelGO.transform, Vector3.zero, Quaternion.identity) as Transform;
		Assert_BB.Assert(popcornKernelT != null);

		return popcornKernelT.gameObject;
	}
}
