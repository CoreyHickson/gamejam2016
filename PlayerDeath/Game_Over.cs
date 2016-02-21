using UnityEngine;
using System.Collections;

public class Game_Over : MonoBehaviour {

// Controls visibility of the game-over screen
	public SpriteRenderer see;

// To activate script
	public bool gameOver;

	private bool active;

	public GameObject player;

	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		gameOver = false;
		see = GetComponent<SpriteRenderer> ();
		see.enabled = false;
		active = false;
	}


	void Update () {
		if (gameOver) {
			see.enabled = true;
			player.SetActive (false);
			if (!active) {
				active = true;
				StartCoroutine (next ());
			}
		}
	}

	IEnumerator next () {
		yield return new WaitForSeconds (10);
		Application.LoadLevel(0);
	}
}
