using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggImpulse : MonoBehaviour {
	public float impulseForce = 25.0f;


	private GameObject eggHand;


	// Use this for initialization
	void Start () {
		eggHand = GameObject.Find("eggHand");
		GetComponent<Rigidbody> ().AddRelativeForce ((-eggHand.transform.forward + new Vector3(0,0.3f,0)) * impulseForce, ForceMode.Impulse);

	}

	// Update is called once per frame
	void Update () {
		if (transform.position.y < 0.0f) {
			Destroy (gameObject);
		}
	}


	void OnCollisionEnter(Collision collision){
		if(collision.gameObject.tag == "enemy") {
			Points.addOnePoint ();
			Destroy (gameObject);

		}
		if(collision.gameObject.tag == "people") {
			AngrySkaters.addOnePoint ();
			Destroy (gameObject);

		}
	}

}
