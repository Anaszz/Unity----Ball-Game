using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class portal : MonoBehaviour {


	public AudioSource sound;

	// Use this for initialization
	void Start () {

		sound = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){

		if (collision.transform.tag == "player") {

			sound.Play (); 
		}
	}
}
