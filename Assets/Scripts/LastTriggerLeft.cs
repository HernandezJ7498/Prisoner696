using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastTriggerLeft : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		GameManager.instance.LastTriggerLeft = true;
	}
	void OnTriggerExit(){
		GameManager.instance.LastTriggerLeft = false;
	}
}
