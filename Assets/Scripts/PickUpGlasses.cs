using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUpGlasses : MonoBehaviour {

	// Use this for initialization
	bool PickedUp;
	public GameObject SwitchAlert;
	public GameObject MenuHelp;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if (!PickedUp) {
			SwitchAlert.GetComponent<Text> ().text = "Press X to Pick Up XRay Glasses";
			if (Input.GetKeyDown (KeyCode.X)) {
				GameManager.instance.FoundGlasses = true;
				PickedUp = true;
				MenuHelp.SetActive (true);
			}
		} else {
			SwitchAlert.GetComponent<Text>().text = "";
		}
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text>().text = "";
		if(PickedUp){
			Destroy (gameObject);
		}
	}
}
