using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadCollider : MonoBehaviour {
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
        if ((visited == false) && (other.gameObject.tag == "Player"))
        {
            Bag_Bread.bagbread += 5f;
            visited = true;
            Debug.Log(Bag_Bread.bagbread);
            this.gameObject.GetComponent<BoxCollider2D>().isTrigger = false;

        }
    }
}
