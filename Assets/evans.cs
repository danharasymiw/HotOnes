using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class evans : MonoBehaviour {
	public GameObject wing;


	float moveTimer = 0f;
	public float movementSpeed = 0.2f;
	public float minMoveTimer = 1f;
	public float maxMoveTimer = 2f;

	float moveDirection = 0f;

	public float wingTimer = 0f;
	public float maxWingTimer = 3f;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		moveTimer -= Time.deltaTime;
		if (moveTimer < 0) {
			moveTimer = Random.Range (minMoveTimer, maxMoveTimer);
			moveDirection = Random.Range(0, 1f);
			if (moveDirection > 0.5f) {
				moveDirection = 1f;
			} else {
				moveDirection = -1f;
			}
		}

		transform.Translate (moveDirection * movementSpeed, 0, 0);

		wingTimer -= Time.deltaTime;
		if (wingTimer < 0) {
			GameObject.Instantiate(wing, transform.position, Quaternion.identity);
			wingTimer = Random.Range (0, maxWingTimer);
		}
	}
}
