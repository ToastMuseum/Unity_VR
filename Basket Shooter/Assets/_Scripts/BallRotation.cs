using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallRotation : MonoBehaviour {

	public Vector3 initialKick;
	private Rigidbody rigidBody;

	public GameObject player;

	void OnEnable(){
		BallOrientation ();

		BallSpin ();
	}

	void BallOrientation (){
		player = GameObject.Find ("Player");
		if (!player) {
			player = GameObject.Find ("Main Camera");
		}

		if(player){
			initialKick = player.transform.localRotation * Vector3.right;
		}

	}
	void BallSpin(){
		rigidBody = GetComponent<Rigidbody> ();
		rigidBody.angularVelocity = initialKick*-4000;
	}
}
