using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class FlappyBird : MonoBehaviour {
	//Componentes
	Rigidbody2D rb;
	public static bool inGame;

	public float impulso;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D> ();
		rb.gravityScale = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		if (!inGame && Input.GetButtonDown ("Fire1")) {
			inGame = true;
			rb.gravityScale = 1.0f;

		}
		else if(inGame && Input.GetButtonDown ("Fire1")){
			rb.velocity = new Vector2 (0.0f, impulso);
		}
	}

	void OnTriggerExit2D(Collider2D c){
		Principal.pontos++;
		
	}
	void OnCollisionEnter2D(Collision2D c){
		SceneManager.LoadScene("StartScene");
	}

}
