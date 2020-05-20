using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;

	public float speed = 55f;
	private int score = 0;
	public int health = 5;

	// Use this for initialization
	void Start () {

	}
	
	//onTriggerEnter (
		// incremenet val of score when player Pickup()
	//)
	void OnTriggerEnter(Collider other) {
		if (other.tag == "Pickup") {
			this.score += 1;
			Debug.Log("Score: " + score);
			Destroy(other.gameObject);

	
		if (other.tag == "Trap") {
			this.health -= 1;
			Debug.Log("Health: " + health);
			
						
		}

		}
	}

	// Update is called once per frame
	void FixedUpdate () {

	//Console.print("Gothere")
         	if (Input.GetKey(KeyCode.A))
             		rb.AddForce(Vector3.left * speed);
         	if (Input.GetKey(KeyCode.D))
             		rb.AddForce(Vector3.right * speed);
         	if (Input.GetKey(KeyCode.W))
         		rb.AddForce(Vector3.forward * speed);
         	if (Input.GetKey(KeyCode.S))
             		rb.AddForce(Vector3.forward * -speed);
		
	}
}
