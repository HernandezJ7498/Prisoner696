using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketFire : MonoBehaviour {

	// Use this for initialization
	public GameObject Crosshair;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0) && Crosshair.GetComponent<targetController>().lockedOn){
			//AudioSource gunsound = gameObject.GetComponent<AudioSource> ();
			//gunsound.Play ();
			//gameObject.GetComponent<Animation> ().Play ("Rocket");
	}
}
}
