using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class BlockCollision : MonoBehaviour {

	public int life;
	public String obTag;
	public int points;
	public Text score;
	public String scoreText;
	// Use this for initialization
	void Start () {
		obTag = "unknown";
		life = 5;
		points = 0;
		scoreText = "Score: ";
		setScoreText ();
		// score.text = "Score: " + points.toString ();
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
			setScoreText ();
			// score.text = "Count: " + points.ToString ();
			Destroy (other.gameObject);
		}
	}
	void setScoreText() {
		score.text = scoreText + points.ToString ();
	}
}
