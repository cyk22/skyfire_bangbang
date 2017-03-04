﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_boss : MonoBehaviour {
	
	public float HP = 80;
	public int damage = 3;
	public float attackDistance = 1.5f;
	public float speed = 1;
	public Animator ani; 
	public float currentHP=0;


	int i =0;
	public bool isOnGround;

	public GameObject EnemyAttackParticle;
	public GameObject DeadParticle;

	private GameObject enemy;
	public GameObject enemyHealthBar;
	float timer;
	public float timeBetweenAttack = 1f;
//	Failed failed;
	Animator failedAni;


	public void Start(){
		ani = this.gameObject.GetComponent<Animator> ();
		currentHP = HP;
//		failed = GetComponent<Failed> ();
//		failedAni = failed.GetComponent<Animator> ();

	}

	public void Update(){
		timer += Time.deltaTime;

		if (currentHP <= 0) {
			die ();
		}

		if (isOnGround) {
			if (meetAnemy ()) {

				if(timer > timeBetweenAttack) {


					Attack ();
				}

			} else {
				//move;
					ani.SetBool("Attack",false);
					ani.SetBool("Walk",true);
					transform.position = new Vector3 (transform.position.x - speed * Time.deltaTime, 
						transform.position.y, transform.position.z);
			}
		}

		float cal_hp = currentHP / HP;
		if (cal_hp > 0) {
			SetBar (cal_hp);
		} else {
			SetBar (0);
		}


	}

	public void die(){
		ani.SetBool ("Dead",true);
		isOnGround = false;//unble fighter
		GameObject.Destroy(this.GetComponent<Rigidbody2D>());
		Invoke("distroy", 3);
		Invoke("DeadEffect", 3);
	}

	private void distroy(){
		GameObject.Destroy (this.gameObject);
	}

	public bool meetAnemy(){
		Collider2D enemies = Physics2D.OverlapCircle (transform.position, attackDistance, 1 << LayerMask.NameToLayer("Soldiers"));

		if (enemies != null) {
			Debug.Log ("Detected");
			this.enemy = enemies.gameObject;
			return true;
		}else
			return false;
	}

	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Player") {
//			failedAni.SetBool ("Failed", true);
		}

		if (other.gameObject.tag == "Platform") {
			isOnGround = true;
		}
	}

	public void SetBar(float myHealth)
	{
		enemyHealthBar.transform.localScale = new Vector3 (myHealth, enemyHealthBar.transform.localScale.y, enemyHealthBar.transform.localScale.z);
	}

	void Attack()
	{
		timer = 0;

		ani.SetBool ("Walk", false);
		ani.SetBool("Attack",true);

		if (enemy.tag == "Fighter") {
			enemy.GetComponent<FighterController> ().currentHP -= damage;
			Instantiate (EnemyAttackParticle, enemy.transform.position, enemy.transform.rotation);
		}
		if (enemy.tag == "Wizard") {
			enemy.GetComponent<WizardControl> ().currentHP -= damage;
			Instantiate (EnemyAttackParticle, enemy.transform.position, enemy.transform.rotation);
		}
		if (enemy.tag == "Archer") {
			enemy.GetComponent<ArcherControl> ().currentHP -= damage;
			Instantiate (EnemyAttackParticle, enemy.transform.position, enemy.transform.rotation);
		}
//		if (enemy.tag == "Player") {
//			enemy.GetComponent<PlayerInFight> ().HP -= damage;
//			failedAni.SetBool ("Failed", true);
//		}

	}

	void DeadEffect()
	{
		Instantiate (DeadParticle, transform.position, transform.rotation);
	}

//	void destroyParticle(){
//		float timer;
//		gameObject pc;
//
//		timer += Time.deltaTime;
//
//		if (timer>pc.)
//	}
}
