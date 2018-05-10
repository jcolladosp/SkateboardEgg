using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndSceneCode : MonoBehaviour {
	public Text result;
	public Text subtext;
	// Use this for initialization
	void Start () {
		if (Skater.endGame == "collision") {
			result.text = "You lost!";
			subtext.text = "You collided with your friend";
		} else if (Skater.endGame == "angry") {
			result.text = "You lost!";
			subtext.text = "You have upset many skaters";
		
		}
		else if (Skater.endGame == "noEggs") {
			if (Points.points >= EnemyPoints.points) {
				result.text = "You won!";
				subtext.text = "You hit: " + Points.points + " and your friend: " + EnemyPoints.points;

			} else {
				result.text = "You lost!";
				subtext.text = "You hit: " + Points.points + " and your friend: " + EnemyPoints.points;

			}

			subtext.text = "You hit: " + Points.points + " and your friend: " + EnemyPoints.points;


		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
