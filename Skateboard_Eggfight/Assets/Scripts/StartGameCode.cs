using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameCode : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void onEasyGame(){
		NPC.spawnTime = 6.0f;
		RemainingEggs.eggs = 20;
		SceneManager.LoadScene("SkateParkMain");

	
	}

	public void onHardGame(){
		NPC.spawnTime = 3.0f;
		RemainingEggs.eggs = 10;
		SceneManager.LoadScene("SkateParkMain");


	}

}
