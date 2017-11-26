using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundController : MonoBehaviour {

	[SerializeField]
	private float scrollSpeed;
	private Transform _transform;
	private Vector2 _currentPosition;

	// Use this for initialization
	void Start () {
		_transform = gameObject.GetComponent<Transform>();
		_currentPosition = _transform.position;
		Reset ();
	}
	
	// Update is called once per frame
	void Update () {
		_currentPosition = _transform.position;

		_currentPosition -= new Vector2 (scrollSpeed, 0);

		_transform.position = _currentPosition;

		if (_currentPosition.x <= -700)
			Reset ();
	}

	private void Reset() {
	
		_currentPosition = new Vector2 (1000f, 0);
		_transform.position = _currentPosition;

	}
}
