using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss_Trigger : MonoBehaviour {
	public void OnTriggerEnter2D(Collider2D some){
		if (some.gameObject.tag == "Player" && PlayerControllerExp.keys < 3) {
			GameObject.FindGameObjectWithTag ("TextBoard").GetComponent<Text> ().text = "You have not got all the three keys.\nThe dragon doesn't want to see you!";
		}else if (some.gameObject.tag == "Player") {
			CharacterPos.pos = this.gameObject.transform.position;
			CharacterPos.pos.y -= 2f;

			Debug.Log (CharacterPos.pos);
			SceneManager.LoadScene("Scenes/TowerDefence boss", LoadSceneMode.Single);
		}
	}
}
