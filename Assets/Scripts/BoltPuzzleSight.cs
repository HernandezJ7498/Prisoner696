using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltPuzzleSight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		GameManager.instance.InSight = true;
	}
	void OnTriggerExit(){
		GameManager.instance.InSight = false;
	}
}
