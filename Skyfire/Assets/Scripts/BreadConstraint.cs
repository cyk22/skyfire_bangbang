using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreadConstraint : MonoBehaviour {

	Text text;
	// Use this for initialization
	void Start () {
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		ShowBreadInfo ();
	}

	public void ShowBreadInfo(){
		if (Bag_Bread.bagbread == 0) {
			text.text = "You haven't carry any bread for your departure!";
		} else {
			text.text = "Before departure, make sure carry enough bread, and soldiers in your bag~!";
		}

	}

}
