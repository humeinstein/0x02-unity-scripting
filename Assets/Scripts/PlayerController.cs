using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;

	public float speed = 55f;

	// Use this for initialization
	void Start () {

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
