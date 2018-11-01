using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SniperRoomSwitch : MonoBehaviour {

	// Use this for initialization
	public GameObject SwitchAlert;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}
	void OnTriggerStay(){
		if (GameManager.instance.OpenSniperRoom == false) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to open Special Weapons Storage";
			if (Input.GetKeyDown ("x")) {
				GameManager.instance.OpenSniperRoom = true;
			}
		} else {
			SwitchAlert.GetComponent<Text> ().text = "Special Weapons Storage is open";
		}
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
}
