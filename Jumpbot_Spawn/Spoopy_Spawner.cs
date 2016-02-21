using UnityEngine;
using System.Collections;

public class Spoopy_Spawner : MonoBehaviour {

	private float rand;
	public GameObject computer;
	public GameObject jumper;

	void Start () {
		rand = Random.Range (0, 50);
		if (rand > 42) {
			Instantiate (jumper, transform.position, transform.rotation);
		} else {
			Instantiate (computer, transform.position, transform.rotation);
		}
	}
}
