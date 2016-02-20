using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {

	void Start () {
	
	}

	void FixedUpdate () {
		Vector2 mouse = Camera.main.ScreenToWorldPoint (Input.mousePosition);
		float anglerad = Mathf.Atan2 (mouse.y - transform.position.y, mouse.x - transform.position.x);
		float angledeg = (180 / Mathf.PI) * anglerad;
		transform.rotation = Quaternion.Euler (0, 0, angledeg);
	}
}
