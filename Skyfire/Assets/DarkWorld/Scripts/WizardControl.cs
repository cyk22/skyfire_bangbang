using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardControl : MonoBehaviour {

	private GameObject wizard;
	Animator anim;
	public bool isOnGround;
	public float attackDistance = 5;
	GameObject enemy;

	public float HP = 5;
	public float currentHP =0;
	public int damage = 1;
	public float speed = 2; 
	float timer;
	public float timeBetweenAttack=1f;
	public float attackTime = 0.5f;
	public GameObject wizardAttackParticle;
	public GameObject beingAttackParticle;
	public GameObject DeadParticle;

	Vector3 vc;

	// Use this for initialization
	void Start () {

		wizard = this.gameObject;
		anim = GetComponent<Animator> ();
		currentHP = HP;
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		float cal_hp = currentHP / HP;
		SetBar (cal_hp);
		if (isOnGround) {
			if (currentHP <= 0) {
				die ();
			}
				
			if (meetAnemy()) {
				if(timer > timeBetweenAttack){

					Attack ();


				}
			} else { 
				anim.SetBool ("Attack", false);
				anim.SetBool ("Idle", true);
			}


		}
	}

	public void die(){
		anim.SetBool("Attack",false);
		anim.SetBool("Idle",false);
		anim.SetBool ("Dead",true);
		isOnGround = false;//unable fighter
		Invoke("distroy", 3);
		Invoke("DeadEffect", 3);
	}

	private void distroy(){
		GameObject.Destroy (this.gameObject);
	}


	public void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "Platform") {
			isOnGround = true;
		}
	}

	public bool meetAnemy(){
		Collider2D enemies = Physics2D.OverlapCircle (transform.position, attackDistance, 1 << LayerMask.NameToLayer("Enemies"));
		if (enemies != null) {
			this.enemy = enemies.gameObject;

			return true;
		}
		return false;
	}

	public void SetBar(float myHealth)
	{
		//soilderHealthBar.transform.localScale = new Vector3 (myHealth, soilderHealthBar.transform.localScale.y, soilderHealthBar.transform.localScale.z);
	}

	void Attack()
	{
		timer = 0;
		timer += Time.deltaTime;
		anim.SetBool("Attack",true);
		vc = new Vector3(transform.position.x+3f,transform.position.y+0.5f,transform.position.z);
		Instantiate(wizardAttackParticle,vc,transform.rotation);

		if (enemy.GetComponent<Enemy> () != null) {
			enemy.GetComponent<Enemy> ().currentHP -= damage;
		} else {
			enemy.GetComponent<Enemy_boss> ().currentHP -= damage;
		}

		Instantiate (beingAttackParticle, enemy.transform.position, enemy.transform.rotation);


		if (timer > attackTime) {
			anim.SetBool ("Idle", true);
		}
	}

	void DeadEffect()
	{
		Instantiate (DeadParticle, transform.position, transform.rotation);
	}
}
