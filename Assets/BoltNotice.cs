using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoltNotice : MonoBehaviour {

	// Use this for initialization
	public GameObject SwitchAlert;
	public GameObject Gate;
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		if (!Gate.GetComponent<FirstBolt> ().opened) {
			SwitchAlert.GetComponent<Text> ().text = "James: This is a weird contraption, maybe i should try turning the big bolt";
		}
	}
	void OnTriggerExit(){
		SwitchAlert.GetComponent<Text> ().text = "";
	}
}
