using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainConsole : MonoBehaviour {

	// Use this for initialization
	bool itson;
	public GameObject SpotLights;
	public GameObject MainLights;
	public GameObject Blinds;
	public GameObject LoudSpeaker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if (!itson) {
			LoudSpeaker.GetComponent<Text> ().text = "Press X to turn on Main Lights and Raise Blinds";
			if (Input.GetKeyDown (KeyCode.X)) {
				MainLights.SetActive (true);
				SpotLights.SetActive (false);
				Blinds.GetComponent<Animation> ().Play ("OpenBlinds");
				itson = true;
			}
		}

	}
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
}
