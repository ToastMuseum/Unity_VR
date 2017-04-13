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
		//InstantiateBall (KeyCode.RightArrow, Vector3.right*speed);
		//InstantiateBall (KeyCode.LeftArrow, Vector3.left*speed);
		//InstantiateBall (KeyCode.UpArrow, Vector3.up*speed);
		//InstantiateBall (KeyCode.DownArrow, Vector3.down*speed);
		InstantiateBall (KeyCode.UpArrow,"Fire1", Vector3.forward*speed);
	}

	void InstantiateBall (KeyCode key, string button, Vector3 initialVelocity){
		if (Input.GetKeyDown (key)) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = initialVelocity;		
		}
		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;
			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = initialVelocity;
		}
	}

}

