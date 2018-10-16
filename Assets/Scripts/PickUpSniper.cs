using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpSniper : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
		if (Input.GetKeyDown("x")) {
			GunManager.instance.DisableGuns ();
			int thegun = (int)GunManager.Weapons.Sniper;
			GunManager.instance.EnableGun (thegun);
		}
    }
}
