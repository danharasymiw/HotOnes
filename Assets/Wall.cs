using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
	public GameObject moveToLocation;

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.name == "evans") {
			coll.gameObject.transform.position = moveToLocation.transform.position;
		}
	}
}

