using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ComputerOnSwitch : MonoBehaviour {

	// Use this for initialization
	public GameObject SwitchAlert;
	public GameObject ComputerLight;
	void Start () {

	}

	// Update is called once per frame
	void Update () {
	}
	void OnTriggerStay(){
		if (GameManager.instance.ComputersOn == false) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to Turn Computers On";
			if (Input.GetKeyDown ("x")) {
				GameManager.instance.ComputersOn = true;
				ComputerLight.SetActive (true);
			}
		} else {
			SwitchAlert.GetComponent<Text> ().text = "Computers are on";
		}
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
}
