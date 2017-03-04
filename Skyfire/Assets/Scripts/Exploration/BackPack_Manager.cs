using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackPack_Manager : MonoBehaviour {

	public static int size = Backpack.size;
	public static int used = Backpack.used;


	void Update(){
		Backpack.used = (int)Bag_Bread.bagbread + (int)Bag_Fighter.b_fighter + (int)Bag_Wizard.b_wizard + (int)Bag_Archer.b_archer;
	}

	public void add_backPackSpace(){
		if (Property.coins >= 20) {
			size+=10;
			Backpack.size = size;
			Property.coins -= 20;
		}
	}
}
