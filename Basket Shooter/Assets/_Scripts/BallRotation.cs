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
		player = GameObject.Find ("VRPlayer_HUD");
		if (!player) {
			print (player);
			player = GameObject.Find ("Player");
		}

		if(player){
			print (player);
			initialKick = player.transform.localRotation * Vector3.right;
		}

	}
	void BallSpin(){
		rigidBody = GetComponent<Rigidbody> ();
		rigidBody.angularVelocity = initialKick*-4000;
	}
}
