using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotation : MonoBehaviour {

	public GameObject head;

	// Use this for initialization
	void Start () {
		//transform.rotation = Quaternion.Euler (0, 90, 0);


	}
	
	// Update is called once per frame
	void Update () {
		VRRotation ();
	}

	void NonVRRotation(){
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X")*rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y")*rotationSpeed;
		// multiplying two quaternions results in an addition of angles
		transform.rotation *= Quaternion.Euler (0, mouseX, 0);

		Camera camera  = GetComponentInChildren<Camera> ();
		camera.transform.localRotation *= Quaternion.Euler (-mouseY, 0, 0);
	}

	void VRRotation(){
		float rotationSpeed = 5.0f;
		float mouseX = Input.GetAxis ("Mouse X")*rotationSpeed;
		float mouseY = Input.GetAxis ("Mouse Y")*rotationSpeed;
		// multiplying two quaternions results in an addition of angles
		transform.rotation *= Quaternion.Euler (0, mouseX, 0);

		head.transform.localRotation *= Quaternion.Euler (-mouseY, 0, 0);
	
	}
}
