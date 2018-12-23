using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sikebro : MonoBehaviour {

	// Use this for initialization
	public GameObject CharacterTalks;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if(!GameManager.instance.BridgeIsActive){	
			if (!GameManager.instance.alreadydead) {
				CharacterTalks.GetComponent<Text> ().text = "James: Maybe i could make that jump if i tried running";
			} else {
				CharacterTalks.GetComponent<Text> ().text = "James: Yeah, Fuck that I'm just gonna try the buttons";
			}
		}
	}
	void OnTriggerExit(){
		CharacterTalks.GetComponent<Text> ().text = "";
	}
}
