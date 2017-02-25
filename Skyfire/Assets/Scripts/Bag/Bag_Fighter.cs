using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag_Fighter : MonoBehaviour {

	public static int b_fighter;
	// Use this for initialization
	public void add_b_fighter(){
		if (Training_Manager.fighter>0 && Backpack.used<Backpack.size) {
			b_fighter++;
			Training_Manager.fighter -= 1; 
			if (Backpack.used < Backpack.size) {
				Backpack.used += 1;
			}
		}
	}

	public void de_b_fighter(){
		if (b_fighter>0) {
			b_fighter--;
			Training_Manager.fighter += 1; 
			if (Backpack.used > 0) {
				Backpack.used -= 1;
			}
		}
	}
}
