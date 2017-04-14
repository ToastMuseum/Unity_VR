using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryTrigger : MonoBehaviour {

	Collider expectedCollider;
	public int targetWorth = 1;

	void OnTriggerEnter(Collider otherCollider){
		
		if(otherCollider == expectedCollider){
			ScoreKeeper scorekeeper = FindObjectOfType<ScoreKeeper> ();
			scorekeeper.IncrementScore (targetWorth);
		}
	}

	public void ExpectCollider(Collider collider){
		expectedCollider = collider;
	}
}
