using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollider : MonoBehaviour {
    public bool visited;

	// Use this for initialization
	void Start () {
        visited = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {
        if ((visited==false)&&(other.gameObject.tag=="Player")) {
            PlayerControllerExp.keys++;
            visited = true;
            Debug.Log(PlayerControllerExp.keys);
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;
        }
    }

}
