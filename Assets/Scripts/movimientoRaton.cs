using UnityEngine;
using System.Collections;

public class movimientoRaton : MonoBehaviour {
	public int vhorizontal = 10;
	public int vvertical = 10;
	
	Vector3 movimiento;
	Vector3 posicionRaton;
	// Update is called once per frame
	void Update () {
		

		posicionRaton = Input.mousePosition;
		posicionRaton = Camera.main.ScreenToWorldPoint (posicionRaton);
		if (Input.GetMouseButton (0)) {
			transform.position = Vector2.Lerp (transform.position, posicionRaton, vvertical*0.01f);
		}
	}
}
	