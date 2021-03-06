﻿using UnityEngine;
using System.Collections;

public class CtrlGameplayPopcorn : MonoBehaviour {
	
	PopcornMachine popcornMachine1;
	
	void Awake() {
		popcornMachine1 = transform.FindChild_BB("Popcorn Machine 1").GetComponent_BB<PopcornMachine>();
	}
	
	void Start() {
		TurnOffAllPopcornMachines();
	}
	
	public void TurnOffAllPopcornMachines() {
		popcornMachine1.TurnOff();
	}
	
	public void TurnOnAllPopcornMachines() {
		popcornMachine1.TurnOn();
	}
	
	public PopcornMachine GetPopcornMachine1() {
		return popcornMachine1;
	}
}
