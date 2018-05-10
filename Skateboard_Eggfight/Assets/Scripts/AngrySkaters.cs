using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class AngrySkaters : MonoBehaviour {
	public static TextMeshPro text;
	public static int points = 0;
	public static int necesaryPoints = 5;
	// Use this for initialization
	void Start () {
		 text = GetComponent<TextMeshPro>();
		text.text = "Angry Skaters: " + points;
	}
	
	// Update is called once per frame
	void Update () {

	}

	public static void addOnePoint(){
		points += 1;
		text.text = "Angry Skaters: " + points;
		if (points >= necesaryPoints) {
			Skater.endGame = "angry";
			SceneManager.LoadScene("EndScene");
		}
	
	}
}
