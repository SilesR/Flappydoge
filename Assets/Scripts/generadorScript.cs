using UnityEngine;
using System.Collections;

public class generadorScript : MonoBehaviour {
	public GameObject[] columna;
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

			var altura = Random.Range(-1.5f,1.5f);
			var tipocolumna = Random.Range(0,columna.Length);
			var nuevacolumna = (GameObject)Instantiate(columna[tipocolumna],new Vector3 (posicion.x, posicion.y+altura, posicion.z),transform.rotation);

			timer = Time.time+tiempoespera;

			Destroy(nuevacolumna, tiempoespera*3);

			timer=Time.time+tiempoespera;
				}
	}
}
