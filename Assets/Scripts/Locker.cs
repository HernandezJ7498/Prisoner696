using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Locker : MonoBehaviour {

	// Use this for initialization
	public GameObject LockerDoor;
	bool IsOpen;
	public GameObject SwitchAlert;
	public GameObject Glasses;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if(GameManager.instance.BeganBathroomSequence){	
			if (!IsOpen) {
				SwitchAlert.GetComponent<Text> ().text = "Press X to Open Locker Door";
				if (Input.GetKeyDown (KeyCode.X)) {
					IsOpen = true;
					LockerDoor.GetComponent<Animation> ().Play ("OpenLocker");
					Glasses.GetComponent<BoxCollider> ().enabled = true; 
				}
			} else {
				SwitchAlert.GetComponent<Text>().text = "";
			}
		}
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
}
