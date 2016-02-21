using UnityEngine;
using System.Collections;

public class Blinker : MonoBehaviour {

	public float minWait;
	public float maxWait;

	public float minBlinkspeed;
	public float maxBlinkspeed;

	void Start (){
		StartCoroutine (Blink ());
	}

	private IEnumerator Blink () {
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (Random.Range(minBlinkspeed, maxBlinkspeed));
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (Random.Range(minWait, maxWait));
		GetComponent<SpriteRenderer> ().enabled = false;
		yield return new WaitForSeconds (Random.Range(minBlinkspeed, maxBlinkspeed));
		GetComponent<SpriteRenderer> ().enabled = true;
		yield return new WaitForSeconds (Random.Range(minWait, maxWait));
		StartCoroutine (Blink ());
	}
}
