using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheDarkGame : MonoBehaviour {

	float distance;
	float prevDist;
	Vector3 location_home;
	Vector3 location_player;
	bool gameOver = false;


	// Use this for initialization
	void Start () {
		print ("Welcome to In The Dark");
		print ("A game where you need to search for a way out of the dark.\n");
		print ("You hear a voice calling.");

		//Set start location
		location_player = new Vector3(Random.Range(-6,6),Random.Range(-6,6), 0.0f);
		location_home = new Vector3(Random.Range(-6,6),Random.Range(-6,6), 0.0f);

	}
	
	// Update is called once per frame
	void Update () {
		if(!gameOver){
			MoveCharacter(KeyCode.LeftArrow, new Vector3(-1f, 0f, 0f));
			MoveCharacter(KeyCode.RightArrow, new Vector3(1f, 0f, 0f));
			MoveCharacter(KeyCode.DownArrow, new Vector3(0f, -1f, 0f));
			MoveCharacter(KeyCode.UpArrow, new Vector3(0f, 1f, 0f));
		}

	}

	private void PrintDistanceToExit(){
		
		//Calculate distance from home
		distance = Vector3.Magnitude(location_player - location_home);
		distance = (location_player - location_home).magnitude;
		if(location_player == location_home){
			print ("You reach the voice! A light is shining on\n an old parrot talking to itself.");
			gameOver = true;
		}else if (distance > prevDist) {
			print ("The voice is getting quiter. You must be moving farther from the voice");

			//Print distance from home 
			//print("The voice seems to be about " + distance.ToString("F1") + " meters away");
		} else if (distance < prevDist) {
			print ("The voice is getting louder. You must be getting closer");

			//Print distance from home 
			//print("The voice seems to be about " + distance.ToString("F1") + " meters away");
		} 
		prevDist = distance;




	}



	private void MoveCharacter(KeyCode key, Vector3 movementVector){
		//Read player's move.
		if(Input.GetKeyDown(key)){
			location_player += movementVector;
			PrintDistanceToExit ();
			//print (location_player);
		}
			
	}

}
