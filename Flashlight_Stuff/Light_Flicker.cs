using UnityEngine;
using System.Collections;

public class Light_Flicker : MonoBehaviour {

// Control the speed of flickering
	private float minFlickerspeed;
	private float maxFlickerspeed;
// For resetting flicker possibility
	public Battery battery;

//Flickerspeed cannot be adjusted from outside
	void Start() {
		minFlickerspeed = 0.1f;
		maxFlickerspeed = 0.5f;
	}

// Flicker is called to flicker the light
	public void Flicker () {
			StartCoroutine (Flickerspeed ());
	}

// The light flickers randomly, based on the flickerspeed
	private IEnumerator Flickerspeed () {
		yield return new WaitForSeconds (Random.Range(minFlickerspeed,maxFlickerspeed));
		GetComponent<Light>().intensity = 0.0f;
		yield return new WaitForSeconds (Random.Range(minFlickerspeed,maxFlickerspeed));
		GetComponent<Light>().intensity = 2.0f;
		yield return new WaitForSeconds (Random.Range(minFlickerspeed,maxFlickerspeed));
		GetComponent<Light>().intensity = 0.0f;
		yield return new WaitForSeconds (Random.Range(minFlickerspeed,maxFlickerspeed));
		GetComponent<Light>().intensity = 2.0f;
		battery.isFlicker = false;
	}
}