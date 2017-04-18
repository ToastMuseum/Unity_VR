using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public float countDown = 0.0f;

	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		
		if (countDown > 0) {
			countDown -= Time.deltaTime;

			if (countDown <= 0) {
				LoadNextScene ();
			}
		}
	}

	public void LoadNextScene(){
			//Load Scene
			int currentIndex = SceneManager.GetActiveScene().buildIndex;
			//load current index + 1
			SceneManager.LoadScene(currentIndex+1);
	}

	public void LoadPreviousLevel(){
		//Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentIndex-1);
	}

	public void LoadVRScene(){
		//Load Scene
		int currentIndex = SceneManager.GetActiveScene().buildIndex;
		//load current index + 1
		SceneManager.LoadScene(3);
	}
}
