using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcherBar : MonoBehaviour {

	public float initialGreenLength;
	public GameObject healthBar;
	public float health;
	public float curHealth;
	GameObject hb;


	ArcherControl ac;

	// Use this for initialization
	void Start () {
		ac = GetComponent<ArcherControl> ();

		hb = Instantiate (healthBar, transform.position, transform.rotation) as GameObject;
		//initialGreenLength = hb.transform.localScale.x;

	}

	// Update is called once per frame
	void Update () {
		health = ac.HP;
		curHealth = ac.currentHP;
		hb.transform.position = new Vector3 (transform.position.x-0.5f, transform.position.y+1.8f,transform.position.z);
		if (curHealth >= 0) {
			hb.transform.localScale = new Vector3 (curHealth / health, hb.transform.localScale.y, hb.transform.localScale.z);
		}else{
			GameObject.Destroy (hb);
		}

		transform.LookAt (Camera.main.transform);
	}

}
