using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.SceneManagement;

public class BlockCollision : MonoBehaviour {

	public int life;
	public int points;
	public Text score;
	public Text lives;
	public String obTag;
	public String scoreText;
	// Use this for initialization
	void Start () {
		obTag = "unknown";
		life = 5;
		points = 0;
		scoreText = "Score: ";
		setScoreText ();
		setLivesLeft ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){
		obTag = col.gameObject.tag;
		if (col.gameObject.tag == "fireObstacle"){
			if (life > 0) {
				life -= 1;
			}
			setLivesLeft ();

			if (life == 0){
				
				SceneManager.LoadScene(2); 
			}
		}

		if (col.gameObject.tag == "house"){
			SceneManager.LoadScene(3);
		}

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "coins") {
			points += 10;
			setScoreText ();
			setLivesLeft ();
			Destroy (other.gameObject);
		}
			

	}
	void setScoreText() {
		score.text = scoreText + points.ToString ();
	}
	void setLivesLeft() {
		switch (life) {
		case 1:
			lives.text = "❤";
			break;
		case 2:
			lives.text = "❤❤";
			break;
		case 3:
			lives.text = "❤❤❤";
			break;
		case 4:
			lives.text = "❤❤❤❤";
			break;
		case 5:
			lives.text = "❤❤❤❤❤";
			break;
		default:
			lives.text = "___";
			break;
		}
	}
}
