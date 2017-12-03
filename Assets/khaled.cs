using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class khaled : MonoBehaviour {

    public float movementSpeed = 0.5f;
    public int health = 100;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<Rigidbody2D> ().velocity = new Vector2 ();
        float xAxis = Input.GetAxis("Horizontal");
        float yAxis = Input.GetAxis("Vertical");

        transform.Translate(movementSpeed * xAxis, movementSpeed * yAxis, 0);
    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "wing")
        {
            health -= coll.gameObject.GetComponent<Wing>().damage;
        }
    }
}
