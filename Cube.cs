using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other) {
		Debug.Log("osuma");
		gameObject.GetComponent<Renderer> ().material.color = Color.cyan;
	}
	void OnTriggerExit(Collider other)
	{
		gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
	}
}
