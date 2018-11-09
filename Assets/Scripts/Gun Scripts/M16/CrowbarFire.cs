using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowbarFire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){
			//AudioSource gunsound = gameObject.GetComponent<AudioSource> ();
			//gunsound.Play ();
			gameObject.GetComponent<Animation> ().Play ("crowbarswing");
	}
}
}
