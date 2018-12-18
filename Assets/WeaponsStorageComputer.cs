using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponsStorageComputer : MonoBehaviour {

	// Use this for initialization
	public GameObject LoudSpeaker;
	public GameObject Gate;
	bool itsopen;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if(Input.GetKeyDown(KeyCode.X) && !itsopen){
			if(!GameManager.instance.ComputersOn){
					LoudSpeaker.GetComponent<Text> ().text = "LoudSpeaker: *Mainframe is turned off*";
			
			}else{
				Gate.GetComponent<Animation> ().Play ("OpenStorageGate");
				itsopen = true;
			}
		}
		if (itsopen) {
			LoudSpeaker.GetComponent<Text> ().text = "Special Weapon Storage is open";
		}
	}
	void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
	void OnTriggerEnter(){
		LoudSpeaker.GetComponent<Text> ().text = "Press X to wepons storage room";
	}
}