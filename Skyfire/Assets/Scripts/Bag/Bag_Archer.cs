using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag_Archer : MonoBehaviour {

	public static int b_archer = 100;
	// Use this for initialization
	public void add_b_archer(){
		if (Training_Manager.archer>0 && Backpack.used<Backpack.size) {
			b_archer++;
			Training_Manager.archer -= 1; 
			if (Backpack.used < Backpack.size) {
				Backpack.used += 1;
			}
		}
	}

	public void de_b_archer(){
		if (b_archer>0) {
			b_archer--;
			Training_Manager.archer += 1; 
			if (Backpack.used > 0) {
				Backpack.used -= 1;
			}
		}
	}
}
