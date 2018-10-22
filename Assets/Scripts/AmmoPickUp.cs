using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(Collider other){
		//playsound
		if (GlobalAmmo.LoadedAmmo == 0) {
			GlobalAmmo.LoadedAmmo += 10;
			this.gameObject.SetActive (false);
		}
		else
			GlobalAmmo.CurrentAmmo += 10;
			this.gameObject.SetActive (false);
	}
}
