using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCollision : MonoBehaviour {

	//[SerializeField]
	//GameController gameController;

	private AudioSource impactSound;

	// Use this for initialization
	void Start () {
		impactSound = gameObject.GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnTriggerEnter2D(Collider2D other) {
	
		if (impactSound != null) {
		
			impactSound.Play ();
		
		}
			

		if (other.gameObject.tag.Equals ("Enemy")) {

			Debug.Log ("collided with bird");

			// if powered up, kill bird and add score
			if (Player.Instance.PoweredUp == true) {
			
				other.gameObject.GetComponent<enemyController> ().Reset ();
				Player.Instance.Score += 1;
				
			
			} else {

				other.gameObject.GetComponent<enemyController> ().Reset ();
				Player.Instance.Life -= 1;
			
			}
		
		} else if (other.gameObject.tag.Equals ("Buff")) {
		
			Debug.Log ("Collided with power up");

			other.gameObject.GetComponent<powerupController> ().Reset ();
			Player.Instance.Score += 1;
			if (Player.Instance.Score % 5 == 0) {
			
				// enter powerup mode, can kill birds for points
				Player.Instance.PoweredUp = true;
			
			}
		
		}
	
	}
}
