using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallLauncher : MonoBehaviour {

	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		//InstantiateBall (KeyCode.RightArrow, Vector3.right*speed);
		//InstantiateBall (KeyCode.LeftArrow, Vector3.left*speed);
		//InstantiateBall (KeyCode.UpArrow, Vector3.up*speed);
		//InstantiateBall (KeyCode.DownArrow, Vector3.down*speed);
		InstantiateBall ("Fire1", Vector3.forward*ballSpeed);
	}

	void InstantiateBall (string button, Vector3 initialVelocity){

		if (Input.GetButtonDown ("Fire1")) {
			GameObject instance = Instantiate (ballPrefab);
			instance.transform.position = transform.position;

			Camera camera = GetComponentInChildren<Camera> ();

			Rigidbody rb = instance.GetComponent<Rigidbody> ();
			rb.velocity = camera.transform.rotation * initialVelocity;
		}
	}

}