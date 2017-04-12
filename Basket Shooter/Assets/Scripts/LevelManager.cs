using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	// Use this for initialization
	void Start () {
		


	}
	
	// Update is called once per frame
	void Update () {
		LoadNextScene (KeyCode.Space);
	}

	void LoadNextScene(KeyCode key){
		if(Input.GetKeyDown(key)){
			//Load Scene
			int currentIndex = SceneManager.GetActiveScene().buildIndex;
			//load current index + 1
			SceneManager.LoadScene(currentIndex+1);
		}
	}
}
