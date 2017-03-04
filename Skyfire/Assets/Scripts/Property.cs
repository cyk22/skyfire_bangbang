using UnityEngine;
using System.Collections;

public class Property : MonoBehaviour {

	public static int coins = 2000;
	public static int bread = 2000;
	public static int wheat = 200;

	public static int curArmySize = 0;
	public static int curWorkingCf = 0;
	public static int maxArmySize = Building_Manager.ArmyCamp * 5;
	public static int maxCraftman = Building_Manager.workshop * 5;

	public static float nextTime;
	private float interval;
	public static float leaveTime;



	public void Start(){
		nextTime = Time.time;
		interval = 3;
		Property.coins +=(int) ((Time.time - leaveTime) / (float)interval * (float)Craftman_Manager.alchemist);
		Property.bread +=(int) ((Time.time - leaveTime) / (float)interval * (float)Craftman_Manager.baker);

	}

	public void coinsAdd(){
		coinsAdd (1);
	}

	public void coinsAdd(int m){
		coins += m;
	}
		

	public void addBread(){
		bread += Mathf.Min(Craftman_Manager.baker);
	}

	public void addCoins(){
		coins += Craftman_Manager.alchemist;
	}

	public void Update(){
		if (Time.time > nextTime) {
			nextTime += interval;
			addBread ();
			addCoins ();
		}

		curArmySize = Training_Manager.fighter + Training_Manager.archer + Training_Manager.wizard + Bag_Archer.b_archer + Bag_Fighter.b_fighter + Bag_Wizard.b_wizard;

	}

	public void leave(){
		//Debug.Log (Time.time);
		leaveTime = Time.time;
	}
}
