using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingMove : MonoBehaviour {

	public float speed;             		//liikkumis nopeus (säädetään inspectorissa)
	private Rigidbody rb;       			//referenssi pelaajan rigidbodyyn
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> (); 			//haetaan pelaajan rigidbody2d scenestä
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal"); 			//vaaka suuntainen komponentti
		float moveVertical = Input.GetAxis ("Vertical"); 				//pysty suuntainen komponentti
		Vector3 movement = new Vector3 (moveHorizontal, moveVertical, 0);	//liikkeen suuntavektori
		rb.AddForce (movement * speed); 								//liikkeen suuruus ja implementointi
		if(transform.position.y < -6 || transform.position.y > 6 || transform.position.x < -10 || transform.position.x > 10){	//jos ruudun ulkopuolella
			transform.position = new Vector3(0, 0, 0);												//nollataan sijainti
		}
	}
}
