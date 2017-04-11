using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballPrefab;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		float speed = 5.0f;
		InstantiateBall (KeyCode.RightArrow, Vector3.right*speed);
		InstantiateBall (KeyCode.LeftArrow, Vector3.left*speed);
		InstantiateBall (KeyCode.UpArrow, Vector3.up*speed);
		InstantiateBall (KeyCode.DownArrow, Vector3.down*speed);
		
	}

	void InstantiateBall (KeyCode key, Vector3 initialVelocity){
		if (Input.GetKeyDown (key)) {
			GameObject instance = Instantiate (ballPrefab);
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = initialVelocity;		
		}
	}

}

