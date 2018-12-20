using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	// Use this for initialization
	public int ButtonNumber;
	public GameObject SwitchAlert;
	public bool Triggered;
	bool worked;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerStay(){
		if (Input.GetKeyDown ("x")) {
			worked = GameManager.instance.buttontrigger (ButtonNumber);
			if (worked) {	
				StartCoroutine (ButtonCount (3));
				Triggered = true;
			} else {
				SwitchAlert.GetComponent<Text> ().text = "LoudSpeaker: *Incorrect order Alarm Sequence Halted*";
			}
			//Triggered = true;
		}
    }
	void OnTriggerEnter(){
		if (!Triggered) { 
			SwitchAlert.GetComponent<Text> ().text = "Press X to activate button";
		}
	}
	void OnTriggerExit(){
		if (!Triggered) {
			SwitchAlert.GetComponent<Text> ().text = "";
		}
	}

	IEnumerator ButtonCount (float delay) {
		Triggered = true;
		int Buttoncount = GameManager.instance.ActiveButtons;
		if (GameManager.instance.ActiveButtons == 1) {
			SwitchAlert.GetComponent<Text> ().text = "Loudspeaker: *" + Buttoncount + " buttons out of three triggered TIMER STARTED!*";
		} else if (GameManager.instance.ActiveButtons == 2) {
			SwitchAlert.GetComponent<Text> ().text = "Loudspeaker: *" + Buttoncount + " buttons out of three triggered*";
		} else {
			SwitchAlert.GetComponent<Text> ().text = "Loudspeaker: *Bridge is active*";
		}
		yield return new WaitForSeconds (delay);
		SwitchAlert.GetComponent<Text> ().text ="";
	}
}
