using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIScript : MonoBehaviour {
	public Text txtPontos;
	// Update is called once per frame
	void Update () {
		txtPontos.text = Principal.pontos.ToString();
		
	}
}
