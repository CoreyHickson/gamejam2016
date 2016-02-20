using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	GameObject playah;

	// Use this for initialization
	void Start () {
		playah = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(playah.transform.position.x, playah.transform.position.y, transform.position.z);
	}
}
