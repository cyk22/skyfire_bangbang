using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dark : MonoBehaviour {

	Animator anim;

	void start(){
		anim = GetComponent<Animator> ();
	}

	public void clicked(){
		anim.SetBool ("Leave", true);
	}
}
