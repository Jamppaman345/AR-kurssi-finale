using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour {

	public Slider slider;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey ("space")) {
			slider.value = Mathf.MoveTowards (slider.value, 1.0f, 15f);
		} else {
			slider.value = Mathf.MoveTowards (slider.value, 0.0f, 15f);
		}
	}
}
