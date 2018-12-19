using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpRocket : MonoBehaviour {

	// Use this for initialization
	public GameObject LoudSpeaker;
	public GameObject MenuOption;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(){
		LoudSpeaker.GetComponent<Text> ().text = "Press X to pickup Blaster";
		if (Input.GetKeyDown(KeyCode.X)) {
			GameManager.instance.RocketEnabled = true;
			GunManager.instance.DisableGuns ();
			int thegun = (int)GunManager.Weapons.Rocket;
			MenuOption.SetActive (true);
			GunManager.instance.EnableGun (thegun);
		}
    }
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
}

