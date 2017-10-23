using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void ButtonPush() {
		if(Application.loadedLevelName == "gameOver"){
			SceneManager.LoadScene ("main");
		}else if(Application.loadedLevelName == "clear"){
			SceneManager.LoadScene ("main");
		}
	}
}
