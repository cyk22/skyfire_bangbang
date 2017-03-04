using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MHArmyCamp : MonoBehaviour {

	//public Texture2D textureToDisplay;
	public GUIContent guic;
	public GUIStyle guis;

	bool isShowTip;
	// Use this for initialization
	void Start () {
		isShowTip=false;

	}

	void OnMouseEnter () {
		isShowTip=true;
	}

	void OnMouseExit () {
		isShowTip=false;
	}

	void OnGUI () {
		if (isShowTip){
			//GUI.Label(new Rect(Input.mousePosition.x,Screen.height-Input.mousePosition.y,100,40),"Tips!!");
			GUI.Label(new Rect(Input.mousePosition.x,Screen.height-Input.mousePosition.y,400,20),guic,guis);
			//GUI.Label(new Rect(600,400,100,40),"Tips!!");
		}
	}
}

