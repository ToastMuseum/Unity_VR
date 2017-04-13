using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour {

	public int score = 0;

	// Use this for initialization
	void Start () {
		// keeps component in next loaded scene
		DontDestroyOnLoad (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void IncrementScore(int targetWorth){
		score += targetWorth;
		print ("Score: " + score);
	}
}
