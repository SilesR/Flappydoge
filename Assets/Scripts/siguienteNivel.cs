using UnityEngine;
using System.Collections;

public class siguienteNivel : MonoBehaviour {

	public string nivel = "Pollo2";

	// Use this for initialization
		void OnTriggerEnter2D(Collider2D other){
		Siguiente ();
		}
	public void Siguiente(){
		Application.LoadLevel (nivel);
	}
}
