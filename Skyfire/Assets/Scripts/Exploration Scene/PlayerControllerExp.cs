using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerControllerExp : MonoBehaviour {
    public float playerSpeed = 1;
    //private Animator anim1;
    private Rigidbody2D myrigidbody;
   // public int playerSteps = 0;
	public Text breadtext;
    public static int keys = 0;
	Animator ani;
	Transform transform;


	// Use this for initialization
	void Start () {
		//Backpack.bread = 20;
		transform  = GetComponent<Transform>();
		ani = GetComponent<Animator>();
		this.gameObject.transform.position = CharacterPos.pos;
		Debug.Log (CharacterPos.pos);
		Debug.Log (this.transform.position);
        //anim1 = GetComponent<Animator>();
        myrigidbody = GetComponent<Rigidbody2D>();
		//keys = 0;
		breadtext.text = "Bread: " + Mathf.Ceil (Bag_Bread.bagbread) + "       Keys: "+ keys;    
	}
	
	// Update is called once per frame
	void Update () {

		breadtext.text = "Bread: " + Mathf.Ceil (Bag_Bread.bagbread)+ "       Keys: "+ keys;

        if (needBread()==true)
        {
			CharacterPos.setTent ();
            SceneManager.LoadScene("Scenes/DarkWorld", LoadSceneMode.Single);
			Bag_Archer.b_archer = 0;
			Bag_Wizard.b_wizard = 0;
			Bag_Fighter.b_fighter = 0;
        }

		if ((Input.GetAxisRaw("Horizontal") > -0.5f) && (Input.GetAxisRaw("Horizontal") < 0.5f))
		{
			myrigidbody.velocity = new Vector2(0f, myrigidbody.velocity.y);
			ani.SetBool ("Idle", true);
			ani.SetBool ("Walk", false);
		} 
		if ((Input.GetAxisRaw("Vertical") < 0.5f) && (Input.GetAxisRaw("Vertical") > -0.5f))
		{
			myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, 0f);
			ani.SetBool ("Idle", true);
			ani.SetBool ("Walk", false);
		} 

		if ((Input.GetAxisRaw("Horizontal")>0.5f))
        {
			ani.SetBool ("Walk", true);
            //transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") *playerSpeed *Time.deltaTime,0f,0f));
            myrigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*playerSpeed, myrigidbody.velocity.y);

			Bag_Bread.bagbread=Bag_Bread.bagbread-0.02f;
			transform.localScale = new Vector3 (-1, 1, -1);


        }

		if ((Input.GetAxisRaw("Horizontal") < -0.5f))
		{
			ani.SetBool ("Walk", true);
			//transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") *playerSpeed *Time.deltaTime,0f,0f));
			myrigidbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal")*playerSpeed, myrigidbody.velocity.y);
			Bag_Bread.bagbread=Bag_Bread.bagbread-0.02f;
			transform.localScale = new Vector3 (1, 1, -1);

		}


        if ((Input.GetAxisRaw("Vertical") > 0.5f) || (Input.GetAxisRaw("Vertical") < -0.5f))
        {
			ani.SetBool ("Walk", true);
            //transform.Translate(new Vector3(0f,Input.GetAxisRaw("Vertical") * playerSpeed * Time.deltaTime, 0f));
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, Input.GetAxisRaw("Vertical")*playerSpeed);
			Bag_Bread.bagbread = Bag_Bread.bagbread - 0.02f;

        }
       // anim1.SetFloat("Movex", Input.GetAxisRaw("Horizontal"));
       // anim1.SetFloat("Movey", Input.GetAxisRaw("Vertical"));
    }

    bool needBread()
    {
		if (Bag_Bread.bagbread<0f)
        {
            return true;
        }
       else
        {
            return false;
        }
    }

    
   
}
