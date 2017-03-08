using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Scene_Manager : MonoBehaviour {



	public void loadScene(string name){
		if (Bag_Bread.bagbread > 0) {
			SceneManager.LoadScene (name, LoadSceneMode.Single);
		} 
	}
		

}
