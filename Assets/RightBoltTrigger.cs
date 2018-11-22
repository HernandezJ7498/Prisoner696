using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightBoltTrigger : MonoBehaviour {

	// Use this for initialization
	bool alreadyon;
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerStay(){
		if (!alreadyon) {
			GameManager.instance.RightTrigger = true;
			alreadyon = true;
		}
	}
	void OnTriggerExit(){
		GameManager.instance.RightTrigger = false;
		alreadyon = false;
	}
}

