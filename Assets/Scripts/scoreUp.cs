using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class scoreUp : MonoBehaviour {

	public Text texto;
	void Start(){
				texto = GameObject.Find ("textonivel").GetComponent<Text> ();
		}

	void OnTriggerEnter2D(Collider2D col){
				
		GameControl.score = GameControl.score + 1;

		texto.text = "Level " + GameControl.score.ToString ();

		}

	// Update is called once per frame
	void Update () {
	
	}
}
