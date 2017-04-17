using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeShot : MonoBehaviour {
	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;

	public float maxLaunchSpeed;
	//public AudioClip chargeShot;
	public AudioClip launchSound;

	private float speedIncreasePerFrame;
	[SerializeField]
	private float launchSpeed;
	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		audioSource.clip = launchSound;

		speedIncreasePerFrame = (maxLaunchSpeed * Time.fixedDeltaTime) / 2;
	}

	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButton(0)){
			ChargingShot ();
		}

		if(Input.GetMouseButtonUp(0)){	
			audioSource.Stop ();
			audioSource.clip = launchSound;
			audioSource.Play ();

			InstantiateBall (Vector3.forward*launchSpeed);

			launchSpeed = 10;
		}
		
	}

	void InstantiateBall (Vector3 initialVelocity){
		GameObject instance = Instantiate (ballPrefab);
		instance.transform.position = transform.position;

		//group ball instances into an empty game object
		instance.transform.parent = GameObject.Find ("Launched Balls").transform;

		Camera camera = GetComponentInChildren<Camera> ();

		Rigidbody rb = instance.GetComponent<Rigidbody> ();
		rb.velocity = camera.transform.rotation * initialVelocity;
	}

	void ChargingShot(){
		if (launchSpeed <= maxLaunchSpeed) {
			launchSpeed += speedIncreasePerFrame; 
		}
	}


}
