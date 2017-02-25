using UnityEngine;
using System.Collections;

public class Property : MonoBehaviour {

	public static int coins = 200;
	public static int bread = 200;
	public static int wheat = 200;

	public static int curArmySize = 0;
	public static int curWorkingCf = 0;
	public static int maxArmySize = Building_Manager.ArmyCamp * 5;
	public static int maxCraftman = Building_Manager.workshop * 5;

	private float nextTime;
	private float interval;



	public void Start(){
		nextTime = 0;
		interval = 3;
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
	}
}
