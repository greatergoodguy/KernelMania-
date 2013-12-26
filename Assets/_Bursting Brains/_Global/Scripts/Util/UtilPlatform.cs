using UnityEngine;
using System.Collections;

public static class UtilPlatform {
	
	public static bool IsAndroid() {
		if (Application.platform == RuntimePlatform.Android)
        	return true;
		
		return false;
	}
	
	public static bool IsIPhone() {
		if (Application.platform == RuntimePlatform.IPhonePlayer)
        	return true;
		
		return false;
	}
	
	public static bool IsMobile() {
		bool result = IsAndroid() || IsIPhone();
		return result;
	}
}
