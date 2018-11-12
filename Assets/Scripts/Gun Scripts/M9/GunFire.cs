using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunFire : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GlobalAmmo.LoadedAmmo >= 1) {		
			if (Input.GetMouseButtonDown (0)) {
				AudioSource gunsound = gameObject.GetComponent<AudioSource> ();
				gunsound.Play ();
				gameObject.GetComponent<Animation> ().Play ("GunShot");
				GlobalAmmo.LoadedAmmo -= 1;
			}
		}
	}
}
