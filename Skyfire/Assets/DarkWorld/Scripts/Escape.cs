using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour {


	public float restartDelay = 1f;
	Animator anim;
	Enemy enemy;

	void Start()
	{
		anim = GetComponent<Animator>();
		enemy = GetComponent<Enemy> ();
	}

	void Update()
	{
			//if (restartTimer >= restartDelay)
			//{
			//	CharacterPos.setTent ();

			//	SceneManager.LoadScene ("Scenes/DarkWorld", LoadSceneMode.Single);
			//}


	}

	public void clicked()
	{
//		enemy.enabled = true;
		Invoke ("back", restartDelay);

		//enemyAttack.enabled = false;

		//Enemy.enabled = false;

		//restartTimer += Time.deltaTime;
//		restartTimer=0;
//		if (restartTimer >= restartDelay) {


	}

	public void back()
	{
		Debug.Log (CharacterPos.pos);
		SceneManager.LoadScene ("Scenes/main", LoadSceneMode.Single);
	}

}
