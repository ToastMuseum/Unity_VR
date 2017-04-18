using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChargeShot : MonoBehaviour {
	public GameObject ballPrefab;
	public float ballSpeed = 5.0f;

	public Vector3 arcShot = new Vector3 (0f,0.4f,0f);

	public float maxLaunchSpeed;
	//public AudioClip chargeShot;
	public AudioClip launchSound;

	private float speedIncreasePerFrame;
	[SerializeField]
	private float launchSpeed;
	private AudioSource audioSource;


	[SerializeField]
	private Stat chargeBar;

	private void Awake(){
		chargeBar.MaxVal = maxLaunchSpeed-launchSpeed;
		chargeBar.Initialize ();
		//chargeBar.MaxVal = maxLaunchSpeed-launchSpeed;


	}


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

			InstantiateBall ((Vector3.forward + arcShot)*launchSpeed);

			launchSpeed = 10;
			chargeBar.CurrVal = 0;
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

			chargeBar.CurrVal +=speedIncreasePerFrame;
		}
	}




}
