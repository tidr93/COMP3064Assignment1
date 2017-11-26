using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btnController : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SceneManager.LoadScene (0);

	}

	void Game() {
	
		SceneManager.LoadScene (1);
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
