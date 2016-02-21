using UnityEngine;
using System.Collections;

public class GameStart : MonoBehaviour {

// Script starts by pausing game
	void Start () {
		Time.timeScale = 0;
	}


	void Update () {
// Once anything is pressed game starts
		if (Input.anyKeyDown) {
			Destroy (gameObject, 0.25f);
			Time.timeScale = 1;
		}
	}
}
