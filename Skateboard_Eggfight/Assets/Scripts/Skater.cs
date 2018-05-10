using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Skater : MonoBehaviour {
	private bool isInsideTable = false;
	private bool hasEgg = false;
	public static string endGame = "";
	public GameObject egg;
	public GameObject eggInstancy;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp(KeyCode.E) && isInsideTable && !hasEgg)
		{
			hasEgg = true;
			egg.GetComponent<MeshRenderer> ().enabled = true;
			RemainingEggs.removeEgg ();

		}
		if (Input.GetKey (KeyCode.Mouse0) && hasEgg) {

			Instantiate (eggInstancy, egg.transform.position, Quaternion.identity);
			hasEgg = false;
			egg.GetComponent<MeshRenderer> ().enabled = false;

		}
	}

	void OnTriggerEnter(Collider other) {
		isInsideTable = true;
	}
	void OnTriggerExit(Collider other){
		isInsideTable = false;
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.CompareTag("enemy")) {
			endGame = "collision";
			SceneManager.LoadScene("EndScene");

		}
	}

}
