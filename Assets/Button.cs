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
		//Debug.Log(GameManager.instance.switches[switchNumber]);
	}
    void OnTriggerStay(){
		if (!Triggered) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to activate button";
		}
		if (Input.GetKeyDown ("x") && !Triggered) {
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
		SwitchAlert.GetComponent<Text> ().text = "Number of buttons triggered: " +Buttoncount + "/3";
		yield return new WaitForSeconds (delay);
		SwitchAlert.GetComponent<Text> ().text ="";
	}
}
