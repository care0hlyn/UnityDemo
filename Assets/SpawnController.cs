using UnityEngine;
using System.Collections;

public class SpawnController : MonoBehaviour {

	public GameObject enemy;
	private float timeSinceLast;

	void Start() {
		timeSinceLast = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// if enough time has passed
		if (timeSinceLast + 1.0f < Time.timeSinceLevelLoad) {
			// spawn an enemy
			GameObject enemyClone = (GameObject)Instantiate(enemy, new Vector3(transform.position.x + Random.Range(-5, 5), transform.position.y, transform.position.z), transform.rotation);
			// move it forward 
			enemyClone.GetComponent<Rigidbody>().velocity = new Vector3(0,0,-10);
			// update
			timeSinceLast = Time.timeSinceLevelLoad;
		}

	
	}
}
