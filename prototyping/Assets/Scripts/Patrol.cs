using UnityEngine;
using System.Collections;

public class Patrol : MonoBehaviour {
    public int movementSpeed;
    public bool isMoveVertical;
    public bool isMoveHorizontal;
    private Vector2 vector;

	// Use this for initialization
	void Start () {
        vector = Vector2.right;
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position.x < -5) {
            vector = Vector2.right;
        }
        else if (transform.position.x > 5)
        {
            vector = Vector2.left;
        }

        transform.Translate(vector * movementSpeed * Time.deltaTime);
	}
}
