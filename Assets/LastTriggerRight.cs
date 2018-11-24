using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LastTriggerRight : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(){
		GameManager.instance.LastTriggerRight = true;
	}
	void OnTriggerExit(){
		GameManager.instance.LastTriggerRight = false;
	}
}

