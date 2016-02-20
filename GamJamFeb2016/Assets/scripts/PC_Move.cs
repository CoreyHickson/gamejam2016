using UnityEngine;
using System.Collections;

public class PC_Move : MonoBehaviour {
	
	public float speed;
	private float x_input;
	private float y_input;


	void Start () {
		
	}

	void Update () {
		Debug.Log (x_input);
	}

	void FixedUpdate () {
		x_input = Input.GetAxis ("Vertical");
		y_input = Input.GetAxis ("Horizontal");
		transform.Translate (speed * x_input, speed * y_input, transform.position.z);
	}
}
