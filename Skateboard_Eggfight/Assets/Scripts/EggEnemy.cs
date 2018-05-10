using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggEnemy : MonoBehaviour {
	public GameObject player;

	public float impulseForce = 25.0f;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("FPSController");
		transform.LookAt (player.transform);
		GetComponent<Rigidbody> ().AddRelativeForce(transform.forward  * impulseForce, ForceMode.Impulse);

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "Player") {
			EnemyPoints.addOnePoint ();
			Destroy (gameObject);

		}
		if(collision.gameObject.tag == "floor") {
			Destroy (gameObject);

		}
	}
}
