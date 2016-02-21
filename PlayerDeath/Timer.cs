using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Timer : MonoBehaviour {

// set duration time in seconds in the Inspector
	float timer = 10; 

	public Text time;

	public Game_Over over;

	void Update() { 
		timer -= Time.deltaTime; 
		if (timer > 0) { 
			time.text = "Time: " + timer; 
		} else { 
			over.gameOver = true;  
		} 
	}
}
