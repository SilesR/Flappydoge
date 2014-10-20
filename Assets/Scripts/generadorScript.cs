using UnityEngine;
using System.Collections;

public class generadorScript : MonoBehaviour {
	public GameObject columna;
	public float tiempoespera = 3;
	Vector3 posicion;
	float timer = 0;
	// Use this for initialization
	void Start () {
		posicion = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > timer) {
			var nuevacolumna = (GameObject)Instantiate(columna, posicion, transform.rotation);
			timer = Time.time+tiempoespera;
				}
	}
}
