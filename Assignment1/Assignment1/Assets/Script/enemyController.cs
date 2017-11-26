using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

	[SerializeField]
	private float leftX;
	[SerializeField]
	private float rightX;
	[SerializeField]
	private float topY;
	[SerializeField]
	private float botY;

	[SerializeField]
	float minSpeed = -1f;
	[SerializeField]
	float maxSpeed = 1f;

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

		if (_currentPosition.x < -10)
			Reset ();

	}

	public void Reset() {

		float randomSpeed = Random.Range (minSpeed, maxSpeed);

		_currentSpeed = new Vector2 (randomSpeed, 0);

		float y = Random.Range (botY, topY);
		_transform.position = new Vector2 (rightX + Random.Range (0,100), y);

	}
}
