using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {

// Controls flickering of flashlight
	public bool isFlicker;
// Measure of remaining battery life
	private float battLife;
// Controls the speed of battery diminishing
	public float battRate;
// Indicates if flashlight is on or not
	public bool isOn;
// Flicker script for flickering flashlights
	public Light_Flicker flicker;
// Used to affect the odds of flashlight flicker
	private float random;

	public Transform blue;

	void Start () {
		GetComponent<Light> ().intensity = 0.0f;
		isFlicker = false;
		battLife = 100.0f;
// 10 for test, 5 or less for play
		battRate = 10.0f;
		isOn = false;
	}



	void Update () {
// Hold spacebar to turn light on or off
		if (Input.GetKey ("space") && !isFlicker && battLife > 0 && !isOn) {
			isOn = true;
			GetComponent<Light> ().intensity = 2.0f;
// When light is flickering, light should not flicker
			if (!isFlicker) {
				random = Random.Range (1.0f, 50.0f);
// Lower battery levels increase chance of flicker
				if (random > battLife) { 
					isFlicker = true;
					flicker.Flicker ();
				}
			}
		}
// Turns light off when light is on
		if (Input.GetKeyUp("space") && isOn) {
			isOn = false;
			GetComponent<Light> ().intensity = 0.0f;
		}
// Battery decreases when flashlight on or flickering
		if (isOn || isFlicker) {
			StartCoroutine(BattBurn());
		}
		blue.localScale = new Vector3(1.0f, (1.3f*(battLife / 100)), 1.0f);
	}


	void FixedUpdate () {
// Battery cannot be greater than 100% or less than 0%
//  if Battery greater than 100%, set to 100%
		if (battLife > 100.0f) {
			battLife = 100.0f;
		}
//  if Battery less than 0%, set to 0%
		if (battLife < 0) {
			battLife = 0;
		}
	}


// BattBurn controls the diminishing battery life
	IEnumerator BattBurn () {
		battLife -= battRate * Time.deltaTime;
		yield return new WaitForSeconds(0.1f);
	}
}