using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switch : MonoBehaviour {

	// Use this for initialization
	public int switchNumber;
	public GameObject SwitchAlert;
	public bool ON;
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//Debug.Log(GameManager.instance.switches[switchNumber]);
	}
    void OnTriggerStay(){
		if (!ON) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to toggle switch";
		}
		if (Input.GetKeyDown ("x") && !ON) {
			GameManager.instance.switchon (switchNumber);
			StartCoroutine (Switchcount (3));
			ON = true;
		}
    }
	void OnTriggerEnter(){
		if (!ON) { 
			SwitchAlert.GetComponent<Text> ().text = "Press X to toggle switch";
		}
	}
	void OnTriggerExit(){
		if (!ON) {
			SwitchAlert.GetComponent<Text> ().text = "";
		}
	}

	IEnumerator Switchcount (float delay) {
		ON = true;
		int Switchoncount = GameManager.instance.ActiveSwitches;
		SwitchAlert.GetComponent<Text> ().text = "Number of switches on: " +Switchoncount + "/3";
		yield return new WaitForSeconds (delay);
		SwitchAlert.GetComponent<Text> ().text ="";
	}
}
