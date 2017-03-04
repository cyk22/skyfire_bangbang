using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {
	public GameObject anotherMenu;

	Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ClickOpen(){
		anim.SetBool ("Open", true);
		anim.SetBool ("Close", false);
		if (anotherMenu.GetComponent<Animator> ().GetBool ("Open") == true) {
			anotherMenu.GetComponent<Animator> ().SetBool ("Open", false);
			anotherMenu.GetComponent<Animator> ().SetBool ("Close", true);
		}
	}

	public void ClickClose(){
		anim.SetBool ("Close", true);
		anim.SetBool ("Open", false);
	}
}
