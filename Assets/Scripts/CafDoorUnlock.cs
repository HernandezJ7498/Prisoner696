using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CafDoorUnlock : MonoBehaviour {

	// Use this for initialization
	public GameObject SwitchAlert;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}
	void OnTriggerStay(){
		if (GameManager.instance.CafDoorIsOpen == false) {
				SwitchAlert.GetComponent<Text> ().text = "Press X to open Cafeteria Storage Door";
			if (Input.GetKeyDown ("x")) {
				GameManager.instance.CafDoorIsOpen = true;
			}
		} 
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
}