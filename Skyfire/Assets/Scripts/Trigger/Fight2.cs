using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Fight2 : MonoBehaviour {
	public void OnTriggerEnter2D(Collider2D some){
		if (some.gameObject.tag == "Player") {
			CharacterPos.pos = this.gameObject.transform.position;
			CharacterPos.pos.y -= 2f;

			Debug.Log (CharacterPos.pos);
			SceneManager.LoadScene("Scenes/TowerDefence 2", LoadSceneMode.Single);
		}
	}
}
