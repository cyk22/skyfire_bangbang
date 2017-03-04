using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Key_Trigger : MonoBehaviour {
	public bool visited;

	// Use this for initialization
	void Start () {
		visited = false;
	}

	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter2D(Collision2D other){
		if ((visited == false) && (other.gameObject.tag == "Player")) {
			GameObject.FindGameObjectWithTag ("TextBoard").GetComponent<Text> ().text = "Oh, I find a key!";
			PlayerControllerExp.keys++;
			visited = true;
			Debug.Log (PlayerControllerExp.keys);
			//this.gameObject.GetComponent<Collider2D> ().isTrigger = false;
		} else if(visited){
			GameObject.FindGameObjectWithTag ("TextBoard").GetComponent<Text> ().text = "Nothing found";
		}
	}
}
