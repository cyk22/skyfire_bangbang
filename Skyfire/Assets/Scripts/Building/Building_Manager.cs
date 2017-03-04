using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Building_Manager : MonoBehaviour {
	public static int workshop = 1;
	public static int ArmyCamp = 1;

	public void add_workshop(){
		if (Property.coins >= 100) {
			workshop++;
			Craftman_Manager.num_cf += 10;
			Property.coins -= 100;
		}
	}

	public void add_ArmyCamp(){
		if (Property.coins >= 100) {
			ArmyCamp++;
			Property.maxArmySize += 5;
			Property.coins -= 100;
		}
	}
}
