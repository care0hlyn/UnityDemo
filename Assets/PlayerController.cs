using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {
		// if the left button is down
		if (Input.GetKey ("left")) {
			// move ball to the left
			GetComponent<Rigidbody> ().velocity = new Vector3 (-speed, 0, 0);
			// if the right button is down
		} else if (Input.GetKey ("right")) {
			// move the ball to the right
			GetComponent<Rigidbody> ().velocity = new Vector3 (speed, 0, 0);
		} else {
			GetComponent<Rigidbody> ().velocity = new Vector3 (0, 0, 0);
		}
			
	}

	// when an object collides 
	void OnTriggerEnter(Collider other) {
		// if it is a enemy 
		if (other.CompareTag ("Enemy")) {
			Destroy (gameObject);
		}
		// destroy player
	
	}

}

