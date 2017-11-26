using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour {

	[SerializeField]
	GameObject player;
	[SerializeField]
	GameObject bird;
	[SerializeField]
	GameObject powerup;

	[SerializeField]
	Text lblLives;
	[SerializeField]
	Text lblScore;
	[SerializeField]
	Text lblGameOver;
	[SerializeField]
	Button btnReset;

	public void init() {

		Player.Instance.Score = 0;
		Player.Instance.Life = 3;
		lblGameOver.gameObject.SetActive (false);
		btnReset.gameObject.SetActive (false);

		lblLives.gameObject.SetActive (true);
		lblScore.gameObject.SetActive (true);

	}

	public void gameOver() {

		lblGameOver.gameObject.SetActive (true);
		btnReset.gameObject.SetActive (true);
		lblLives.gameObject.SetActive (false);
		lblScore.gameObject.SetActive (false);


	}

	public void updateUI() {

		lblScore.text = "Score: " + Player.Instance.Score;
		lblLives.text = "Lives: " + Player.Instance.Life;

	}

	// Use this for initialization
	void Start () {

		Player.Instance.gameController = this;
		init ();

	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
