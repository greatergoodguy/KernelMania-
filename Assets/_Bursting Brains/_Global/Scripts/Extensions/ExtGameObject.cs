using UnityEngine;
using System.Collections;

public static class ExtGameObject {    
	public static T GetComponent_BB<T>(this GameObject gameObject) where T : Component{
		T result = gameObject.GetComponent<T>();
		Assert_BB.AssertNotNull(result);
		return result;
	}
}