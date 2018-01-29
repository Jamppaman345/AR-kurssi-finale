using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingClickThingy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	void OnMouseDown(){
		gameObject.GetComponent<Renderer> ().material.color = Color.blue;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			gameObject.GetComponent<Renderer> ().material.color = Color.magenta;
		}
	}
}
