using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Building_Manager : MonoBehaviour {
	public static int workshop = 0;
	public static int ArmyCamp = 0;

	public void add_workshop(){
		if (Property.coins >= 20) {
			workshop++;
			Craftman_Manager.num_cf = workshop * 5;
			Property.coins -= 20;
		}
	}

	public void add_ArmyCamp(){
		if (Property.coins >= 20) {
			ArmyCamp++;
			Property.maxArmySize = ArmyCamp * 10;
			Property.coins -= 20;
		}
	}
}
