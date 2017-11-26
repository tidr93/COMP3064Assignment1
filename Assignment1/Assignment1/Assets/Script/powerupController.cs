using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupController : MonoBehaviour {

	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightX;
	[SerializeField]
	private float topY;
	[SerializeField]
	private float botY;
	[SerializeField]
	float minSpeed;
	[SerializeField]
	float maxSpeed;

	private Transform _transform;
	private Vector2 _currentPosition;
	private Vector2 _currentSpeed;

	// Use this for initialization
	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		Reset ();
		
	}
	
	// Update is called once per frame
	void Update () {

		_currentPosition = _transform.position;
		_currentPosition -= _currentSpeed;
		_transform.position = _currentPosition;

		if (_currentPosition.x <= -2)
			Reset ();
		
	}

	public void Reset() {
	
		float speed = Random.Range (minSpeed, maxSpeed);

		_currentSpeed = new Vector2 (speed, 0);

		float y = Random.Range (topY, botY);
		_transform.position = new Vector2 (rightX + Random.Range (15, 20), y);
	
	}


}
