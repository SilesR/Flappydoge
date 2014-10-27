using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreUp : MonoBehaviour {

	public Text texto;
	public Text puntosFinal;

	void Start(){
				texto = GameObject.Find ("textonivel").GetComponent<Text> ();
		puntosFinal= GameObject.Find ("puntosFinal").GetComponent<Text> ();
		}

	void OnTriggerEnter2D(Collider2D col){
				
		GameControl.score = GameControl.score + 1;

		texto.text = "Level " + GameControl.score.ToString ();
		puntosFinal.text = texto.text;
		}

	// Update is called once per frame
	void Update () {
	
	}
}
