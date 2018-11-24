using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePuzzleSight : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerStay(){
		GameManager.instance.CubeInSight = true;
	}
	void OnTriggerExit(){
		GameManager.instance.CubeInSight = false;
	}
}
