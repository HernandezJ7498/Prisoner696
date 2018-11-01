using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ElevatorPower : MonoBehaviour {

	// Use this for initialization
	public GameObject SwitchAlert;
	//bool isswitchon = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (GameManager.instance.ElevatorPower);
	}
	void OnTriggerStay(){
		if (GameManager.instance.ElevatorPower == false) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to turn the elevator power on";
			if (Input.GetKeyDown ("x")) {
				GameManager.instance.ElevatorPower = true;
				//isswitchon = true;
			}
		} else {
			SwitchAlert.GetComponent<Text> ().text = "Press X to turn the elevator power off";
			if (Input.GetKeyDown ("x")) {
				GameManager.instance.ElevatorPower = false;
				//isswitchon = false;
			}
		}

	}
	void OnTriggerExit(){
			SwitchAlert.GetComponent<Text> ().text = "";
	}
}
