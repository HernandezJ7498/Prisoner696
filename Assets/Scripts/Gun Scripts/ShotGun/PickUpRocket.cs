using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpRocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
		if (Input.GetKeyDown(KeyCode.X)) {
			GunManager.instance.DisableGuns ();
			int thegun = (int)GunManager.Weapons.Rocket;
			GunManager.instance.EnableGun (thegun);
		}
    }
}

