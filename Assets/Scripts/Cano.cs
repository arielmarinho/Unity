using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cano : MonoBehaviour {
	public float velocidade;
	public float alturaInicial, alturaFinal;
	public float limiteX;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (FlappyBird.inGame) {
			// Move o cano
			transform.Translate (Vector2.left * velocidade * Time.deltaTime);
			if (transform.position.x <= limiteX) {
				transform.position = new Vector2 (limiteX * -1, 
					Random.Range (alturaInicial, alturaFinal));
			}
		}
	}
}
