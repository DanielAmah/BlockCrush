using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BlockCollision : MonoBehaviour {

	public int life;
	public String obTag;
	public int points;

	// Use this for initialization
	void Start () {
		obTag = "unknown";
		life = 5;
		points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		obTag = col.gameObject.tag;
		if (col.gameObject.tag == "fireObstacle"){
			life -= 1;

		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "coins") {
			points += 10;
			Destroy (other.gameObject);
		}
	}
		
}
