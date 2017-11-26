using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour {

	[SerializeField]
	private float moveSpeed;
	[SerializeField]
	private float Height;
	[SerializeField]
	private float length;

	private Transform _transform;
	private Vector2 _currentPosition;
	private float _inputX;
	private float _inputY;

	private playerController instance;

	void Awake() {
	
		instance = gameObject.GetComponent<playerController> ();

	}

	void Start () {

		_transform = gameObject.GetComponent<Transform> ();
		_currentPosition = _transform.position;

	}
	
	// Update is called once per frame
	void Update () {

		_inputX = Input.GetAxis ("Horizontal");
		_inputY = Input.GetAxis ("Vertical");

		// move up/down left/right
		if (_inputX > 0 || _inputX < 0) { 
		
			_currentPosition += new Vector2 ((_inputX / Mathf.Abs(_inputX)) * moveSpeed, 0);
		
		} 
		if (_inputY > 0 || _inputY < 0) {
		
			_currentPosition += new Vector2 (0, (_inputY / Mathf.Abs (_inputY)) * moveSpeed);
		
		}
		checkBoundaries ();
		_transform.position = _currentPosition;

	}

	void checkBoundaries() {
	
		if (Mathf.Abs (_currentPosition.x) > length) {
		
			if (_currentPosition.x < 0)
				_currentPosition.x = -length;
			else if (_currentPosition.x > 200)
				_currentPosition.x = 200;
		
		}
		if (Mathf.Abs (_currentPosition.y) > Height) {
		
			if (_currentPosition.y < 0)
				_currentPosition.y = -Height;
			else
				_currentPosition.y = Height;
		
		}
	
	}
}
