using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryPickUp : MonoBehaviour {

	// Use this for initialization
	public GameObject LoudSpeaker;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void OnTriggerStay(){
		LoudSpeaker.GetComponent<Text> ().text = "Press X to pickup battery";
		if (Input.GetKeyDown (KeyCode.X)) {
			LoudSpeaker.GetComponent<Text> ().text = "";
			Destroy(gameObject);
		}
	}
	public void OnTriggerExit(){
		LoudSpeaker.GetComponent<Text> ().text = "";
	}
	void OnDestroy(){
		GameManager.instance.GunEventSequence += 1;
	}
}
