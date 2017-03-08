using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BreadCollider : MonoBehaviour {
    public bool visited;
	// Use this for initialization
	void Start () {
        visited = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter2D(Collision2D other)
    {
		if ((visited == false) && (other.gameObject.tag == "Player")) {
			GameObject.FindGameObjectWithTag ("TextBoard").GetComponent<Text> ().text = "Luckily you obtain 5 bread!";
			Bag_Bread.bagbread += 5f;
			visited = true;
			Debug.Log (Bag_Bread.bagbread);
			//this.gameObject.GetComponent<BoxCollider2D> ().isTrigger = false;

		} else if (visited) {
			GameObject.FindGameObjectWithTag ("TextBoard").GetComponent<Text> ().text = "Nothing found";
		}
    }
}
