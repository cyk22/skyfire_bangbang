using UnityEngine;
using System.Collections;

public class Craftman_Manager : MonoBehaviour {

	public Craftman_Manager cf_manager;

	public static int num_cf = Building_Manager.workshop;
	public static int used_cft = 0;

	public static int baker = 0;
	public static int alchemist = 0;

	
	// Update is called once per frame
	void Update () {
		
	}

	public void add(string job){
		switch(job){
		case "baker":
			if (used_cft < num_cf) {
				baker++;
				used_cft++;
				Property.coins -= Baker.price;
			}
			break;
		case "alchemist":
			if (used_cft < num_cf) {
				alchemist++;
				used_cft++;
				Property.coins -= Alchemist.price;
			}
			break;
		}
	}

	public void minus(string job){
		switch(job){
		case "baker":
			if (baker > 0) {
				used_cft--;
				baker--;
				Property.coins += Baker.price;
			}
			break;
		case "alchemist":
			if (alchemist > 0) {
				used_cft--;
				alchemist --;
				Property.coins += Alchemist.price;
			}
			break;
		}
	}




}
