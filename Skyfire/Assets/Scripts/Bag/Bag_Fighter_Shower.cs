using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bag_Fighter_Shower : MonoBehaviour {
	public Text text;

	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}

	// Update is called once per frame
	void Update () {
		text.text = " "+Bag_Fighter.b_fighter;
	}
}
