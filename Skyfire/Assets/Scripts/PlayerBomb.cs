using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class PlayerBomb : MonoBehaviour {

	private GameObject enemy;
	public float distance = 1f;
	public float restartDelay = 5f;
	GameObject failedBoard;
	Animator failedAni;


	// Use this for initialization
	void Start () {
		failedBoard = GameObject.FindGameObjectWithTag ("failedBoard");
		failedAni = failedBoard.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		meetAnemy ();
	}


	public void back()
	{
		Debug.Log ("backed");
		SceneManager.LoadScene ("Scenes/DarkWorld", LoadSceneMode.Single);
		Bag_Fighter.b_fighter = 0;
		Bag_Wizard.b_wizard = 0;
		Bag_Archer.b_archer = 0;

	}

	public void meetAnemy(){
		Collider2D enemies = Physics2D.OverlapCircle (transform.position, distance, 1 << LayerMask.NameToLayer("Enemies"));

		if (enemies != null) {
			failedAni.SetBool ("Failed", true);
			Invoke ("back", restartDelay);
		}
	}
}
