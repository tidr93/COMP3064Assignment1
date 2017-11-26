using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System;
using System.Timers;
using System.Threading;

public class Player {

	[SerializeField]
	private double timerDuration = 10000;

	private static Player instance;

	public static Player Instance{

		get{ 
		
			if (instance == null) {
			
				instance = new Player ();
			
			} return instance;
		
		}

	}
	private Player() {}
	public gameController gameController;

	private int score = 0;
	private int lives = 3;
	private bool poweredUp = false;

	public int Score{

		get { return score; }
		set { 
		
			score = value;
			gameController.updateUI ();
		
		}

	}

	public int Life{

		get { return lives; }
		set { 
		
			lives = value;

			if (lives <= 0) {
			
				gameController.gameOver ();
			
			} else {

				gameController.updateUI ();
			
			}
		
		}

	}

	public bool PoweredUp {

		get { return poweredUp; }
		set { 
		
			if (value == true) {
			
				poweredUp = value;
				buffDuration ();
			
			} else 
			poweredUp = value;

		
		}

	}

	private void buffDuration() {
		// Buff timer 
		System.Timers.Timer buffTimer = new System.Timers.Timer (timerDuration);
		buffTimer.Elapsed += BuffTimer_Elapsed;
		buffTimer.Start();
	
	}

	void BuffTimer_Elapsed (object sender, ElapsedEventArgs e)
	{
		Player.Instance.PoweredUp = false;
	}

}
