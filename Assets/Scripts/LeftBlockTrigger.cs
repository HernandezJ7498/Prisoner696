using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftBlockTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter(){
		GameManager.instance.LeftBlockTrigger = true;
	}
}
