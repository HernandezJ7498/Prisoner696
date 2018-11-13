using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour {

	// Use this for initialization
	public int ButtonNumber;
	public GameObject SwitchAlert;
	public bool Triggered;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}
    void OnTriggerStay(){
		if (Input.GetKeyDown ("x")) {
			GameManager.instance.buttontrigger (ButtonNumber);
			StartCoroutine (ButtonCount (3));
			Triggered = true;
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
		if (GameManager.instance.ActiveButtons <= 3) {
			SwitchAlert.GetComponent<Text> ().text = "Number of buttons triggered: " + Buttoncount + "/3";
		} else {
			SwitchAlert.GetComponent<Text> ().text = "Bridge is active";
		}
		yield return new WaitForSeconds (delay);
		SwitchAlert.GetComponent<Text> ().text ="";
	}
}
