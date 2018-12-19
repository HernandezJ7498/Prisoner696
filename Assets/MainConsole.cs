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
	public GameObject CharacterTalks;
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
				CharacterTalks.GetComponent<Text> ().text = "Voice: HELLO? ANYONE THERE? WHO TURNED THOSE LIGHTS ON? HELLOOO??";
				StartCoroutine (emptytalk ());
			}
		} else {
			LoudSpeaker.GetComponent<Text> ().text = "";
		}

	}
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
	IEnumerator emptytalk(){
		yield return new WaitForSeconds (10);
		CharacterTalks.GetComponent<Text>().text = "";
	}
}
