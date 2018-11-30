using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltNotice : MonoBehaviour {

	// Use this for initialization
	public GameObject SwitchAlert;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		SwitchAlert.GetComponent<Text> ().text = "Click on the Bolt to turn it";
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
}
