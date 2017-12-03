using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wing : MonoBehaviour {

    public int damage = 20;
	public float maxRotationSpeed = 100f;

	void Start() {
		float rotationSpeed = Random.Range (-maxRotationSpeed, maxRotationSpeed);
		GetComponent<Rigidbody2D>().AddTorque(rotationSpeed);
	}
}
