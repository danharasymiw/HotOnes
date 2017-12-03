using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dumpster : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D coll) {
		Destroy (coll.gameObject);
	}
}
