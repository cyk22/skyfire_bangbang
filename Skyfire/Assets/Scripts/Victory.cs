using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Victory : MonoBehaviour {

	public GameObject[] respawns;
	Animator ani;
	float restartTimer;
	public float restartDelay = 2f;

	// Use this for initialization
	void Start () {
		ani = GetComponent<Animator> ();
	

	}
	
	// Update is called once per frame
	void Update () {
		//bool count = false;

		respawns = GameObject.FindGameObjectsWithTag("Enemy");

		if (respawns.Length == 0) {
			ani.SetBool ("Victory", true);
			Invoke ("back", restartDelay);

		}else{
			
			//Debug.Log (respawns.Length+"vvv");
		}



//		if (count == true) {
//			ani.SetBool ("Victory", true);
//		}
	}

	public void back()
	{
		Debug.Log ("backed");
		SceneManager.LoadScene ("Scenes/main", LoadSceneMode.Single);
	}
}
