using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bag_Bread : MonoBehaviour {

	public static float bagbread = 10;

	public void add_bagbread(){
		if (Property.bread >= 0 && Backpack.used<Backpack.size) {
			bagbread++;
			Property.bread -= 1; 
			if (Backpack.used < Backpack.size) {
				Backpack.used += 1;
			}
		}
	}

	public void de_bagbread(){
		if (bagbread>0) {
			bagbread--;
			Property.bread += 1; 
			if (Backpack.used > 0) {
				Backpack.used -= 1;
			}
		}
	}

}
