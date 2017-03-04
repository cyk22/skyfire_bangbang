using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag_Wizard : MonoBehaviour {

	public static int b_wizard = 0;
	// Use this for initialization
	public void add_b_wizard(){
		if (Training_Manager.wizard>0 && Backpack.used<Backpack.size) {
			b_wizard++;
			Training_Manager.wizard -= 1; 
			if (Backpack.used < Backpack.size) {
				Backpack.used += 1;
			}
		}
	}

	public void de_b_wizard(){
		if (b_wizard>0) {
			b_wizard--;
			Training_Manager.wizard += 1; 
			if (Backpack.used > 0) {
				Backpack.used -= 1;
			}
		}
	}
}
