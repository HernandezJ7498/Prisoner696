using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrowbarPickup : MonoBehaviour {

	// Use this for initialization
    public GameObject SwitchAlert;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(){
		SwitchAlert.GetComponent<Text>().text = "Press X to pick up crowbar";
        if (Input.GetKeyDown("x")) {
			GunManager.instance.DisableGuns ();
			int thegun = (int)GunManager.Weapons.Crowbar;
			GunManager.instance.EnableGun (thegun);
		}
	}
    void OnTriggerExit(){
        SwitchAlert.GetComponent<Text>().text = "";
    }
}
