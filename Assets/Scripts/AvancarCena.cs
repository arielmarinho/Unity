using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class AvancarCena : MonoBehaviour {
	public string cena;

	void Start(){
		FlappyBird.inGame = false;
	}
	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
		
		// Fire1 -> Touch, CTRL+ left, Click+ left
		if (Input.GetKeyDown (KeyCode.Return)|| Input.touchCount == 2) {
			Principal.pontos = 0;

			SceneManager.LoadScene (cena);
		}
			

	}
}
