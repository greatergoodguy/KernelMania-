using UnityEngine;
using System.Collections;

public class UtilMock {
	
	public static readonly string mockString = "";
	
	static GameObject mockGameObject = new GameObject("Mock Game Object");
	
	public static void MockFunction(){        
		// This function does nothing
	}
	
	public static GameObject GetMockGameObject() {        
		return mockGameObject;
	}
}
