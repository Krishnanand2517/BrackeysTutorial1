using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public Rigidbody rb;

	public float forwardForce = 1000f;
	public float sidewaysForce = 500f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// It is good practice to keep the physics in the FixedUpdate function
	void FixedUpdate() {
		rb.AddForce(0, 0, forwardForce * Time.deltaTime);		//to make it dependent on time, not frame rate
	
		if (Input.GetKey("d") || Input.GetKey("right")){
			rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (Input.GetKey("a") || Input.GetKey("left")){
			rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}
		if (rb.position.y < -1f){
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
